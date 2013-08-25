using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Log
{
    public class LogError : LogBase
    {
        #region Properties
        public string ApplicationName { get; set; }

        public string FunctionName { get; set; }

        public string SrcFileName { get; set; }

        public string StackTrace { get; set; }
        #endregion
    }
}
