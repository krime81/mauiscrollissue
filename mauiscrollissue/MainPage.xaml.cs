namespace mauiscrollissue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnMakeVisibleButtonClicked(object sender, EventArgs e)
	{
        hiddenAtFirst.IsVisible = true;
        hiddenAtFirst.HeightRequest += 100;
	}
}


