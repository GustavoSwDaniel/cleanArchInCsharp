using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable

namespace CleanArch.Domain.Entities
{
   public class User
    {
        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }

        public int Id {get; set;}
        public string Username {get; set;}
        public string Email {get; set;}
    }
}