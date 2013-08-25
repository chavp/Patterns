using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Repositories.Log
{
    using LSP.Models.Log;
    using LSP.Models.Repositories.Log;

    public class LogActivityRepository
        : Repository<LogActivity>, ILogActivityRepository
    {
        internal LogActivityRepository(LspContext context)
            : base(context)
        {

        }
    }
}
