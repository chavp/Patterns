using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Repositories.Master
{

    using LSP.Models.Master;
    using LSP.Models.Repositories.Master;

    public class AmphurRepository
        : Repository<Amphur>, IAmphurRepository
    {
        internal AmphurRepository(LspContext context)
            : base(context)
        {

        }
    }
}
