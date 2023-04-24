﻿using Microsoft.AspNetCore.Identity;

namespace teknofest.Identity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int OdaNumarasi { get; set; }
    }
}
