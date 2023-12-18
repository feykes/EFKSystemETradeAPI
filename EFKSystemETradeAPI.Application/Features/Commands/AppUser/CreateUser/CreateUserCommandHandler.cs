using EFKSystemETradeAPI.Application.Abstraction.Services;
using EFKSystemETradeAPI.Application.DTOs.User;
using EFKSystemETradeAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;
        readonly ICustomerWriteRepository _customerWriteRepository;

        public CreateUserCommandHandler(IUserService userService, ICustomerWriteRepository customerWriteRepository)
        {
            _userService = userService;
            _customerWriteRepository = customerWriteRepository;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateAsync(new()
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                Password = request.Password,
                Phone = request.Phone
            });

            await _customerWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                Phone = request.Phone,
                Password = request.Password
            });

            await _customerWriteRepository.SaveAsync();
            return new()
            {
                Message = response.Message,
                Succeeded = response.Succeeded
            };
        }
    }
}
