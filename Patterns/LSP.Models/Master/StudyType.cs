using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Master
{
    public class StudyType
        : MasterBase
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int? Order { get; set; }
    }
}
