using Microsoft.EntityFrameworkCore;

namespace LabtestApi.Data
{
    public class LabtestDbcontext : DbContext
    {
        public LabtestDbcontext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
