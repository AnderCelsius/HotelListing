using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Models.DTOs
{
    public class UserDTO : LoginUserDTO
    {
        public string FirstName {  get; set; }
        public string LastName {  get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber {  get; set; }

        public ICollection<string> Roles {  get; set; }
        
    }
}
