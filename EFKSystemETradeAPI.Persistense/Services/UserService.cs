using EFKSystemETradeAPI.Application.Abstraction.Services;
using EFKSystemETradeAPI.Application.DTOs.User;
using EFKSystemETradeAPI.Domain.Entities.Identity;
using EFKSystemETradeAPI.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser model)
        {
            IdentityResult identityResult = await _userManager.CreateAsync(new()
            {
                UserName = model.Email,
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                PhoneNumber = model.Phone
            }, model.Password);

            CreateUserResponse response = new() { Succeeded = identityResult.Succeeded };
            if (identityResult.Succeeded)
            {
                response.Message = "Kayıt başarıyla oluşturuldu.";
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description}\n";
                }
            }
            return response;
        }
    }
}
