using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MvcMovie.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string? Genre { get; set; }

        [Required]
        public int Price { get; set; }

        
        public string? Rating { get; set; } = "A";
    }
}
