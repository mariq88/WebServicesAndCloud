using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Blog.WebAPI.Models
{
    [DataContract]
    public class PostModel
    {
        public int Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        [DataMember(Name = "text")]
        public string Content { get; set; }

        public string CreatedBy { get; set; }

        public IEnumerable<PostModel> Posts { get; set; }

         [DataMember(Name = "tag")]
        public IEnumerable<string> Categories { get; set; }
    }
}