using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.DTOs;

namespace CleanArch.Application.Interfaces
{
    public interface IUseCase
    {
        void Execute(UserDTO userData);
    }
}