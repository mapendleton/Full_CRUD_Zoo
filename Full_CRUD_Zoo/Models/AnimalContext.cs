using Microsoft.EntityFrameworkCore;

namespace Full_Crud_Zoo.Models;

public class AnimalContext : DbContext
{
    public AnimalContext(DbContextOptions<AnimalContext> options)
        : base(options)
    {
        
    }

    public DbSet<Animal> Animals {get;set;} = null!;
}