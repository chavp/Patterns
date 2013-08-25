using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Authentication
{
    public class UserAuthorize
    {
        #region Properties
        public string GroupCd { get; set; }

        public string ProgramId { get; set; }

        public bool CanAdd { get; set; }

        public bool CanEdit { get; set; }

        public bool CanDelete { get; set; }

        public bool CanDownload { get; set; }

        public bool IsAdmin { get; set; }
        #endregion
    }
}
