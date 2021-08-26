using imecappAPI.Data;
using imecappAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.PostData
{

    public class SqlPostData : IPostData
    {
        private readonly DataContext _dataContext;
        public SqlPostData(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Post> AddPost(Post post)
        {
             await _dataContext.Posts.AddAsync(post);
            await _dataContext.SaveChangesAsync();
            return post;
        }

        public Task DeletePost(Post post)
        {
            throw new NotImplementedException();
        }

      
        public Task<Post> EditPost(Post post)
        {
            throw new NotImplementedException();
        }


        public Task<Post> GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _dataContext.Posts.ToListAsync();
        }
    }
}
