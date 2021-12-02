using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDistrictJsonEntityModels.Classes
{
    public class City
    {
        public string cityName { get; set; }
        public string plateCode { get; set; }
        public List<string> Districts { get; set; }

    }
}
