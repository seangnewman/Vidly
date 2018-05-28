using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;


namespace Vidly.ViewModels
{
    public class NewMovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

         
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

 
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }


        [Required(ErrorMessage = "The Number in Stock must between 1 and 20.")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        
        //Toggle the title between New and Save
        public string Title
        {
            get
            {
                return (Id != 0) ? "Edit Movie" : "New Movie";
            }
        }

        public NewMovieFormViewModel()
        {
            Id = 0;
        }
         

        public NewMovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }



    }
}