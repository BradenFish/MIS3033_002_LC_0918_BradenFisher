using Microsoft.EntityFrameworkCore;

namespace a
{
    public class StudentGradeDB:DbContext
    {
        public DbSet<StudentGrade> StuGradeTable { get; set; }// this is a table

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data source = stugrades.db");
        }
    }
}
