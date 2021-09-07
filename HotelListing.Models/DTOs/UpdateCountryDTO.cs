using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Models.DTOs
{
    public class UpdateCountryDTO : AddCountryDTO
    {
        public IList<AddHotelDTO> Hotels {  get; set; }
    }
}
