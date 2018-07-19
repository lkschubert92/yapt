using System;
using Microsoft.AspNetCore.Identity;

namespace yapt.Db
{
    public class ApplicationUser : IdentityUser<Guid>
    {

    }

    public class ApplicationRole : IdentityRole<Guid>
    {

    }

}