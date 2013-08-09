using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using LSP.Models.Repositories.Master;

namespace LSP.Models.Master
{
    public class Province
        : MasterBase 
    {

        public IEnumerable<Amphur> GetAmphurs(IAmphurRepository amphurRepository)
        {
            return from amp in amphurRepository.All() 
                   where amp.ProvinceID == this.ID 
                   && amp.LanguageID == this.LanguageID
                   select amp;
        }

        public string ID { get; set; }

        public string RegionID { get; set; }

        public string Name { get; set; }

    }
}
