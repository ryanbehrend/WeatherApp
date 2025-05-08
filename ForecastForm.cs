using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.Models;

namespace FinalProject.UI
{
    public class ForecastForm : Form
    {
        private readonly DataGridView _grid;

        public ForecastForm(List<WeatherReport> forecast)
        {
            Text = "5-Day Forecast";
            Width = 687;
            Height = 372;
            StartPosition = FormStartPosition.CenterParent;

            _grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Day",
                DataPropertyName = nameof(WeatherReport.DateTime),
                Width = 110
            });
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Temp",
                DataPropertyName = nameof(WeatherReport.Temperature),
                Width = 60
            });
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Min",
                DataPropertyName = nameof(WeatherReport.MinTemperature),
                Width = 60
            });
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Max",
                DataPropertyName = nameof(WeatherReport.MaxTemperature),
                Width = 60
            });
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Condition",
                DataPropertyName = nameof(WeatherReport.Condition),
                Width = 90
            });
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Humidity (%)",
                DataPropertyName = nameof(WeatherReport.Humidity),
                Width = 70
            });
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Wind Speed (mph)",
                DataPropertyName = nameof(WeatherReport.WindSpeed),
                Width = 70
            });
            _grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precipitation (in)",
                DataPropertyName = nameof(WeatherReport.Precipitation),
                Width = 90
            });

            Controls.Add(_grid);

            _grid.DataSource = forecast;
        }
    }
}