using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorld.MVVM.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string ReleaseYear { get; set; }
        public string ParentalGuide { get; set; }
        public int Runtime { get; set; }
        public string Genre { get; set; }
        public Image Poster { get; set; }
    }
}
