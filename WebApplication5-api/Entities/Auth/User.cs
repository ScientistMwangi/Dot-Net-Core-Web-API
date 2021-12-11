﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5_api.Entities.Auth
{
    public class User : IdentityUser<Guid>
    {
        public string City { get; set; }
    }
}
