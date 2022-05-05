using Microsoft.EntityFrameworkCore;
using SubjectBook.Models;

namespace SubjectBook.data{
    public class ApplicationDbContext:DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){

        }

        public DbSet<Subject> Subject {get;set;}
    }
}


