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
        [StringLength(255)]
        public string Name { get; set; }

        
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Genre  is  a required field")]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "Please enter the release date.")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

         
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required(ErrorMessage = "The Number in Stock must between 1 and 20.")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }

    //movies/random  -- 

}