using BlazorDualMode2.Data;
using System;
using System.Threading.Tasks;

namespace BlazorDualMode2.Pages
{
    public partial class FetchData
    {
        public WeatherForecast[] Forecasts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}