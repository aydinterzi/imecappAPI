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
        public Task<Post> AddEmployee(Post employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(Post employee)
        {
            throw new NotImplementedException();
        }

        public Task<Post> EditEmployee(Post employee)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetEmployees()
        {
            return await _dataContext.Posts.ToListAsync();
        }
    }
}
