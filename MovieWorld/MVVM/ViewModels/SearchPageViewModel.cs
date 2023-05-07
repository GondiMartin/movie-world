using MovieWorld.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorld.MVVM.ViewModels
{
    public class SearchPageViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
        private Image initPoster = new Image
        {
            Source = ImageSource.FromFile("cinema.png"),
        };

        public SearchPageViewModel() { 
            InitTestData();
        }

        private void InitTestData()
        {
            Movie movie1 = new Movie
            {
                Id = 1,
                Title = "First",
                Director = "Roberto",
                Writer = "Angelica",
                ReleaseYear = "2001",
                ParentalGuide = "16",
                Runtime = 90,
                Genre = "Comedy",
                Poster = initPoster,
            };
            Movie movie2 = new Movie
            {
                Id = 2,
                Title = "Second",
                Director = "Roberto",
                Writer = "Angelica",
                ReleaseYear = "2001",
                ParentalGuide = "16",
                Runtime = 90,
                Genre = "Comedy",
                Poster = initPoster,
            };
            Movie movie3 = new Movie
            {
                Id = 3,
                Title = "Third",
                Director = "Roberto",
                Writer = "Angelica",
                ReleaseYear = "2001",
                ParentalGuide = "16",
                Runtime = 90,
                Genre = "Comedy",
                Poster = initPoster,
            };

            Movies.Add(movie1);
            Movies.Add(movie2);
            Movies.Add(movie3);
        }
    }
}
