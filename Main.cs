using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Controllers;
using FinalProject.Services;
using FinalProject.Models;
using FinalProject.UI;

namespace FinalProject
{
    public partial class WeatherApp : Form
    {
        private readonly WeatherAppController _controller;
        public WeatherApp(WeatherAppController controller)
        {
            InitializeComponent();
            _controller = controller;
            ReloadFavoritesDropdown();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                var report = _controller.Search(city_or_zip_textbox.Text);
                DisplayWeather(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_to_favorites_button_Click(object sender, EventArgs e)
        {
            _controller.AddToFavorites();
            ReloadFavoritesDropdown();
        }

        private void remove_from_favorites_button_Click(object sender, EventArgs e)
        {
            if (location_dropdown.SelectedItem is Location location)
            {
                _controller.RemoveFromFavorites(location);
                ReloadFavoritesDropdown();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            try
            {
                var report = _controller.Refresh();
                DisplayWeather(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Refresh failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void five_day_forecast_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<WeatherReport> forecast = _controller.Get5DayForecast();
                var f = new ForecastForm(forecast);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Forecast failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Location_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (location_dropdown.SelectedItem is Location location)
            {
                string input = !string.IsNullOrEmpty(location.ZipCode) ? location.ZipCode : location.City;
                var report = _controller.Search(input);
                DisplayWeather(report);
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
            location_label.Text = report.City.ToString();
            temperature_label.Text = $"{report.Temperature} °F";
            min_temp_label.Text = $"{report.MinTemperature} °F";
            max_temp_label.Text = $"{report.MaxTemperature} °F";
            condition_label.Text = report.Condition;
            humidity_label.Text = $"{report.Humidity}%";
            wind_speed_label.Text = $"{report.WindSpeed} mph";
        }
    }
}
