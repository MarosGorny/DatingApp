using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDto
    {
        private string _username;
        public string Username 
        { 
            get => _username.ToLower();
            set => _username = value.ToLower();
        }

        public string Password { get; set; }
    }
}