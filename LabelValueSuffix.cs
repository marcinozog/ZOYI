using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOYI
{
    public class LabelValueSuffix
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public string Suffix { get; set; }

        public LabelValueSuffix()
        {
            Label = "";
            Value = "";
            Suffix = "";
        }

        public void SetFromArray(string[] ret)
        {
            if (ret == null || ret.Length < 3)
                throw new ArgumentException("Array must contain three elements");

            Label = ret[0];
            Value = ret[1];
            Suffix = ret[2];
        }
    }
}
