namespace MauiProject;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var rootPage = new MainPage();
		MainPage = new NavigationPage(rootPage);
	}
}

