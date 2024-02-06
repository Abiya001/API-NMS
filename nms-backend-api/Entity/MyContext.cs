using Microsoft.EntityFrameworkCore;
using nms_backend_api.Logics.Concrete;

namespace nms_backend_api.Entity
{
    public class MyContext : DbContext
    {
            public readonly IConfiguration Configuration;
            public MyContext(IConfiguration configuration)
            {
                Configuration = configuration;
            }
            public DbSet<Teacher> teachers { get; set; }
            public DbSet<Student> students { get; set; }
            public DbSet<Examination> examination { get; set; }
            public DbSet<StudentAttendence> StudAttendences { get; set; }
            public DbSet<TeacherAttendence> TeachAttendences { get; set; }
            public DbSet<User> users { get; set; }
        public DbSet<ScheduleClass> Schclass { get; set; }



        public DbSet<Class1> class1 { get; set; }
             protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MyConnection"));
            }
        
    }
}
