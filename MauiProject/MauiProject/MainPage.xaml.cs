namespace MauiProject;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnDialogBtnClicked(object sender, EventArgs e)
	{
		//await DisplayAlert("Title", "Message", string.Empty, "Cancel");
		MainThread.BeginInvokeOnMainThread(async () => await DisplayAlert("Title", "Message", string.Empty, "Cancel"));
	}
}


