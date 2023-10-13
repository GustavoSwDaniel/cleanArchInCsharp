using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces.Repositories;

namespace CleanArch.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(User entity) { 
            _context.User.Add(entity);
            Console.WriteLine(entity);
            Console.WriteLine("UserRepository.Add");
            _context.SaveChanges();
        }

    }
}