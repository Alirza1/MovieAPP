using GalaSoft.MvvmLight.CommandWpf;
using Movieve.Command;
using Movieve.Models;
using Movieve.Services;
using Movieve.Services.Serialization;
using Movieve.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Movieve.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string username;
        private string password;
        public string Username
        {
            get { return this.username; }
            set
            {
                if (!string.Equals(this.username, value))
                {
                    this.username = value;
                    this.OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get { return this.password; }
            set
            {
                if (!string.Equals(this.password, value))
                {
                    this.password = value;
                    this.OnPropertyChanged();
                }
            }
        }
        UserAuthentication authentication = new UserAuthentication();
        public RelayCommand<Window> LoginCommand { get; private set; }
        public RelayCommand<Window> GuestCommand { get; set; }
        private void AdminLogin(Window window)
        {
            if (window != null)
            {
                bool result = authentication.CheckCredentials(Username, Password);
                if (result == true)
                {
                    MainWindow mainWindow = new MainWindow();

                    window.Close();
                    mainWindow.Show();
                }
                if (result == false)
                {
                    Username = string.Empty;
                    Password = string.Empty;
                }

            }
        }
        private void GuestLogin(Window window)
        {
            if (window != null)
            {
                MainWindow guestWindow = new MainWindow();
                window.Close();
                guestWindow.Show();
            }
        }

        public LoginViewModel()
        {
            Username = string.Empty;
            Password = string.Empty;
            this.LoginCommand = new RelayCommand<Window>(this.AdminLogin, (c) =>
                 {
                     if (Username.Length < 1 && Password.Length < 1)
                     {
                         return false;
                     }
                     return true;
                 });
            this.GuestCommand = new RelayCommand<Window>(this.GuestLogin);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

}
