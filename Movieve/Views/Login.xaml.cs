using Movieve.Services;
using Movieve.Services.Serialization;
using Movieve.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Movieve.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            this.DataContext = new LoginViewModel();
            InitializeComponent();
            UserAuthentication authenticator = new UserAuthentication();
            authenticator.UserSerialize();
        }
    }
}
