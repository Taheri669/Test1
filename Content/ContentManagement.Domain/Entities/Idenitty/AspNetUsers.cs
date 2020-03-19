using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentManagement.Domain.Entities.Idenitty
{
    public class AspNetUsers : IdentityUser
    {
        public string Site { get; set; }
        public decimal Credit { get; set; }
    }
}
