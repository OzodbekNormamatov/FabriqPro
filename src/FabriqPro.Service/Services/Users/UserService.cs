using FabriqPro.Domain.Entities;
using FabriqPro.Service.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Service.Services.Users;

public class UserService : IUserService
{
    ValueTask<User> IUserService.ChangePasswordAsync(string phone, string oldPassword, string newPassword)
    {
        throw new NotImplementedException();
    }

    ValueTask<bool> IUserService.ConfirmCodeAsync(string phone, string code)
    {
        throw new NotImplementedException();
    }

    ValueTask<User> IUserService.CreateAsync(User user)
    {
        throw new NotImplementedException();
    }

    ValueTask<User> IUserService.DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    ValueTask<IEnumerable<User>> IUserService.GetByAllAsync(PaginationParams param, Filter filer, string search)
    {
        throw new NotImplementedException();
    }

    ValueTask<User> IUserService.GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    ValueTask<(User user, string token)> IUserService.LoginAsync(string phone, string password)
    {
        throw new NotImplementedException();
    }

    ValueTask<bool> IUserService.ResetPasswordAsync(string phone, string password)
    {
        throw new NotImplementedException();
    }

    ValueTask<bool> IUserService.SendCodeAsync(string phone)
    {
        throw new NotImplementedException();
    }

    ValueTask<User> IUserService.UpdateAsync(long id, User user)
    {
        throw new NotImplementedException();
    }
}
