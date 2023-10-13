using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces.Repositories;

namespace CleanArch.Application.UseCase
{
    public class CreateUser : IUseCase
    {
        private readonly IUserRepository  _userRepository;

        public CreateUser(IUserRepository userRepository){
            _userRepository = userRepository;
        }
        public User BuildUser(UserDTO user){
            return new User(user.Username, user.Email);
        }

        public void RegisterUser(UserDTO userData){
            User user = BuildUser(userData);

            _userRepository.Add(user);
        }
        public void Execute(UserDTO userData)
        {
            RegisterUser(userData);
        }
    }

}
