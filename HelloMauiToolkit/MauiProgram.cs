using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace HelloMauiToolkit;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder()
								.UseMauiApp<App>()
								.UseMauiCommunityToolkit()
								.ConfigureFonts(fonts =>fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));

		// App
		builder.Services.AddTransient<App>();
		builder.Services.AddTransient<AppShell>();

		// Pages
		builder.Services.AddTransient<MainPage>();

		// Services
		builder.Services.AddSingleton(Microsoft.Maui.Accessibility.SemanticScreenReader.Default);

		return builder.Build();
	}
}