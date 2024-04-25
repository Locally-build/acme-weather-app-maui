namespace acme_weather_app_maui;


public partial class MainPage : ContentPage
{
    private WeatherService _weatherService;

	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _weatherService = new WeatherService();
        var x = _weatherService.GetWeatherAsync("us", "seattle").Result;
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

