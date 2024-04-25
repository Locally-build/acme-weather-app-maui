namespace acme_weather_app_maui
{
    public class WeatherService
    {
        public string BaseUrl = Config.BaseUrl();

        public async Task<string> GetWeatherAsync(string countryCode, string city)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{BaseUrl}/weather/{countryCode}/{city}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}