using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POS.Common
{
    public class PARAM_AZURE_BLOB
    {
        public string ACCESS_KEY { get; set; }
        public string CONTAINER_NAME { get; set; }
        public string FILE_NAME { get; set; }            // FILE_NAME: Save as "STEAM" to azure blob by this file name(file name required file extension)
        public string FILE_NAME_WITH_PATH { get; set; }  // FILE_NAME_WITH_PATH: filename + sub path in blob container,  if haven't sub path => this param value must equal "FILE_NAME" value
        public Stream STEAM { get; set; }
    }
}
