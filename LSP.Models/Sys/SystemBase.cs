using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Sys
{
    public abstract class SystemBase
        : ModelBase
    {
        #region Properties
        public DateTime? CreateDtm { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDtm { get; set; }

        public string UpdateBy { get; set; }

        public string ProgramID { get; set; }

        public string IPAddress { get; set; }

        public string MacAddress { get; set; }
        #endregion
    }
}
