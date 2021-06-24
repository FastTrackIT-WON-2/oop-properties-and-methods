using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class Address
    {
        public string City { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string this[string part]
        {
            get
            {
                if (string.Equals(part,nameof(City), StringComparison.OrdinalIgnoreCase))
                {
                    return City;
                }
                else if (string.Equals(part, nameof(Street), StringComparison.OrdinalIgnoreCase))
                {
                    return Street;
                }
                else if (string.Equals(part, nameof(PostalCode), StringComparison.OrdinalIgnoreCase))
                {
                    return PostalCode;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
