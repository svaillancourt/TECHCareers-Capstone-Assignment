using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Booze_pedia.Areas.Identity.Data
{
    // Add profile data for application users by adding additional properties to the Booze_pediaUser class
    public class Booze_pediaUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
    }
}
