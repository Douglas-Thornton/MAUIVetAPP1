namespace MAUIVetAPP1;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        // Clear the SecureStorage when the application is closed
        SecureStorage.Remove("currentCount");
    }
}
