using adonet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet.Interface.Repositories;

public interface IUserRepository
{
    public Task<IEnumerable<User>> GetAllAsync(int skip, int take);
    public Task<User?> GetAsync(long id);
    public Task<int> CreateAsync(User user);
    public Task<int> UpdateAsync(long id, User user);
    public Task<int> DeleteAsync(long id);
    public Task<User?> FindEmailAsync(string email);
}
