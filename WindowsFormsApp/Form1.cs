using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private HubConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:2334/myhub")
                .Build();
            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
            };
            connection.On<List<WeatherForecast>>("transferdata", (data) =>
            {
                this.Invoke((Action)delegate
                {
                    foreach (var item in data)
                    {
                        var newData = $"{item.Summary}-{item.TemperatureC}-{item.Date}";
                        weatherForecastsList.Items.Add(newData);
                    }
                });
            });
            try
            {
                await connection.StartAsync();
                weatherForecastsList.Items.Add("Connection started");
            }
            catch (Exception ex)
            {
                weatherForecastsList.Items.Add(ex.Message);
            }
        }
    }
}