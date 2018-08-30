
namespace CarParadise.Models.UserAndTopics
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        public User()
        {
            this.WrittenTopics = new List<UserTopics>();
        }

        [Required]
        [MinLength(5)]
        public string FullName { get; set; }
        
        public ICollection<UserTopics> WrittenTopics { get; set; }
    }
}
