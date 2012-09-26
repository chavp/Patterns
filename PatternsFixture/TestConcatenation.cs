using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fit;

namespace PatternsFixture
{
    public class TestConcatenation : Fixture
    {
        public string FirstString;
        public string SecondString;
        public string Concatenate()
        {
            return FirstString + SecondString;
        }
        public void Clear()
        {
            FirstString = "";
        }
    }
}
