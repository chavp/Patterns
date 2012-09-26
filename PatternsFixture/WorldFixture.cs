using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using fit;

namespace PatternsFixture
{
    public class WorldFixture : ColumnFixture
    {
        public int A { get; set; }
        public int B { get; set; }

        public int SumAB()
        {
            return A + B;
        }
    }
}
