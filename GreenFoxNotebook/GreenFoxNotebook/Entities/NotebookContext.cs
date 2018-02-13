using GreenFoxNotebook.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenFoxNotebook.Entities
{
    public class NotebookContext : DbContext
    {
        public NotebookContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
