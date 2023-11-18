using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.DBModel
{
    public class AppUser: IdentityUser
    {
        public string? Region { get; set; }
    }
}
