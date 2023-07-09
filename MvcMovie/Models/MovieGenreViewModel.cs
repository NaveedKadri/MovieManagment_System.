using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {

        public List<MovieModel>? Movies { get; set; }

        public SelectList? Genres {get; set;}

        public string? MovieGenres { get; set;}

        public string? searchStrings { get; set; }

    }
}
