using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; } // Go koristime kako primaren kluch najcesto Id (normalno)
        public string Name { get; set; }
        public short SignUpFee { get; set; } // Vo ova prop gi ja cuvame cenata na tipot na pretplatat (kolku chini vo $)
        public byte DurationInMonths { get; set; } // Vo ova prop go cuvame vremetraenjeto na pretplatata pr: Monthly, Quarterly etc.
        public byte DiscountRate { get; set; } // Vo ova prop go cuvame popustot vo zavisnost od vremetraenjeto na pretplatata pr: za pogolema pretplata pogolem popust(discount)

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}