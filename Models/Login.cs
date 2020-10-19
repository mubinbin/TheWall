using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TheWall.Models;

namespace TheWall.Models
{
    public class Login
    {
        [Required(ErrorMessage="This field is required")]
        [EmailAddress]
        [Display(Name="Email")]
        public string LEmail {get; set;}
        [Required(ErrorMessage="This field is required")]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        public string LPassword {get; set;}
    }
}