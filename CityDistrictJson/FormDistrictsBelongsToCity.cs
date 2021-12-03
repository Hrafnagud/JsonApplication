using CityDistrictJsonBLL;
using CityDistrictJsonEntityModels.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CityDistrictJson
{
    public partial class FormDistrictsBelongsToCity : Form
    {
        public FormDistrictsBelongsToCity()
        {
            InitializeComponent();
        }

        //Global scope
        CityService myCityService = new CityService();
        CityDistrictService myDistrictService = new CityDistrictService();

        private void FormDistrictsBelongsToCity_Load(object sender, EventArgs e)
        {
            comboBoxCities.DataSource = myCityService.ListCities();
            comboBoxCities.DisplayMember = "CityName";
            comboBoxCities.ValueMember = "PlateCode";
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the content inside combobox changed, this method will be invoked.
            City chosenCity = comboBoxCities.SelectedItem as City;
            // I need BLL to provide information. Such a method that will receive 
            List<CityDistrictInfo> districtsBelongsToCitiesList = myDistrictService.ListDistrictsOfCity(chosenCity.CityName);
            listView1.Items.Clear();
            foreach (var item in districtsBelongsToCitiesList)
            {
                ListViewItem list = new ListViewItem();
                list.Text = item.Name;
                list.Tag = item;
                list.SubItems.Add(item.ContactNumber);
                list.SubItems.Add(item.Mail);

                listView1.Items.Add(list);
            }
        }
    }
}
