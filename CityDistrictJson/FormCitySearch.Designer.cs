
namespace CityDistrictJson
{
    partial class FormCitySearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCitySelection = new System.Windows.Forms.ComboBox();
            this.buttonChooseCity = new System.Windows.Forms.Button();
            this.listViewCities = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CITY:";
            // 
            // comboBoxCitySelection
            // 
            this.comboBoxCitySelection.FormattingEnabled = true;
            this.comboBoxCitySelection.Location = new System.Drawing.Point(94, 40);
            this.comboBoxCitySelection.Name = "comboBoxCitySelection";
            this.comboBoxCitySelection.Size = new System.Drawing.Size(512, 28);
            this.comboBoxCitySelection.TabIndex = 1;
            this.comboBoxCitySelection.Text = "Choose a City..";
            // 
            // buttonChooseCity
            // 
            this.buttonChooseCity.Location = new System.Drawing.Point(644, 40);
            this.buttonChooseCity.Name = "buttonChooseCity";
            this.buttonChooseCity.Size = new System.Drawing.Size(79, 29);
            this.buttonChooseCity.TabIndex = 2;
            this.buttonChooseCity.Text = "Choose";
            this.buttonChooseCity.UseVisualStyleBackColor = true;
            // 
            // listViewCities
            // 
            this.listViewCities.HideSelection = false;
            this.listViewCities.Location = new System.Drawing.Point(25, 88);
            this.listViewCities.Name = "listViewCities";
            this.listViewCities.Size = new System.Drawing.Size(698, 350);
            this.listViewCities.TabIndex = 3;
            this.listViewCities.UseCompatibleStateImageBehavior = false;
            // 
            // FormCitySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCities);
            this.Controls.Add(this.buttonChooseCity);
            this.Controls.Add(this.comboBoxCitySelection);
            this.Controls.Add(this.label1);
            this.Name = "FormCitySearch";
            this.Text = "FormCitySearch";
            this.Load += new System.EventHandler(this.FormCitySearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCitySelection;
        private System.Windows.Forms.Button buttonChooseCity;
        private System.Windows.Forms.ListView listViewCities;
    }
}