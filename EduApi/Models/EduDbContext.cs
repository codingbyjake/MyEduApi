using Microsoft.EntityFrameworkCore;

namespace EduApi.Models {
    public class EduDbContext : DbContext {

        public DbSet<Major> Majors { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        public EduDbContext(DbContextOptions<EduDbContext> options) : base(options) { }

    }
}
