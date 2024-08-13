using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context.cs
{
    public class ContextApp: DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> options) : base(options) 
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
