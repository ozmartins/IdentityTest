using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityTest.Data
{
    public class IdentityTestDbContext: IdentityDbContext
    {
        public IdentityTestDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
