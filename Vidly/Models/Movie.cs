using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Movie
    {
        
        public int Id { get; set; }

 
        [Required(ErrorMessage = "Please enter movie name.")]
        public string Name { get; set; }

        
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

         
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }

    //movies/random  -- 

}