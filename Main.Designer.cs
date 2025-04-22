namespace FinalProject
{
    partial class WeatherApp
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
            this.city_or_zip_label = new System.Windows.Forms.Label();
            this.city_or_zip_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.favorite_locations_label = new System.Windows.Forms.Label();
            this.location_dropdown = new System.Windows.Forms.ComboBox();
            this.unit_dropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // city_or_zip_label
            // 
            this.city_or_zip_label.AutoSize = true;
            this.city_or_zip_label.Location = new System.Drawing.Point(12, 18);
            this.city_or_zip_label.Name = "city_or_zip_label";
            this.city_or_zip_label.Size = new System.Drawing.Size(95, 13);
            this.city_or_zip_label.TabIndex = 0;
            this.city_or_zip_label.Text = "Enter a city or ZIP:";
            // 
            // city_or_zip_textbox
            // 
            this.city_or_zip_textbox.Location = new System.Drawing.Point(113, 15);
            this.city_or_zip_textbox.Name = "city_or_zip_textbox";
            this.city_or_zip_textbox.Size = new System.Drawing.Size(175, 20);
            this.city_or_zip_textbox.TabIndex = 1;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(297, 14);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // favorite_locations_label
            // 
            this.favorite_locations_label.AutoSize = true;
            this.favorite_locations_label.Location = new System.Drawing.Point(12, 47);
            this.favorite_locations_label.Name = "favorite_locations_label";
            this.favorite_locations_label.Size = new System.Drawing.Size(97, 13);
            this.favorite_locations_label.TabIndex = 3;
            this.favorite_locations_label.Text = "Favorite Locations:";
            // 
            // location_dropdown
            // 
            this.location_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_dropdown.FormattingEnabled = true;
            this.location_dropdown.Location = new System.Drawing.Point(113, 44);
            this.location_dropdown.Name = "location_dropdown";
            this.location_dropdown.Size = new System.Drawing.Size(175, 21);
            this.location_dropdown.TabIndex = 4;
            // 
            // unit_dropdown
            // 
            this.unit_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit_dropdown.FormattingEnabled = true;
            this.unit_dropdown.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.unit_dropdown.Location = new System.Drawing.Point(297, 44);
            this.unit_dropdown.Name = "unit_dropdown";
            this.unit_dropdown.Size = new System.Drawing.Size(75, 21);
            this.unit_dropdown.TabIndex = 5;
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.unit_dropdown);
            this.Controls.Add(this.location_dropdown);
            this.Controls.Add(this.favorite_locations_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.city_or_zip_textbox);
            this.Controls.Add(this.city_or_zip_label);
            this.Name = "WeatherApp";
            this.Text = "Weather App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label city_or_zip_label;
        private System.Windows.Forms.TextBox city_or_zip_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label favorite_locations_label;
        private System.Windows.Forms.ComboBox location_dropdown;
        private System.Windows.Forms.ComboBox unit_dropdown;
    }
}

