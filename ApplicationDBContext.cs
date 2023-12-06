using Microsoft.EntityFrameworkCore;

namespace pdf
    {
        public class ApplicatinDbContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer(@"Data Source=MarizeAdel;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Initial Catalog=Pdf;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
            public DbSet<Group> groups { get; set; }
            public DbSet<Person> people { get; set; }
            public DbSet<Admin> admin { get; set; }



        }
}


