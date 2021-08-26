using imecappAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.PostData
{
    public interface IPostData
    {
        Task<List<Post>> GetPosts();
        Task<Post> GetPost(int id);
        Task<Post> AddPost(Post post);
        Task DeletePost(Post post);
        Task<Post> EditPost(Post post);
    }
}
