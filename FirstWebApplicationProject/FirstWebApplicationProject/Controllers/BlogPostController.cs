using FirstWebApplicationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebApplicationProject.Controllers
{
    public class BlogPostController : ApiController
    {
        private static readonly IList<BlogPost> data = GetAll();

        private static IList<BlogPost> GetAll() 
        {
            var data = new List<BlogPost>();
            data.Add(new BlogPost()
                {
                    Title = "Post 1",
                    Content = "Post1 content"
                });
                data.Add(new BlogPost()
                {
                    Title = "Post 1",
                    Content = "Post1 content"

                });
                data.Add(new BlogPost()
                {
                    Title = "Post 1",
                    Content = "Post1 content"
                });
            return data;
        }

        // GET api/blogpost
        public IEnumerable<BlogPost> Get()
        {
            return data;
        }

        // GET api/blogpost/5
        public BlogPost Get(int id)
        {
            return data[id];
        }

        // POST api/blogpost
        public void Post([FromBody]BlogPost value)
        {
            data.Add(value);
        }

        // PUT api/blogpost/5
        public void Put(int id, [FromBody]BlogPost value)
        {
            data[id] = value;
        }

        // DELETE api/blogpost/5
        public void Delete(int id)
        {
            data.RemoveAt(id);
        }
    }
}
