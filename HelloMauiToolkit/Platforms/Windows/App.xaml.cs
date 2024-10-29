using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace HelloMauiToolkit.WinUI;

public partial class App : MauiWinUIApplication
{
	public App() => InitializeComponent();

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
