namespace MauiApp1.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
	}

    private void btnAcercaVolver_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}