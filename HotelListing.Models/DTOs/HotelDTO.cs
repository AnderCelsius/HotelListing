﻿using HotelListing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Models.DTOs
{
    public class HotelDTO : AddHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country {  get; set; }
       
    }
}
