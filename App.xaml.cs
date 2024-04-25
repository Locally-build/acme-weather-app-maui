using System;
using System.Threading;

namespace acme_weather_app_maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
