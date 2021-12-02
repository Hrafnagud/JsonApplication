using CityDistrictJsonBLL;
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
        private void FormCitySearch_Load(object sender, EventArgs e)
        {
            //While Form loading
            myCityService.ListCities();
            comboBoxCitySelection.DataSource = myCityService.ListCities();
            comboBoxCitySelection.DisplayMember = "City";
        }
    }
}
