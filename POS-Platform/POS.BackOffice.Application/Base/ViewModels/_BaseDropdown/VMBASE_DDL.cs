using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{   // Inherit this class to Result Class
    public class VMBASE_DDL
    {
        public string TEXT { get; set; }
        public string VALUE { get; set; }
        public string VALUE02 { get; set; }
        public bool IS_DEFAULT { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
