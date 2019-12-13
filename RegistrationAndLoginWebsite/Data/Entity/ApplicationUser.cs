using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RegistrationAndLoginWebsite.Data.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int IsDeleted { get; set; }

        public int IsBlocked { get; set; }

        public string City { get; set; }
    }
}
