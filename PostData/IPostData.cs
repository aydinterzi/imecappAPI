using imecappAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.PostData
{
    public interface IPostData
    {
        Task<User> GetUser(int id);
        Task<IEnumerable<Post>> GetPosts(PostQueryParams postParams);
        Task<Post> GetPost(int id);
        Task<Post> AddPost(Post post);
        Task DeletePost(Post post);
        Task<Post> EditPost(Post post);
        Task<Messages> AddMessage(Messages message);
    }
}
