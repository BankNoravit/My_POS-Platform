using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POS.Common
{
    public class PARAM_AZURE_BLOB_COPY_FILE_TO
    {
        public string ACCESS_KEY { get; set; }
        public string CONTAINER_NAME { get; set; }              
        public string CONTAINER_NAME_TO { get; set; }         
        public string FILE_NAME_WITH_PATH { get; set; }    
        public string FILE_NAME_WITH_PATH_TO { get; set; }
    }
}
