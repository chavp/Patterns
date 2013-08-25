using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Log
{
    public class LogActivity : LogBase
    {
        #region Properties
        public string ResultStatus { get; set; }

        public string ResultDesc { get; set; }

        public string ProgName { get; set; }
        #endregion
    }
}
