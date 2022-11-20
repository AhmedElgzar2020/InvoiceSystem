using System.Data.Entity;

namespace InvoiceSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DbConnection")
        {
        }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<IssueItems> IssueItems { get; set; }

    }
}