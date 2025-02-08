using FabriqPro.Domain.Entities;
using FabriqPro.Service.Configurations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Service.Services.Users;

public interface IUserService
{
    ValueTask<User> CreateAsync(User user);
    ValueTask<User> UpdateAsync(long id,User user);
    ValueTask<User> DeleteAsync(long id);
    ValueTask<User> GetByIdAsync(long id);
    ValueTask<IEnumerable<User>> GetByAllAsync(PaginationParams param,Filter filer,string search = null);
    ValueTask<(User user, string token)> LoginAsync(string phone, string password);
    ValueTask<bool> ResetPasswordAsync(string phone, string password);
    ValueTask<bool> SendCodeAsync(string phone);
    ValueTask<bool> ConfirmCodeAsync(string phone,string code);
    ValueTask<User> ChangePasswordAsync(string phone,string oldPassword,string newPassword);
}
