using Movieve.Models;
using Movieve.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Movieve.ViewModels
{
    public class MovieHomePageViewModel : INotifyPropertyChanged
    {
        private string _poster;
        private string _genre;
        private string _title;
        public string Genre
        {
            get { return this._genre; }
            set
            {
                if (!string.Equals(this._genre, value))
                {
                    this._genre = value;
                    this.OnPropertyChanged();
                }
            }
        }
        public string Poster
        {
            get { return this._poster; }
            set
            {
                if (!string.Equals(this._poster, value))
                {
                    this._poster = value;
                    this.OnPropertyChanged();
                }
            }
        }
        public string Title
        {
            get { return this._title; }
            set
            {
                if (!string.Equals(this._title, value))
                {
                    this._title = value;
                    this.OnPropertyChanged();
                }
            }
        }


        public MovieHomePageViewModel()
        {
            SendRequest sender = new SendRequest();
            Poster = sender.GetPoster("Kolpacino");
            Title = sender.GetTitle("Kolpacino");
            Genre = sender.GetYear("Kolpacino");
        }
        Random rd = new Random();
        public string Randomizer()
        {
            int Id = 0;
            Id = rd.Next(1145874, 1456975);
            string FullId = "tt" + Id.ToString();
            return FullId;

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
