using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Repositories.Master
{
    using LSP.Models.Master;
    using LSP.Models.Repositories.Master;

    public class ProvinceRepository
        : Repository<Province>, IProvinceRepository
    {
        internal ProvinceRepository(LspContext context)
            : base(context)
        {

        }
    }
}
