using CityDistrictJsonEntityModels.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CityDistrictJsonBLL
{
    public class CityDistrictService
    {
        private string JsonString = string.Empty;
        CityService cityService = new CityService();
        public CityDistrictService()
        {
            ConnectDataSource();
        }

        private void ConnectDataSource()
        {
            using (WebClient client = new WebClient())
            {
                //byte[] data = client.DownloadData(System.Windows.Forms.Application.StartupPath + "/municipalitiesFull.json");
                byte[] data = client.DownloadData(@"C:\Users\Hrafnagud\source\repos\NetworkAcademy\December\3\municipalitiesFull.json");
                JsonString = Encoding.UTF8.GetString(data);
            }
        }

        public List<CityDistrictInfo> ListCityDistrict()
        {
            List<CityDistrictInfo> cityDistrictInfo = new List<CityDistrictInfo>();
            JObject j = JObject.Parse(JsonString);
            List<string> myCities = cityService.ListCities().Select(x => x.CityName).ToList();
            myCities = myCities.Select(x => LanguageCompatibility.TranslateTurkishCharsToEnglish(x.ToLower())).ToList();
            foreach (string item in myCities)
            {
                //foreach city, related information will be extracted from municipalitiesFull.json file.
                var data = j.SelectToken(item).SelectToken("il");
                CityDistrictInfo detailedInfo = new CityDistrictInfo();
                detailedInfo.PlateCode = Convert.ToByte(data["plaka"].ToObject<string>());
                detailedInfo.ContactNumber = data["belediye-tel"].ToObject<string>();
                detailedInfo.Fax = data["belediye-faks"].ToObject<string>();
                detailedInfo.Name = data["belediye-ismi"].ToObject<string>();
                detailedInfo.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                detailedInfo.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                detailedInfo.Population = data["nufus"].ToObject<string>();
                detailedInfo.AreaCode = data["alankodu"] == null ? "" : data["alankodu"].ToObject<string>();
                detailedInfo.Area = data["bolge"].ToObject<string>();
                detailedInfo.Information = data["bilgi"].ToString();
                cityDistrictInfo.Add(detailedInfo);
            }
            return cityDistrictInfo;
        }

        public List<CityDistrictInfo> ListDistrictsOfCity(string cityName)
        {
            List<CityDistrictInfo> CityDistrictList = new List<CityDistrictInfo>();
            JObject j = JObject.Parse(JsonString);
            //encoding is required again for json.

            List<string> myDistrictList = cityService.ListCities().Single(x => x.CityName == cityName).CityDistricts;    
            cityName = LanguageCompatibility.TranslateTurkishCharsToEnglish(cityName.ToLower());


            myDistrictList = myDistrictList.Select(x => LanguageCompatibility.TranslateTurkishCharsToEnglish(x.ToLower())).ToList();

            foreach (var item in myDistrictList)
            {
                var data = j.SelectToken(cityName.ToLower()).SelectToken(item);
                if (data != null)   //some city districts can be null so let's not caught by exception.
                {
                    CityDistrictInfo myInfo = new CityDistrictInfo();
                    myInfo.Name = data["belediye-ismi"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                    myInfo.ContactNumber = data["belediye-tel"] == null ? "" : data["belediye-tel"].ToObject<string>();
                    myInfo.Fax = data["belediye-faks"] == null ? "" : data["belediye-faks"].ToObject<string>();
                    myInfo.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                    myInfo.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                    myInfo.Population= data["nufus"].ToObject<string>();
                    myInfo.Information = data["bilgi"] == null ? "" : data["bilgi"].ToObject<string>();
                    CityDistrictList.Add(myInfo);
                }
            }
            return CityDistrictList;
        }
    }
}
