using DELEGATE._2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace DELEGATE._2.Models
{
    internal class User:IEntity
    {
        private static int _id;
        public int Id { get; }
        public Role Role { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
       
        public User(string username, string email,Role role)
        {
            _id++;
            Id = _id;
            UserName = username;
            Email = email;
            Role = role;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} -UserName:{UserName} - Email:{Email} - Role:{Role}");
        }
      
    }
}
