using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Log
{
    public abstract class LogBase
    {
        #region Properties
        public long ID { get; protected set; }

        public string Type { get; set; }

        public DateTime? Dtm { get; set; }

        public string By { get; set; }

        public string Desc { get; set; }

        public string SystemName { get; set; }

        public string ModuleName { get; set; }

        public string SPName { get; set; }

        public string WebBrowser { get; set; }

        public string ClientOS { get; set; }

        public string ClientIP { get; set; }

        public string ServerIP { get; set; }

        public string MacIP { get; set; }
        #endregion
    }
}
