using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityTest.Data
{
    [NotMapped]
    public class AppUser : IdentityUser
    {
        
        public List<AppRole> AppRoles { get; set; }
    }
}