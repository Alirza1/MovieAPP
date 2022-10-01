using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Net;
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
using Movieve.ViewModels;

namespace Movieve.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SearchPanelUC.xaml
    /// </summary>
    public partial class SearchPanelUC : UserControl
    {
        public SearchPanelUC()
        {
            this.DataContext = new SearchPanelUCViewModel();
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            PlayTrailerBtn.Visibility = Visibility.Visible;
            dot.Visibility = Visibility.Visible;
        }

        WebClient webClient = new WebClient();

        private void PlayTrailerBtn_Click(object sender, RoutedEventArgs e)
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("q", TitleTextBox.Text);

            webClient.QueryString.Add(nameValueCollection);

            var youtubesearch = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/results?search_query=" + TitleTextBox.Text+" trailer",
                UseShellExecute = true
            };
            Process.Start(youtubesearch);
        }
    }
}
