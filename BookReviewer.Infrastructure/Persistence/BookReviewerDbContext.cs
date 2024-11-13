using BookReviewer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BookReviewer.Infrastructure.Persistence
{
    public class BookReviewerDbContext : DbContext
    {
        public BookReviewerDbContext(DbContextOptions<BookReviewerDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(e =>
            {
                e.HasKey(b => b.Id);

                e.HasMany(b => b.Reviews)
                    .WithOne(r => r.Book)
                    .HasForeignKey(r => r.IdBook)
                    .OnDelete(DeleteBehavior.Restrict);

                //Não pode ter mapeamento dentro do Reviewr do book pq a classe dominanete é o Book
                //Sem book não tem review, logo mapeia apenas aqui para n ter duplicidade
            });

            builder.Entity<Review>(e =>
            {
                e.HasKey(b => b.Id);

                e.
            });
            
            base.OnModelCreating(builder);
        }

    }
}
