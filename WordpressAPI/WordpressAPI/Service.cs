using JoeBlogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAPI
{
    public class Service
    {
        public static void Post(BlogPost blogPost)
        {
            string link = "https://qaprojblog.wordpress.com/";
            string username = "ziaprog@gmail.com";
            string password = "Zia#1234$";

            var wp = new WordPressWrapper(link + "/xmlrpc.php", username, password);
            var post = new Post();

            post.DateCreated = DateTime.Today.AddHours(0);
            post.Title = blogPost.Title;
            post.Body = blogPost.Body;
            post.Tags = blogPost.Tags.Split(','); // string tags = "tags1,tag2";

            wp.NewPost(post, true);
        }
    }
}
