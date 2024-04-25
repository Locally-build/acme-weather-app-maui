namespace acme_weather_app_maui
{
    public static class Config
    {
        public static string BaseUrl() {
            string baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
            return baseUrl ?? "http://localhost:5590";
        }
    }

}