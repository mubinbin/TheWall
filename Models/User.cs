using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWall.Models
{ 
    public class User 
    { 
        [Key]
        public int UserId {get; set;}
        [Required(ErrorMessage="This field is required")]
        [StringLength(45, MinimumLength=2, ErrorMessage="{0} must be between {2} and {1}")]
        public string Name {get; set;}
        [Required(ErrorMessage="This field is required")]
        [EmailAddress]
        public string Email {get; set;}
        [Required(ErrorMessage="This field is required")]
        [MinLength(8, ErrorMessage="{0} must be at least {1} characters")]
        [DataType(DataType.Password)]
        public string Password {get; set;}
        [Required(ErrorMessage="This field is required")]
        [NotMapped]
        [Display(Name="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPW {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        // one to many Message
        public List<Message> PostMessages {get; set;}
        public List<Comment> PostComments {get; set;}
    }
}