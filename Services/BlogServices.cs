using EFGetStarted.Database;
using EFGetStarted.Models;
using EFGetStarted.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.Services
{
    public class BlogServices : IBlogInterface
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public async Task<InfoMessage> CreateBlogAsync(Blog blog)
        {
            try
            {
                db.Blogs.AddAsync(blog);
                await db.SaveChangesAsync();
                return new InfoMessage { Message = "Blog added successfully" };
            }catch(Exception ex)
            {
              return new InfoMessage { Message=ex.Message};
            }


           
        }

        public async Task DeleteBlogAsync(int id)
        {
            var BlogToDelete = await db.Blogs.FindAsync(id);
            if (BlogToDelete != null)
            {
                 db.Blogs.Remove(BlogToDelete);
                await db.SaveChangesAsync();
            }
           
        }

        public async Task<List<Blog>> GetAllBlogAsync()
        {
           var blogs = await db.Blogs.ToListAsync();
            return blogs;           
          
        }

        public async Task<InfoMessage> UpdateBlogAsync(string name, int id)
        {
            var BlogToUpdate = await db.Blogs.FindAsync(id);
            if (BlogToUpdate != null)
            {
                BlogToUpdate.BlogName = name;

                await db.SaveChangesAsync();
                return new InfoMessage { Message = "Updated successfully" };
            }
            throw new Exception("Could not Update");
           
        }
    }
}
