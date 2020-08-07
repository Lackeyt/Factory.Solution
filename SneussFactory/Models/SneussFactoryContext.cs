using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SneussFactory.Models
{
  public class SneussFactoryContext : DbContext
  {
    public DbSet<Machine> Machines {get;set;}
    public DbSet<Engineer> Engineers {get;set;}
    public DbSet<EngineerMachine> EngineerMachine {get;set;}
    public SneussFactoryContext(DbContextOptions options) : base(options) {}
  }
}