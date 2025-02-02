using MauiLoginFlow.Services;
namespace MauiLoginFlow.Pages;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;
    public LoginPage(AuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;
        var response = _authService.Login(username, password);
        if (response)
            await Shell.Current.GoToAsync($"{nameof(MainPage)}");
        else
            await DisplayAlert("Error", "Invalid username or password", "OK");

    }
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");
    }
}