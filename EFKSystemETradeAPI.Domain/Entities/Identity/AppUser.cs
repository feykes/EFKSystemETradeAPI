﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
