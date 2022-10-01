using Movieve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Movieve.Services.Serialization
{
    public class MovieSerialization
    {
        public static SendRequest sender = new SendRequest();
        public List<Movie> Movies = new List<Movie>()
        {
            new Movie
            {
                Title= sender.GetTitle("Kurtlar Vadisi"),
                Genre = sender.GetGenre("Kurtlar Vadisi"),
                Year = sender.GetYear("Kurtlar Vadisi"),
                Plot = sender.GetPlot("Kurtlar Vadisi")
            },
             new Movie
            {
                Title= sender.GetTitle("Interstellar"),
                Genre = sender.GetGenre("Interstellar"),
                Year = sender.GetYear("Interstellar"),
                Plot = sender.GetPlot("Interstellar")
            },
                new Movie
            {
                Title= sender.GetTitle("Fast and Furious"),
                Genre = sender.GetGenre("Fast and Furious"),
                Year = sender.GetYear("Fast and Furious"),
                Plot = sender.GetPlot("Fast and Furious")
                },
                    new Movie
            {
                Title= sender.GetTitle ("Leon"),
                Genre = sender.GetGenre("Leon"),
                Year = sender.GetYear  ("Leon"),
                Plot = sender.GetPlot  ("Leon")
                },
                      new Movie
            {
                Title= sender.GetTitle ("Kolpacino"),
                Genre = sender.GetGenre("Kolpacino"),
                Year = sender.GetYear  ("Kolpacino"),
                Plot = sender.GetPlot  ("Kolpacino")
                },
                      new Movie
            {
                Title= sender.GetTitle ("Kolpacino"),
                Genre = sender.GetGenre("Kolpacino"),
                Year = sender.GetYear  ("Kolpacino"),
                Plot = sender.GetPlot  ("Kolpacino")
                },
        };
        Random random = new Random();
        //var list = new List<string> { "one", "two", "three", "four" };
        //int index = random.Next(list.Count);

    }
}
