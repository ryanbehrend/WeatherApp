﻿namespace FinalProject.UI
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
            this.location_label = new System.Windows.Forms.Label();
            this.temperature_label = new System.Windows.Forms.Label();
            this.min_temp_title_label = new System.Windows.Forms.Label();
            this.max_temp_title_label = new System.Windows.Forms.Label();
            this.condition_title_label = new System.Windows.Forms.Label();
            this.precipitation_title_label = new System.Windows.Forms.Label();
            this.wind_speed_title_label = new System.Windows.Forms.Label();
            this.humidity_title_label = new System.Windows.Forms.Label();
            this.min_temp_label = new System.Windows.Forms.Label();
            this.max_temp_label = new System.Windows.Forms.Label();
            this.condition_label = new System.Windows.Forms.Label();
            this.humidity_label = new System.Windows.Forms.Label();
            this.wind_speed_label = new System.Windows.Forms.Label();
            this.precipitation_label = new System.Windows.Forms.Label();
            this.add_to_favorites_button = new System.Windows.Forms.Button();
            this.remove_from_favorites_button = new System.Windows.Forms.Button();
            this.five_day_forecast_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // city_or_zip_label
            // 
            this.city_or_zip_label.AutoSize = true;
            this.city_or_zip_label.Location = new System.Drawing.Point(18, 28);
            this.city_or_zip_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.city_or_zip_label.Name = "city_or_zip_label";
            this.city_or_zip_label.Size = new System.Drawing.Size(139, 20);
            this.city_or_zip_label.TabIndex = 0;
            this.city_or_zip_label.Text = "Enter a city or ZIP:";
            // 
            // city_or_zip_textbox
            // 
            this.city_or_zip_textbox.Location = new System.Drawing.Point(170, 23);
            this.city_or_zip_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.city_or_zip_textbox.Name = "city_or_zip_textbox";
            this.city_or_zip_textbox.Size = new System.Drawing.Size(260, 26);
            this.city_or_zip_textbox.TabIndex = 1;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(446, 22);
            this.search_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(112, 35);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // favorite_locations_label
            // 
            this.favorite_locations_label.AutoSize = true;
            this.favorite_locations_label.Location = new System.Drawing.Point(18, 72);
            this.favorite_locations_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.favorite_locations_label.Name = "favorite_locations_label";
            this.favorite_locations_label.Size = new System.Drawing.Size(143, 20);
            this.favorite_locations_label.TabIndex = 3;
            this.favorite_locations_label.Text = "Favorite Locations:";
            // 
            // location_dropdown
            // 
            this.location_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_dropdown.FormattingEnabled = true;
            this.location_dropdown.Location = new System.Drawing.Point(170, 68);
            this.location_dropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.location_dropdown.Name = "location_dropdown";
            this.location_dropdown.Size = new System.Drawing.Size(260, 28);
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
            this.unit_dropdown.Location = new System.Drawing.Point(444, 68);
            this.unit_dropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unit_dropdown.Name = "unit_dropdown";
            this.unit_dropdown.Size = new System.Drawing.Size(110, 28);
            this.unit_dropdown.TabIndex = 5;
            // 
            // location_label
            // 
            this.location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_label.Location = new System.Drawing.Point(22, 123);
            this.location_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(536, 65);
            this.location_label.TabIndex = 6;
            this.location_label.Text = "City Name";
            this.location_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperature_label
            // 
            this.temperature_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_label.Location = new System.Drawing.Point(33, 200);
            this.temperature_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperature_label.Name = "temperature_label";
            this.temperature_label.Size = new System.Drawing.Size(525, 48);
            this.temperature_label.TabIndex = 7;
            this.temperature_label.Text = "N/A";
            this.temperature_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min_temp_title_label
            // 
            this.min_temp_title_label.AutoSize = true;
            this.min_temp_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_temp_title_label.Location = new System.Drawing.Point(37, 266);
            this.min_temp_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min_temp_title_label.Name = "min_temp_title_label";
            this.min_temp_title_label.Size = new System.Drawing.Size(131, 20);
            this.min_temp_title_label.TabIndex = 8;
            this.min_temp_title_label.Text = "Min Temp (3h)";
            this.min_temp_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max_temp_title_label
            // 
            this.max_temp_title_label.AutoSize = true;
            this.max_temp_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_temp_title_label.Location = new System.Drawing.Point(229, 266);
            this.max_temp_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max_temp_title_label.Name = "max_temp_title_label";
            this.max_temp_title_label.Size = new System.Drawing.Size(135, 20);
            this.max_temp_title_label.TabIndex = 9;
            this.max_temp_title_label.Text = "Max Temp (3h)";
            this.max_temp_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // condition_title_label
            // 
            this.condition_title_label.AutoSize = true;
            this.condition_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition_title_label.Location = new System.Drawing.Point(441, 266);
            this.condition_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.condition_title_label.Name = "condition_title_label";
            this.condition_title_label.Size = new System.Drawing.Size(88, 20);
            this.condition_title_label.TabIndex = 10;
            this.condition_title_label.Text = "Condition";
            this.condition_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precipitation_title_label
            // 
            this.precipitation_title_label.AutoSize = true;
            this.precipitation_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitation_title_label.Location = new System.Drawing.Point(429, 365);
            this.precipitation_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitation_title_label.Name = "precipitation_title_label";
            this.precipitation_title_label.Size = new System.Drawing.Size(115, 20);
            this.precipitation_title_label.TabIndex = 13;
            this.precipitation_title_label.Text = "Precipitation";
            this.precipitation_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wind_speed_title_label
            // 
            this.wind_speed_title_label.AutoSize = true;
            this.wind_speed_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind_speed_title_label.Location = new System.Drawing.Point(240, 365);
            this.wind_speed_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wind_speed_title_label.Name = "wind_speed_title_label";
            this.wind_speed_title_label.Size = new System.Drawing.Size(109, 20);
            this.wind_speed_title_label.TabIndex = 12;
            this.wind_speed_title_label.Text = "Wind Speed";
            this.wind_speed_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidity_title_label
            // 
            this.humidity_title_label.AutoSize = true;
            this.humidity_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity_title_label.Location = new System.Drawing.Point(62, 365);
            this.humidity_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidity_title_label.Name = "humidity_title_label";
            this.humidity_title_label.Size = new System.Drawing.Size(83, 20);
            this.humidity_title_label.TabIndex = 11;
            this.humidity_title_label.Text = "Humidity";
            this.humidity_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min_temp_label
            // 
            this.min_temp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_temp_label.Location = new System.Drawing.Point(58, 311);
            this.min_temp_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min_temp_label.Name = "min_temp_label";
            this.min_temp_label.Size = new System.Drawing.Size(93, 20);
            this.min_temp_label.TabIndex = 14;
            this.min_temp_label.Text = "N/A";
            this.min_temp_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max_temp_label
            // 
            this.max_temp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_temp_label.Location = new System.Drawing.Point(248, 311);
            this.max_temp_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max_temp_label.Name = "max_temp_label";
            this.max_temp_label.Size = new System.Drawing.Size(98, 20);
            this.max_temp_label.TabIndex = 15;
            this.max_temp_label.Text = "N/A";
            this.max_temp_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // condition_label
            // 
            this.condition_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition_label.Location = new System.Drawing.Point(429, 311);
            this.condition_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.condition_label.Name = "condition_label";
            this.condition_label.Size = new System.Drawing.Size(115, 20);
            this.condition_label.TabIndex = 16;
            this.condition_label.Text = "N/A";
            this.condition_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidity_label
            // 
            this.humidity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity_label.Location = new System.Drawing.Point(62, 411);
            this.humidity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidity_label.Name = "humidity_label";
            this.humidity_label.Size = new System.Drawing.Size(82, 22);
            this.humidity_label.TabIndex = 17;
            this.humidity_label.Text = "N/A";
            this.humidity_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wind_speed_label
            // 
            this.wind_speed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind_speed_label.Location = new System.Drawing.Point(240, 411);
            this.wind_speed_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wind_speed_label.Name = "wind_speed_label";
            this.wind_speed_label.Size = new System.Drawing.Size(114, 22);
            this.wind_speed_label.TabIndex = 18;
            this.wind_speed_label.Text = "N/A";
            this.wind_speed_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precipitation_label
            // 
            this.precipitation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitation_label.Location = new System.Drawing.Point(429, 411);
            this.precipitation_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitation_label.Name = "precipitation_label";
            this.precipitation_label.Size = new System.Drawing.Size(117, 22);
            this.precipitation_label.TabIndex = 19;
            this.precipitation_label.Text = "N/A";
            this.precipitation_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_to_favorites_button
            // 
            this.add_to_favorites_button.Location = new System.Drawing.Point(22, 466);
            this.add_to_favorites_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_to_favorites_button.Name = "add_to_favorites_button";
            this.add_to_favorites_button.Size = new System.Drawing.Size(248, 35);
            this.add_to_favorites_button.TabIndex = 20;
            this.add_to_favorites_button.Text = "Add to Favorites";
            this.add_to_favorites_button.UseVisualStyleBackColor = true;
            // 
            // remove_from_favorites_button
            // 
            this.remove_from_favorites_button.Location = new System.Drawing.Point(309, 466);
            this.remove_from_favorites_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_from_favorites_button.Name = "remove_from_favorites_button";
            this.remove_from_favorites_button.Size = new System.Drawing.Size(248, 35);
            this.remove_from_favorites_button.TabIndex = 21;
            this.remove_from_favorites_button.Text = "Remove from Favorites";
            this.remove_from_favorites_button.UseVisualStyleBackColor = true;
            // 
            // five_day_forecast_button
            // 
            this.five_day_forecast_button.Location = new System.Drawing.Point(309, 511);
            this.five_day_forecast_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.five_day_forecast_button.Name = "five_day_forecast_button";
            this.five_day_forecast_button.Size = new System.Drawing.Size(248, 35);
            this.five_day_forecast_button.TabIndex = 23;
            this.five_day_forecast_button.Text = "View 5-Day Forecast\r\nView Weather Details\r\n";
            this.five_day_forecast_button.UseVisualStyleBackColor = true;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(22, 511);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(248, 35);
            this.refresh_button.TabIndex = 22;
            this.refresh_button.Text = "Refresh Weather Data";
            this.refresh_button.UseVisualStyleBackColor = true;
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 562);
            this.Controls.Add(this.five_day_forecast_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.remove_from_favorites_button);
            this.Controls.Add(this.add_to_favorites_button);
            this.Controls.Add(this.precipitation_label);
            this.Controls.Add(this.wind_speed_label);
            this.Controls.Add(this.humidity_label);
            this.Controls.Add(this.condition_label);
            this.Controls.Add(this.max_temp_label);
            this.Controls.Add(this.min_temp_label);
            this.Controls.Add(this.precipitation_title_label);
            this.Controls.Add(this.wind_speed_title_label);
            this.Controls.Add(this.humidity_title_label);
            this.Controls.Add(this.condition_title_label);
            this.Controls.Add(this.max_temp_title_label);
            this.Controls.Add(this.min_temp_title_label);
            this.Controls.Add(this.temperature_label);
            this.Controls.Add(this.location_label);
            this.Controls.Add(this.unit_dropdown);
            this.Controls.Add(this.location_dropdown);
            this.Controls.Add(this.favorite_locations_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.city_or_zip_textbox);
            this.Controls.Add(this.city_or_zip_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.Label temperature_label;
        private System.Windows.Forms.Label min_temp_title_label;
        private System.Windows.Forms.Label max_temp_title_label;
        private System.Windows.Forms.Label condition_title_label;
        private System.Windows.Forms.Label precipitation_title_label;
        private System.Windows.Forms.Label wind_speed_title_label;
        private System.Windows.Forms.Label humidity_title_label;
        private System.Windows.Forms.Label min_temp_label;
        private System.Windows.Forms.Label max_temp_label;
        private System.Windows.Forms.Label condition_label;
        private System.Windows.Forms.Label humidity_label;
        private System.Windows.Forms.Label wind_speed_label;
        private System.Windows.Forms.Label precipitation_label;
        private System.Windows.Forms.Button add_to_favorites_button;
        private System.Windows.Forms.Button remove_from_favorites_button;
        private System.Windows.Forms.Button five_day_forecast_button;
        private System.Windows.Forms.Button refresh_button;
    }
}

