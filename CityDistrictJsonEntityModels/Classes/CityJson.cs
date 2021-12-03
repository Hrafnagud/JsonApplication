using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDistrictJsonEntityModels.Classes
{
    public class CityJson
    {
        //To receive data from Json file prop names must be done with the same property names and in our case those file has small cases with turkish words
        //Meanings of the words are defined with comments
        public string il { get; set; }  //City
        public string plaka { get; set; }   //Plate
        public List<string> ilceleri { get; set; }  //City districts.
    }
}
