using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Sys
{
    public class Language 
        : SystemBase
    {
        public string ID { get; set; }

        public string Abbreviation { get; set; }

        public string Name { get; set; }

        public int? Order { get; set; }

        public string Collation { get; set; }

        public string YearCulture { get; set; }

        public string YearCultureValue { get; set; }

        public string DefaultLanguageFlag { get; set; }

        public string ActiveFlag { get; set; }

    }
}
