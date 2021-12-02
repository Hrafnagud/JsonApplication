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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If there is an open form, exit.
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
                FormCitySearch formCitySearch = new FormCitySearch();
                formCitySearch.MdiParent = this;
                formCitySearch.Show();
                this.LayoutMdi(MdiLayout.TileVertical);

            }
        }
    }
}
