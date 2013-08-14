using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Repositories.Log
{
    using LSP.Models.Log;
    using LSP.Models.Repositories.Log;

    public class LogErrorRepository
        : Repository<LogError>, ILogErrorRepository
    {
        internal LogErrorRepository(LspContext context)
            : base(context)
        {

        }
    }
}
