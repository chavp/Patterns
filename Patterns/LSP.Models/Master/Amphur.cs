using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Master
{
    public class Amphur 
        : MasterBase
    {
        public string ID { get; set; }

        public string ProvinceID { get; set; }

        public string Name { get; set; }
    }
}
