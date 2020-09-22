using Emamzadeh.Models;
using Microsoft.EntityFrameworkCore;

namespace Emamzadeh
{
    public class EMContext : DbContext
    {
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<File> Files { get; set; }

        public EMContext(DbContextOptions<EMContext> options) : base(options)
        {

        }
    }
}
