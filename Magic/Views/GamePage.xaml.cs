
namespace Magic.Views;

public partial class GamePage : ContentPage
{

	
	const int Min =1;
    const int Max =10;
    
    int enterMagic, nbreMagic, nbreSaisi =10, saisiEff = 0;

    private void Fc(object sender, FocusEventArgs e)
    {

    }

    public GamePage()
	{
		InitializeComponent();
        minGame.Text = "entre " +Min +" et " +Max;
        nbreMagic = new Random().Next(Min, Max);
        NavigationPage.SetHasNavigationBar(this, false);
    }

    void Devine(object sender, EventArgs e)
    {


        if(string.IsNullOrWhiteSpace(Enter.Text))
        {
            DisplayAlert("Humm !", "Enter the number", "OK");
            return;
        }


        

        /*
        while (enterMagic != nbreMagic && nbreSaisi != saisiEff)
        {
            */
        enterMagic = 0;
        try
        {
            enterMagic = Int32.Parse(Enter.Text);
        }
        catch (Exception ex)
        {
            DisplayAlert(Title, ex.Message, "OK");
            return;
        }

            if (nbreMagic < enterMagic && enterMagic < Max)
            {
                DisplayAlert("Reesseyer", "Vous etes au dessus", "Ok");
                saisiEff++;
            return;
            }
            else if (enterMagic == nbreMagic)
            {
#pragma warning disable CS4014
            WinAction();
#pragma warning restore CS4014
        }
        else if (nbreMagic > enterMagic && enterMagic > Min)
            {
                DisplayAlert("Reesseyer", "Vous etes en dessous", "Ok");
                saisiEff++;
            return;
            }
            else if ((enterMagic < Min) || (enterMagic > Max))
            {
                DisplayAlert("Reesseyer", "vous n'etes pas sur la plage", "Ok");
                return;
            }



        //}




    }

    private async Task WinAction()
    {
        await Navigation.PushAsync(new WinPage(nbreMagic));
    }

}