using Microsoft.EntityFrameworkCore;
using RPG.Models;

namespace RPG.Data;

public class DataContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
}