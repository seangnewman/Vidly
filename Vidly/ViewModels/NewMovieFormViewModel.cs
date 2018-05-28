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

         
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required]
        public int NumberInStock { get; set; }


        public Movie Movie { get; set; }
        //Toggle the title between New and Save
        public string Title
        {
            get
            {
                return (Movie != null && Movie.Id != 0) ? "Edit Movie" : "New Movie";
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