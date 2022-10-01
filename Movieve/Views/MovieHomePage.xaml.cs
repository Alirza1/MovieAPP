using Movieve.Models;
using Movieve.Services;
using Movieve.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Movieve.Views
{
    /// <summary>
    /// Interaction logic for MovieHomePage.xaml
    /// </summary>
    public partial class MovieHomePage : UserControl
    {
        public MovieHomePage()
        {
            this.DataContext = new MovieHomePageViewModel();
            InitializeComponent();
        }
    }
}
