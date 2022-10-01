using Movieve.Command;
using Movieve.Services;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Movieve.Views.UserControls
{
    public class SearchPanelUCViewModel:INotifyPropertyChanged
    {

        private string _searchedMovie;
        public string SearchedMovie
        {
            get { return this._searchedMovie; }
            set
            {
                if (!string.Equals(this._searchedMovie, value))
                {
                    this._searchedMovie = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private string _poster;
        private string _genre;
        private string _title;
        private string _year;
        private string _plot;
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
        public string Year
        {
            get { return this._year; }
            set
            {
                if (!string.Equals(this._year, value))
                {
                    this._year = value;
                    this.OnPropertyChanged();
                }
            }
        }
        public string Plot
        {
            get { return this._plot; }
            set
            {
                if (!string.Equals(this._plot, value))
                {
                    this._plot = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public RelayCommand SearchCommand { get; set; }
        public SearchPanelUCViewModel()
        {
            this.SearchCommand = new RelayCommand((c) =>
            {
                if (SearchedMovie.Length > 1)
                {
                    SendRequest sender = new SendRequest();
                    Poster = sender.GetPoster(SearchedMovie);
                    Title = sender.GetTitle(SearchedMovie);
                    Genre = sender.GetGenre(SearchedMovie);
                    Year = sender.GetYear(SearchedMovie);
                    Plot = sender.GetPlot(SearchedMovie);
                }
            });
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