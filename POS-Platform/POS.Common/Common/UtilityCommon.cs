using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO;
using UrlCombineLib;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Data.OleDb;
using ExcelDataReader;
using System.Globalization;

namespace POS.Common
{
    public interface IUtilityCommon
    {
        #region [Group: Converter]

        // System type
        T ConvertTo<T>(object value);
        T? ConvertToNullable<T>(object value) where T : struct, IConvertible;

        // Generic List & DataTable
        IEnumerable<string> ConvertStringToIEnumerable(string str, int sizePerRow);
        DataTable ConvertGenericListToDataTable<T>(IEnumerable<T> data, bool columnNameByDisplayName = false);
        Task<DataTable> ConvertExcelToDataTable(string currentDir, string wwwrootPath, IFormFile excelFile, bool autoBackupFile = false);

        // Date & Time
        DateTime? ToDateTimeExactDMY24HMS(string dateTimeStr, string delimiter = "/");
        #endregion [Group: Converter]

        #region [Group: File]

        // File
        string CombineFileNameAndExtension(string fileName, string fileExtension);
        string GetUniqueFileName(string fileName, string dateFormat = "yyyyMMddHHmmssfff");
        void MoveAllFile(string sourcePath, string newPath);

        // Path
        string CombinePathAndFileName(string fileName, string basePath);
        string CombinePathAndFileName(string fileName, string basePath, params string[] paths);

        // Url
        string CombineUrl(string baseUrl, params string[] relativePaths);
        string CombineUrlAndFileName(string fileName, string baseUrl);
        string CombineUrlAndFileName(string fileName, string baseUrl, params string[] relativePaths);

        // File Converter
        Stream ConvertBase64FileToStream(string base64EncodedData);
        Stream ConvertBase64VideoFileToStream(string base64EncodedData, bool removeBase64Header = true);
        Stream ConvertBase64ImgFileToStream(string base64EncodedData, bool removeBase64Header = true);
        Stream ConvertBase64ImgOrPdfFileToStream(string base64EncodedData, bool removeBase64Header = true);

        #endregion [Group: File]

        #region [Group: Formatter]

        // String Concat: Person Name
        string FormatPersonName(string firstName, string lastName, string titleName = null, string middleName = null);
        string FormatPersonNameRequiredFirstName(string firstName, string lastName = null, string titleName = null, string middleName = null);

        // String Contact: General
        string ConcatStringParams(string delimiter, params string[] text);

        #endregion [Group: Formatter]

        #region [Group: Models]

        // Verify property name of model
        bool IsValidPropertyNameOfModel<T>(string propertyName, bool verifyCaseSensitive = false, string ignoreIdentityPropertyName = "id");

        #endregion [Group: Models]
    }

    public partial class UtilityCommon : IUtilityCommon
    {
        public const string defaultFileExtension = ".jpg";

        public UtilityCommon() { }

        #region [Group: Converter]

        #region [System type]
        public T ConvertTo<T>(object value)
        {
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }

        public T? ConvertToNullable<T>(object value) where T : struct, IConvertible
        {
            try
            {
                if (value == null)
                    return null;

                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return null;
            }
        }
        #endregion [System type]

        #region [Generic List & DataTable]
        public IEnumerable<string> ConvertStringToIEnumerable(string str, int sizePerRow)
        {
            if (sizePerRow < 1)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < str.Length; i += sizePerRow)
            {
                if (str.Length - i > sizePerRow)
                {
                    yield return str.Substring(i, sizePerRow);
                }
                else
                {
                    yield return str.Substring(i, str.Length - i);
                }
            }
        }

