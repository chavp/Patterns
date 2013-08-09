using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Master
{
    public abstract class MasterBase 
        : ModelBase
    {
        #region Properties
        public int RecordID { get; protected set; }

        public string LanguageID { get; set; }

        public string ActiveFlag { get; set; }

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
