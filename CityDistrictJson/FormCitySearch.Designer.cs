
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCitySelection = new System.Windows.Forms.ComboBox();
            this.buttonChooseCity = new System.Windows.Forms.Button();
            this.listViewCities = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.groupBoxCity = new System.Windows.Forms.GroupBox();
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.labelCityInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCity.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.buttonChooseCity.Click += new System.EventHandler(this.buttonChooseCity_Click);
            // 
            // listViewCities
            // 
            this.listViewCities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewCities.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewCities.GridLines = true;
            this.listViewCities.HideSelection = false;
            this.listViewCities.Location = new System.Drawing.Point(25, 92);
            this.listViewCities.Name = "listViewCities";
            this.listViewCities.Size = new System.Drawing.Size(551, 346);
            this.listViewCities.TabIndex = 3;
            this.listViewCities.UseCompatibleStateImageBehavior = false;
            this.listViewCities.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Contatct Number";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fax";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mail";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Web Site";
            this.columnHeader5.Width = 100;
            // 
            // groupBoxCity
            // 
            this.groupBoxCity.Controls.Add(this.richTextBoxDetails);
            this.groupBoxCity.Controls.Add(this.labelCityInfo);
            this.groupBoxCity.Location = new System.Drawing.Point(591, 92);
            this.groupBoxCity.Name = "groupBoxCity";
            this.groupBoxCity.Size = new System.Drawing.Size(197, 346);
            this.groupBoxCity.TabIndex = 4;
            this.groupBoxCity.TabStop = false;
            this.groupBoxCity.Text = "GroupBox";
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.Location = new System.Drawing.Point(6, 46);
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.ReadOnly = true;
            this.richTextBoxDetails.Size = new System.Drawing.Size(185, 294);
            this.richTextBoxDetails.TabIndex = 1;
            this.richTextBoxDetails.Text = "";
            // 
            // labelCityInfo
            // 
            this.labelCityInfo.AutoSize = true;
            this.labelCityInfo.Location = new System.Drawing.Point(3, 23);
            this.labelCityInfo.Name = "labelCityInfo";
            this.labelCityInfo.Size = new System.Drawing.Size(134, 20);
            this.labelCityInfo.TabIndex = 0;
            this.labelCityInfo.Text = "Information of City";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // showDetailToolStripMenuItem
            // 
            this.showDetailToolStripMenuItem.Name = "showDetailToolStripMenuItem";
            this.showDetailToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showDetailToolStripMenuItem.Text = "Show Detail";
            this.showDetailToolStripMenuItem.Click += new System.EventHandler(this.showDetailToolStripMenuItem_Click);
            // 
            // FormCitySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCity);
            this.Controls.Add(this.listViewCities);
            this.Controls.Add(this.buttonChooseCity);
            this.Controls.Add(this.comboBoxCitySelection);
            this.Controls.Add(this.label1);
            this.Name = "FormCitySearch";
            this.Text = "FormCitySearch";
            this.Load += new System.EventHandler(this.FormCitySearch_Load);
            this.groupBoxCity.ResumeLayout(false);
            this.groupBoxCity.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCitySelection;
        private System.Windows.Forms.Button buttonChooseCity;
        private System.Windows.Forms.ListView listViewCities;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBoxCity;
        private System.Windows.Forms.Label labelCityInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
    }
}