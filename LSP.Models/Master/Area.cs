using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Master
{
    public class Area
        : MasterBase
    {
        public int ID { get; set; }

        public int BureauID { get; set; }

        public string Code { get; set; }

        public string Abbreviation { get; set; }

        public string Name { get; set; }

        public string AddressNo { get; set; }

        public string VillageName { get; set; }

        public string Moo { get; set; }

        public string Soi { get; set; }
    }
}
