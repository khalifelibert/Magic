namespace Magic.Views;

public partial class WinPage : ContentPage
{
    public WinPage() { }
	public WinPage(int nbreMagic)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);

        Bouge.Scale = 0.8;
        Bouge.ScaleTo(1.0, 1500, Easing.BounceIn);

        result.Text = "Le nombre est : " + nbreMagic;
        NavigateBk();

    }

/*
    private void RetourDepart(object sender, EventArgs e)
    {
        //this.Navigation.PushAsync(new WelcomPage());
        

    }*/

    private async Task NavigateBk()
    {
        await Task.Delay(4000);
        await Navigation.PopToRootAsync();
    }
}