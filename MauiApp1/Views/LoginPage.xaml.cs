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
			entLoginPassword.Text = string.Empty;
			entLoginEmail.Text = string.Empty;
			Navigation.PushAsync(new PrincipalPage());
		}else
		{
            entLoginPassword.Text = string.Empty;
            entLoginEmail.Text = string.Empty;
            DisplayAlert("Atenci�n","las credenciales ingresadas no son v�lidas","OK");
		}
    }
}