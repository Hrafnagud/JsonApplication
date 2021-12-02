
namespace CityDistrictJson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.districtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDistrictToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityToolStripMenuItem,
            this.districtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCityToolStripMenuItem});
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.cityToolStripMenuItem.Text = "City";
            // 
            // districtToolStripMenuItem
            // 
            this.districtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchDistrictToolStripMenuItem});
            this.districtToolStripMenuItem.Name = "districtToolStripMenuItem";
            this.districtToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.districtToolStripMenuItem.Text = "District";
            // 
            // searchCityToolStripMenuItem
            // 
            this.searchCityToolStripMenuItem.Name = "searchCityToolStripMenuItem";
            this.searchCityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchCityToolStripMenuItem.Text = "Search City";
            // 
            // searchDistrictToolStripMenuItem
            // 
            this.searchDistrictToolStripMenuItem.Name = "searchDistrictToolStripMenuItem";
            this.searchDistrictToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchDistrictToolStripMenuItem.Text = "Search District";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem districtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDistrictToolStripMenuItem;
    }
}

