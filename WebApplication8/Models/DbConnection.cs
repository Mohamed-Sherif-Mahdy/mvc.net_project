using Microsoft.EntityFrameworkCore;

namespace WebApplication8.Models
{
  public class DbConnection:DbContext
  {
   
    public DbSet<Contact> Contacts { get; set; }
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("" +
        "Data Source=DESKTOP-S9OMEN7\\SQLEXPRESS;" +
        "Initial Catalog=Contact;" +
        "Integrated Security=True;" +
        "TrustServerCertificate=True");
    }

  }
}
