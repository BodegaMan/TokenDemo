﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TokenDemo.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage="UserName is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}
