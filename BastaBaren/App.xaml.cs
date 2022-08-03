using Android.App;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace BastaBaren;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

#if ANDROID
		
#endif

		MainPage = new AppShell();
	}
}
