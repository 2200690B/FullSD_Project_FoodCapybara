﻿using Microsoft.AspNetCore.Identity;

namespace FullSD_Project_FoodCapybara.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
