using HotelListing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Models.DTOs
{
    public class AddHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage ="Address Name Is Too Long")]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

       // [Required]
        public int CountryId { get; set; }
    }
}