        public DataTable ConvertGenericListToDataTable<T>(IEnumerable<T> data, bool columnNameByDisplayName = false)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                // prop.DisplayName: Data Annotation [DisplayName("XXXX")] 
                table.Columns.Add((columnNameByDisplayName ? prop.DisplayName : prop.Name), Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[(columnNameByDisplayName ? prop.DisplayName : prop.Name)] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        /// <summary>
        /// var dt = await this._excel.ConvertExcelToDataTable(currentDir: Directory.GetCurrentDirectory(), wwwrootPath: "uploaded/Test/01", excelFile: file, keepFile: false);
        /// </summary>
        /// <param name="currentDir"></param>
        /// <param name="wwwrootPath"></param>
        /// <param name="excelFile"></param>
        /// <param name="keepFile"></param>
        /// <returns></returns>
        public async Task<DataTable> ConvertExcelToDataTable(string currentDir, string wwwrootPath, IFormFile excelFile, bool autoBackupFile = false)
        {
            DataTable dt = new DataTable();
            try
            {
                var filename = this.GetUniqueFileName(fileName: excelFile.FileName);
                var MainPath = Path.Combine(currentDir, "wwwroot", wwwrootPath);

                if (!Directory.Exists(MainPath))
                {
                    Directory.CreateDirectory(MainPath);
                }

                var filePath = Path.Combine(MainPath, filename);
                using (System.IO.Stream stream = new FileStream(filePath, FileMode.Create))
                {
                    await excelFile.CopyToAsync(stream);
                }


                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        dt = reader.AsDataSet().Tables[0];
                    }
                }

                if (autoBackupFile == false)
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        #endregion [Generic List & DataTable]

        #region [Date & Time]
        /// <summary>
        /// ** delimiter must match in dateTimeStr
        /// </summary>
        /// <param name="dateTimeStr"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DateTime? ToDateTimeExactDMY24HMS(string dateTimeStr, string delimiter = "/")
        {   // CultureInfo: InvariantCulture
            DateTime? result = null;
            try
            {
                if (!string.IsNullOrEmpty(dateTimeStr))
                {
                    var arrDate = dateTimeStr.Split(" ");

                    // Date Format
                    var date = arrDate[0];
                    var arrDMY = date.Split(delimiter);
                    var newDate = (arrDMY[0].Length < 2 ? "0" + arrDMY[0] : arrDMY[0]) + delimiter + 
                                  (arrDMY[1].Length < 2 ? "0" + arrDMY[1] : arrDMY[1]) + delimiter + 
                                  arrDMY[2];

                    // Time Format
                    var arrTime = arrDate[1].Split(":");
                    var newTime = (arrTime[0].Length < 2 ? "0" + arrTime[0] : arrTime[0]) + ":" + 
                                  (arrTime[1].Length < 2 ? "0" + arrTime[1] : arrTime[1]);
                    newTime = arrTime.Length < 3 ? newTime + ":00" : (newTime + ":" + arrTime[2]);

                    // Time Converter
                    var _timeBeforeConvert = arrDate.Length < 3 ? newTime : (newTime + " " + arrDate[2]);
                    var formatTime = arrDate.Length < 3 ? "HH:mm:ss" : "hh:mm:ss tt";
                    var time24H = DateTime.ParseExact(_timeBeforeConvert, formatTime, CultureInfo.InvariantCulture).ToString("HH:mm:ss");

                    // DateTime Converter
                    string formatDateTime = $"dd{delimiter}MM{delimiter}yyyy HH:mm:ss";
                    string newDateTimeStr = newDate + " " + time24H;
                    result = DateTime.ParseExact(newDateTimeStr, formatDateTime, CultureInfo.InvariantCulture);
                }
                return result;
            }
            catch(Exception ex)
            {
                throw new Exception("Invalid dateTimeStr. (dateTimeStr sort by example: day/month/year)");
            }
        }

        #endregion [Date & Time]

        #endregion [Group: Converter]

        #region [Group: File]

        #region [File]
        public string CombineFileNameAndExtension(string fileName, string fileExtension)
        {
            try
            {
                if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(fileExtension))
                {
                    if (string.IsNullOrEmpty(Path.GetExtension(fileName)))
                    {
                        fileExtension = fileExtension.Trim();

                        if (fileExtension.IndexOf(".") < 0)
                            fileExtension = "." + fileExtension;

                        fileName += fileExtension.ToLower();
                    }
                    return fileName.Trim();
                }
                else
                {
                    throw new Exception("File name or file extension has empty.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetUniqueFileName(string fileName, string dateFormat = "yyyyMMddHHmmssfff")
        {
            string result = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(fileName) && Path.HasExtension(fileName))
                {
                    string prefixFileName = DateTime.Now.ToString(dateFormat);
                    string fileExtension = (Path.HasExtension(fileName) ? Path.GetExtension(fileName) : defaultFileExtension);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string uniqueFileName = string.Format("{0}_{1}", prefixFileName, fileNameWithoutExtension.Replace(" ", "_").Replace(".", "_"));
                    result = this.CombineFileNameAndExtension(fileName: uniqueFileName, fileExtension: fileExtension);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MoveAllFile(string sourcePath, string newPath)
        {
            try
            {
                if (Directory.Exists(sourcePath))
                {
                    foreach (var file in new DirectoryInfo(sourcePath).GetFiles())
                    {
                        file.MoveTo($@"{newPath}\{file.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [File]

        #region [Path]
        public string CombinePathAndFileName(string fileName, string basePath)
        {
            try
            {
                return Path.Combine(basePath, Path.GetFileName(fileName));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CombinePathAndFileName(string fileName, string basePath, params string[] paths)
        {
            try
            {
                return Path.Combine(Path.Combine(basePath, Path.Combine(paths: paths)), Path.GetFileName(fileName));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [Path]

        #region [Url]
        public string CombineUrl(string baseUrl, params string[] relativePaths)
        {
            try
            {
                return UrlCombine.Combine(baseUrl: baseUrl, relativePaths: relativePaths);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CombineUrlAndFileName(string fileName, string baseUrl)
        {
            try
            {
                return UrlCombine.Combine(baseUrl: baseUrl, relativeUrl: Path.GetFileName(fileName));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CombineUrlAndFileName(string fileName, string baseUrl, params string[] relativePaths)
        {
            try
            {
                return UrlCombine.Combine(UrlCombine.Combine(baseUrl: baseUrl, relativePaths: relativePaths), Path.GetFileName(fileName));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [Url]

        #region [File Converter]
        public Stream ConvertBase64FileToStream(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return new MemoryStream(base64EncodedBytes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Stream ConvertBase64VideoFileToStream(string base64EncodedData, bool removeBase64Header = true)
        {
            try
            {
                var removedBase64Header = (removeBase64Header ? Regex.Replace(base64EncodedData, @"^data:video\/[a-zA-Z0-9]+;base64,", string.Empty) : base64EncodedData);
                var base64EncodedBytes = System.Convert.FromBase64String(removedBase64Header);
                return new MemoryStream(base64EncodedBytes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Stream ConvertBase64ImgFileToStream(string base64EncodedData, bool removeBase64Header = true)
        {
            try
            {
                var removedBase64Header = (removeBase64Header ? Regex.Replace(base64EncodedData, @"^data:image\/[a-zA-Z]+;base64,", string.Empty) : base64EncodedData);
                var base64EncodedBytes = System.Convert.FromBase64String(removedBase64Header);
                return new MemoryStream(base64EncodedBytes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Stream ConvertBase64ImgOrPdfFileToStream(string base64EncodedData, bool removeBase64Header = true)
        {
            try
            {
                var removedBase64ImgHeader = (removeBase64Header ? Regex.Replace(base64EncodedData, @"^data:image\/[a-zA-Z]+;base64,", string.Empty) : base64EncodedData);
                var removedBase64PdfHeader = (removeBase64Header ? Regex.Replace(removedBase64ImgHeader, @"^data:application/pdf;base64,", string.Empty) : base64EncodedData);

                var base64EncodedBytes = System.Convert.FromBase64String(removedBase64PdfHeader);
                return new MemoryStream(base64EncodedBytes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [File Converter]

        #endregion [Group: File]

        #region [Group: Formatter]

        #region [String Concat: Person Name]
        /// <summary>
        ///     Format Person name
        /// </summary>
        /// <param name="firstName">Required</param>
        /// <param name="lastName">Required</param>
        /// <param name="middleName">Optional</param>
        /// <returns>
        ///     Case 1: "FirstName LastName"
        ///     Case 2: "FirstName MiddleName LastName"
        ///     Case 3: "TitleName FirstName LastName"
        ///     Case 4: "TitleName FirstName MiddleName LastName"
        /// </returns>
        public string FormatPersonName(string firstName, string lastName, string titleName = null, string middleName = null)
        {
            string result = null;
            try
            {
                if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                {
                    titleName = (string.IsNullOrEmpty(titleName) ? string.Empty : titleName.Trim() + " ");
                    middleName = (string.IsNullOrEmpty(middleName) ? " " : " " + middleName.Trim() + " ");
                    result = string.Format("{0}{1}{2}{3}", titleName, firstName.Trim(), middleName, lastName.Trim()).Trim();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     Format Person name Or Not 
        ///     Such as: Company name 
        /// </summary>
        /// <param name="firstName">Required</param>
        /// <param name="lastName">Optional</param>
        /// <param name="middleName">Optional</param>
        /// <returns>
        ///     Case 1: "FirstName"
        ///     Case 2: "TitleName FirstName"
        ///     Case N: From Method "FormatPersonName"
        /// </returns>
        public string FormatPersonNameRequiredFirstName(string firstName, string lastName = null, string titleName = null, string middleName = null)
        {
            string result = null;
            try
            {
                if (!string.IsNullOrEmpty(firstName))
                {
                    string _result = this.FormatPersonName(firstName: firstName, lastName: lastName, titleName: titleName, middleName: middleName);
                    if (_result == null)
                    {
                        titleName = (string.IsNullOrEmpty(titleName) ? string.Empty : titleName.Trim() + " ");
                        result = string.Format("{0}{1}", titleName, firstName.Trim()).Trim();
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [String Concat: Person Name]

        #region [String Contact: General]
        public string ConcatStringParams(string delimiter, params string[] text)
        {
            string result = null;
            try
            {
                if (string.IsNullOrEmpty(delimiter))
                    delimiter = string.Empty;

                if (text != null && text.Count() > 0)
                {
                    var textWithoutEmpty = text.Where(f => !string.IsNullOrEmpty(f)).ToArray();
                    result = string.Join(delimiter, textWithoutEmpty).Trim();
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion [String Contact: General]

        #endregion [Group: Formatter]

        #region [Group: Models]

        #region [Verify property name of model]
        public bool IsValidPropertyNameOfModel<T>(string propertyName, bool verifyCaseSensitive = false, string ignoreIdentityPropertyName = "id")
        {
            try
            {
                if (string.IsNullOrEmpty(propertyName))
                    return false;

                Type modelType = typeof(T);
                var props = modelType.GetProperties().ToList();
                return props.Any(a => ((
                                            verifyCaseSensitive == false &&
                                            a.Name.ToUpper() == propertyName.Trim().ToUpper()
                                      ) ||
                                      (
                                            verifyCaseSensitive == true &&
                                            a.Name == propertyName
                                      )) &&
                                      (
                                            string.IsNullOrEmpty(ignoreIdentityPropertyName) ||
                                            (
                                                !string.IsNullOrEmpty(ignoreIdentityPropertyName) &&
                                                ignoreIdentityPropertyName.ToUpper() != propertyName.Trim().ToUpper()
                                            )
                                      )
                );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [Verify property name of model]

        #endregion [Group: Models]
    }
}
