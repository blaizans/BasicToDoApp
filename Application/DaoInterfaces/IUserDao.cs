using Domain.DTOs;
using Models;

namespace Application.DaoInterfaces;

public interface IUserDao
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByUsernameAsync(string username);
    Task<User?> GetByIdAsync(int id);
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);


    
}