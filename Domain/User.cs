﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public  string LoginName { get; set; }
        public  string Password { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  int Position { get; set; }
        public string Email { get; set; }
        public  string Rool { get; set; }
    }
}
