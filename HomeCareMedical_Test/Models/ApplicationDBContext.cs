using System.Data.Entity;

namespace HomeCareMedical_Test.Models
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Personal> Personal { get; set; }

       
    }
}