using System;
using System.Collections.Generic;
using EntityFrameworkL5.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkL5;

public partial class EfLesson3Context : DbContext
{
    public EfLesson3Context()
    {
    }

    public EfLesson3Context(DbContextOptions<EfLesson3Context> options)
        : base(options)
    {
    }

    public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : BaseEntity
    {
        return Set<TEntity>();
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<KeyLink> KeyLinks { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EfLesson3;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");
        });

        modelBuilder.Entity<KeyLink>(entity =>
        {
            entity.ToTable("KeyLink");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.ToTable("Cart");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");
        });



        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    
}
