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

        public Task DeleteBlogAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Blog>> GetAllBlogAsync()
        {
           var blogs = await db.Blogs.ToListAsync();
            return blogs;           
          
        }

        public Task<InfoMessage> UpdateBlogAsync(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
