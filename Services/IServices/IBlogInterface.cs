using EFGetStarted.Models;

namespace EFGetStarted.Services.IServices
{
    public interface IBlogInterface
    {
        //Create a new blog

        Task<InfoMessage> CreateBlogAsync(Blog blog);

        //Update a blog
        Task<InfoMessage> UpdateBlogAsync(string name, int id);
        //delete a blog
        Task DeleteBlogAsync(int id);
        //get all blogs
        Task<List<Blog>> GetAllBlogAsync();

    }
}
