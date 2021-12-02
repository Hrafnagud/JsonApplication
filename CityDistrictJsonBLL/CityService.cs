using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CityDistrictJsonEntityModels.Classes;
namespace CityDistrictJsonBLL
{
    public class CityService
    {
        private string JSonString = string.Empty;
        public CityService()
        {
            ConnectDataSource();
        }

        private void ConnectDataSource()
        {
            using (WebClient client = new WebClient())
            {
                byte[] data = client.DownloadData(@"C:\Users\103SABAH_EMRE\source\repos\JsonApplication\municipalities.json");
                //Turkish content of Json can be corrupted while translation. Encoding provides solution for this issue.
                JSonString = Encoding.UTF8.GetString(data);
            }
        }

        public List<City> ListCities()
        {
            return JsonConvert.DeserializeObject<List<City>>(JSonString);
        }
    }
}
