using EFGetStarted.Database;
using EFGetStarted.Models;
using EFGetStarted.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFGetStarted.Actions
{
    public class BlogActions
    {
        ApplicationDbContext db = new ApplicationDbContext();
        BlogServices services = new BlogServices();

        public void addBlog()
        {
            
            Console.WriteLine("Enter a new Blog.");
            string name = Console.ReadLine();
            //db.Add(new Blog { BlogName = "http://blogs.msdn.com/adonet" });
            db.Add(new Blog { BlogName = name});
            db.SaveChanges();
            Console.WriteLine("added successfully");
        }
        public void getBlogs()
        {
            var blogs = db.Blogs.ToList();
            foreach(var blog in blogs)
            {
                Console.WriteLine($"BlogId:{blog.BlogId}\t BlogName:{blog.BlogName}");
            }
        }
        public async void updateBlog()
        {
            Console.WriteLine("Enter Id of the blog to delete");
            int Id = Convert.ToInt32(Console.ReadLine());
            await Console.Out.WriteLineAsync("Blog name:");
            var name = Console.ReadLine();
            
            await services.UpdateBlogAsync(name, Id);
        }
    }
}
