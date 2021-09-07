using HotelListing.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.DTOs
{
    public class CountryDTO : AddCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels {  get; set; }
    }
}
