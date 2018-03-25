using Microsoft.EntityFrameworkCore;

namespace ApiDatabaseTut.Models
{
    public partial class ToDoContext : DbContext
    {
        public virtual DbSet<TodoItem> TodoItem { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
