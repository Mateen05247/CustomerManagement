using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Model
{
    public class EFDBContext:DbContext
    {
        public string conn = "Server=DESKTOP-BT48UI1;Database=CustomersDB;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }
        public DbSet<Customers> customers { get; set; }
    }
}
