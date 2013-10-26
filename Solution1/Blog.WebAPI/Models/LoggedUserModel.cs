using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Blog.WebAPI.Models
{
    [DataContract]
    public class LoggedUserModel
    {
        public string SessionKey { get; set; }

        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }
    }
}