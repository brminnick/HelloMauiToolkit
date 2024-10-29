using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Accessibility;
using Application = Microsoft.Maui.Controls.Application;

namespace HelloMauiToolkit;

partial class App : Application
{
	public App(AppShell appShell)
	{
		InitializeComponent();

		MainPage = appShell;
	}
}