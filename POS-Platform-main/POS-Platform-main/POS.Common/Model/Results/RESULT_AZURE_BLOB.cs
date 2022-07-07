using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POS.Common
{
    public class RESULT_AZURE_BLOB
    {
        public bool IS_SUCCESS { get; set; }
        public string ABSOLUTE_URI { get; set; }
        public Stream STEAM { get; set; }
    }
}
