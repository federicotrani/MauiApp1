namespace MauiApp1.Views;

public partial class PrincipalPage : ContentPage
{
	public PrincipalPage()
	{
		InitializeComponent();
	}

    private void btnRegresar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}