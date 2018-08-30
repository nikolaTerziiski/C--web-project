using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarParadise.Models.UserAndTopics
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }

        [Required]
        [MinLength(30)]
        public string Content { get; set; }

        [Required]
        public DateTime PostedTime { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public UserTopics Author { get; set; }
    }
}