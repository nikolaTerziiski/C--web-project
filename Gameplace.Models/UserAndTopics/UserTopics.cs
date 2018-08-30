using System;
using System.Collections.Generic;
using System.Text;

namespace CarParadise.Models.UserAndTopics
{
    public class UserTopics
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public int TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
