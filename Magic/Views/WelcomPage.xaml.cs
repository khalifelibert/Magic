namespace Magic.Views;

public partial class WelcomPage : ContentPage
{
	public WelcomPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel

        InfinitB(play, 1000);
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
    }



    private async Task InfinitB(View view, uint length)
    {
        bool always = true;
        while (always)
        {
            await view.ScaleTo(1.2, length);
            await view.ScaleTo(1.0, length);
            
        }
    }


     void BtGame(object sender, EventArgs e)
    {
		this.Navigation.PushAsync(new GamePage());
    }
}