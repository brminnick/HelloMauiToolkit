using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace HelloMauiToolkit
{
	[Register(nameof(AppDelegate))]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}