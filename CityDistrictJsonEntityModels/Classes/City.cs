using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDistrictJsonEntityModels.Classes
{
    public class City
    {
        public string CityName { get; set; }
        public byte PlateCode { get; set; }
        public List<string> CityDistricts { get; set; }

    }
}
