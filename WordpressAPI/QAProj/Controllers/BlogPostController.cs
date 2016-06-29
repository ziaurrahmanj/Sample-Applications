using JoeBlogs;
using QAProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAProj.Controllers
{
    public class BlogPostController : Controller
    {
        public string tags;

        // GET: BlogPost
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogPost/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPost/Create
        [HttpPost]
        public ActionResult Create(BlogPost blogPost)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    string link = "https://qaprojblog.wordpress.com/";
                    string username = "ziaprog@gmail.com";
                    string password = "Zia#1234$";

                    var wp = new WordPressWrapper(link + "/xmlrpc.php", username, password);
                    var post = new Post();

                    post.DateCreated = blogPost.PostDate;
                    post.Title = blogPost.Title;
                    post.Body = blogPost.Body;
                    post.Tags = blogPost.Tags.Split(','); // string tags = "tags1,tag2";

                    wp.NewPost(post, true);
                   
                }
                return RedirectToAction("Create");

            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPost/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPost/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPost/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPost/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
