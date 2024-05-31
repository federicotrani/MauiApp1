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

    private void btnPrincipalSalir_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void btnPrincipalAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaPage());
    }
}