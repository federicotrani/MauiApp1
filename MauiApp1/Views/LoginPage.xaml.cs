namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void btnLoginIngresar_Clicked(object sender, EventArgs e)
    {
		if(entLoginEmail.Text=="ites" && entLoginPassword.Text == "1234")
		{
			Navigation.PushAsync(new PrincipalPage());
		}else
		{
			DisplayAlert("Atenci�n","las credenciales ingresadas no son v�lidas","OK");
		}
    }
}