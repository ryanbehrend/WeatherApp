using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.Controllers;
using FinalProject.Models;

namespace FinalProject.UI
{
    public partial class WeatherApp : Form
    {
        private readonly WeatherAppController _controller;

        public WeatherApp(WeatherAppController controller)
        {
            InitializeComponent();
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));

            search_button.Click += Search_button_Click;
            refresh_button.Click += Refresh_button_Click;
            five_day_forecast_button.Click += Five_day_forecast_button_Click;
            add_to_favorites_button.Click += Add_to_favorites_button_Click;
            remove_from_favorites_button.Click += Remove_from_favorites_button_Click;
            location_dropdown.SelectedIndexChanged += Location_dropdown_SelectedIndexChanged;
            unit_dropdown.SelectedIndexChanged += Unit_dropdown_SelectedIndexChanged;

            unit_dropdown.SelectedIndex = 0;

            ReloadFavoritesDropdown();
        }

        private async void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                var report = await _controller.SearchAsync(city_or_zip_textbox.Text);
                DisplayWeather(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Refresh_button_Click(object sender, EventArgs e)
        {
            try
            {
                var report = await _controller.RefreshAsync();
                DisplayWeather(report);
            }
            catch (InvalidOperationException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Refresh failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Five_day_forecast_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<WeatherReport> forecast = await _controller.Get5DayForecastAsync();
                var form = new ForecastForm(forecast);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Forecast failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_to_favorites_button_Click(object sender, EventArgs e)
        {
            _controller.AddCurrentToFavorites();
            ReloadFavoritesDropdown();
        }

        private void Remove_from_favorites_button_Click(object sender, EventArgs e)
        {
            if (location_dropdown.SelectedItem is Location loc)
            {
                _controller.RemoveFromFavorites(loc);
                ReloadFavoritesDropdown();
            }
        }

        private async void Location_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (location_dropdown.SelectedItem is Location loc)
            {
                string input = !string.IsNullOrWhiteSpace(loc.ZipCode) ? loc.ZipCode : loc.City;
                try
                {
                    var report = await _controller.SearchAsync(input);
                    DisplayWeather(report);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load favorite: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Unit_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = unit_dropdown.SelectedItem.ToString();
            string units;

            if (selected == "Celsius")
                units = "metric";
            else if (selected == "Kelvin")
                units = "standard";
            else
                units = "imperial";

            _controller.ChangeUnits(units);

            try
            {
                var report = await _controller.RefreshAsync();
                DisplayWeather(report);
            }
            catch (InvalidOperationException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn’t refresh: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadFavoritesDropdown()
        {
            var favorites = _controller.GetFavorites();
            location_dropdown.DataSource = null;
            location_dropdown.DataSource = favorites;
        }

        private void DisplayWeather(WeatherReport report)
        {
            location_label.Text = report.City;
            temperature_label.Text = $"{report.Temperature:F1}°";
            min_temp_label.Text = $"{report.MinTemperature:F1}°";
            max_temp_label.Text = $"{report.MaxTemperature:F1}°";
            condition_label.Text = report.Condition;
            humidity_label.Text = $"{report.Humidity:F1}%";
            wind_speed_label.Text = $"{report.WindSpeed:F1}";
            precipitation_label.Text = $"{report.Precipitation}";
        }
    }
}
