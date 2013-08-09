using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Authentication
{
    public class UserProfile
    {
        #region Public Method
        public UserAuthorize GetAuthorizeByProgramID(string programId)
        {
            UserAuthorize authorize = null;

            if (Authorizations != null)
            {
                authorize = Authorizations.Where(a => a.ProgramId.Equals(programId)).FirstOrDefault();
            }

            return authorize;
        }
        #endregion

        #region Properties
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string GroupCd { get; set; }
        public string SaltKey { get; set; }
        public IList<UserAuthorize> Authorizations { get; set; }
        #endregion
    }
}
