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
    public partial class FormCitySearch : Form
    {
        public FormCitySearch()
        {
            InitializeComponent();
        }

        //GlobalArea
        CityService myCityService = new CityService();
        CityDistrictService myCityDistrictService = new CityDistrictService();
        private void FormCitySearch_Load(object sender, EventArgs e)
        {
            //While Form loading
            myCityService.ListCities();
            comboBoxCitySelection.DataSource = myCityService.ListCities();
            comboBoxCitySelection.DisplayMember = "CityName";
            comboBoxCitySelection.ValueMember = "PlateCode";

            //Filling the content of ListView.
            List<CityDistrictInfo> InfoBelongedToCity = myCityDistrictService.ListCityDistrict();
            foreach (var item in InfoBelongedToCity)
            {
                ListViewItem myValue = new ListViewItem()
                {
                    Text = item.Name,
                    Tag = item
            };
                myValue.SubItems.Add(item.ContactNumber);
                myValue.SubItems.Add(item.Fax);
                myValue.SubItems.Add(item.Mail);
                myValue.SubItems.Add(item.Web);
                listViewCities.Items.Add(myValue);
            }

            //group box must be hidden at first.
            groupBoxCity.Enabled = false;
            groupBoxCity.Visible = false;
            //Right Click Menu is required. That control exists in toolbox. but we will implement it through code screen rather than on design window.
            

        }

        private void buttonChooseCity_Click(object sender, EventArgs e)
        {
            //We want to monitor the chosen city's information.
            //Contidion with Linq
            City chosenCity = (City)comboBoxCitySelection.SelectedItem;
            CityDistrictInfo chosenCityInfo = myCityDistrictService.ListCityDistrict().Where(x => x.PlateCode == chosenCity.PlateCode).FirstOrDefault();
            listViewCities.Items.Clear();
            ListViewItem myValue = new ListViewItem();
            myValue.Text = chosenCityInfo.Name;
            myValue.Tag = chosenCityInfo;
            myValue.SubItems.Add(chosenCityInfo.ContactNumber);
            myValue.SubItems.Add(chosenCityInfo.Fax);
            myValue.SubItems.Add(chosenCityInfo.Mail);
            myValue.SubItems.Add(chosenCityInfo.Web);
            listViewCities.Items.Add(myValue);
        }

        private void showDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxCity.Enabled = true;
            groupBoxCity.Visible = true;
            CityDistrictInfo chosenCity = (CityDistrictInfo)listViewCities.FocusedItem.Tag;
            richTextBoxDetails.Text = chosenCity.Information;
            
        }
    }
}
