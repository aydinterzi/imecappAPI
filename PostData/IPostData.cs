using imecappAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.PostData
{
    public interface IPostData
    {
        Task<List<Post>> GetEmployees();
        Task<Post> GetEmployee(int id);
        Task<Post> AddEmployee(Post employee);
        Task DeleteEmployee(Post employee);
        Task<Post> EditEmployee(Post employee);
    }
}
