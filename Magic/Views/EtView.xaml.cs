namespace Magic.Views;

public partial class EtView : ContentView
{
	public EtView()
	{
		InitializeComponent();

#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
        Rotat(st0, 4000);
        Rotat(st1, 5000);
        Rotat(st2, 6000);
        
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel

    }

    private async Task Rotat(View view, uint length)
    {
        while (true)
        {
            await view.RotateTo(360, length);
            view.Rotation = 0;
        }
    }
}