namespace dkc_sarajevo_maui;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void OnLearnMoreClicked(object sender, EventArgs e)
	{
        await Launcher.Default.OpenAsync("https://linktr.ee/dkcsarajevo");
    }
}