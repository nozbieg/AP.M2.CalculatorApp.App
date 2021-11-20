using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace AP.M2.CalculatorApp
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}