﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { set; }
        int Balance { get; set; }
        string Role { get; set; }
    }
}
