

namespace juan.Models
{
    using System;
using System.ComponentModel.DataAnnotations;
    public enum Tricks
    {   jungla,
        nido,
        avion,
     
     }
    public class Clown
    {
        [key]
        public int ClownID { get; set; }
        [Requiered]
        [StringLength(24, MinimumLength = 2, ErrorMessage = "field must be atleast 2 characters")]
        public string NickName { get; set; }
        [Requiered]
        public Tricks Trick { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime Birthdate { get; set; }
    }
}