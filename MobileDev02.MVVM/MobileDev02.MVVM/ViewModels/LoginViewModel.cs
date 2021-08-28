using MobileDev02.MVVM.Views;
using MobileDev02.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;

namespace MobileDev02.MVVM.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel() {
            LoginCommand = new Command<User>(AuthenticateUser);
            NavigateToSignupCommand = new Command(async () => {
                await App.Current.MainPage.Navigation.PushModalAsync(new SignUpPage());
            });
        }

        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; set; }
        public ICommand NavigateToSignupCommand { get; set; }

        private async void AuthenticateUser(User user) {
            if (string.IsNullOrEmpty(user.Username)) {
                await App.Current.MainPage.DisplayAlert("Error: Falta información", "El campo del nombre de usuario no puede estar vacío.", "OK");
            }
            else if (string.IsNullOrEmpty(user.Password)) {
                await App.Current.MainPage.DisplayAlert("Error: Falta información", "El campo de contraseña no puede estar vacío.", "OK");
            }
            else {
                await App.Current.MainPage.DisplayAlert("Bienvenido", $"Hola {user.Username}", "Gracias");
            }
        }
    }
}
