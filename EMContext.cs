using Emamzadeh.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emamzadeh
{
    public class EMContext : DbContext
    {
        public DbSet<Professor> Professors { get; private set; }
        public DbSet<Course> Courses { get; private set; }
        public DbSet<Resume> Resumes { get; private set; }
        public DbSet<Testimonial> Testimonials { get; private set; }
        public DbSet<Message> Messages { get; private set; }
        public DbSet<File> Files { get; private set; }
        public DbSet<FileType> FileTypes { get; private set; }

        public EMContext(DbContextOptions<EMContext> options) : base(options)
        {

        }
    }
}
