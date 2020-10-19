using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Models
{ 
    public class Comment 
    {
        [Key]
        public int CommentId {get; set;}
        public int UserId {get; set;}
        public User Creator {get; set;}

        public int MessageId {get; set;}
        public Message OfMessage {get; set;}


        [Required(ErrorMessage="This field is required")]
        [MinLength(5, ErrorMessage="{0} must be at least {1} characters")]
        public string CommentContent {get; set;}
        
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy)")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy)")]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}
