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
                byte[] data = client.DownloadData(@"C:\Users\103SABAH_EMRE\source\repos\JsonApplication\municipalitiesFull.json");
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
    }
}
