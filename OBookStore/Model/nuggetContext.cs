using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OBookStore.Model
{
    public partial class nuggetContext : DbContext
    {
        public nuggetContext()
        {
        }

        public nuggetContext(DbContextOptions<nuggetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookPages> BookPages { get; set; }
        public virtual DbSet<Learning> Learning { get; set; }
        public virtual DbSet<Video> Video { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=nugget;Trusted_Connection=False;User Id=SA;password=Subway@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("('NULL')");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnName("CAPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.Categories)
                    .IsRequired()
                    .HasColumnName("CATEGORIES")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationSource)
                    .IsRequired()
                    .HasColumnName("CREATION_SOURCE")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Object).HasColumnName("OBJECT");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("PATH")
                    .HasMaxLength(50);

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnName("TAGS")
                    .HasMaxLength(50);

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnName("THUMBNAIL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BookPages>(entity =>
            {
                entity.ToTable("Book_Pages");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("('NULL')");

                entity.Property(e => e.ContentPath)
                    .IsRequired()
                    .HasColumnName("CONTENT_PATH")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationSource)
                    .IsRequired()
                    .HasColumnName("CREATION_SOURCE")
                    .HasMaxLength(50);

                entity.Property(e => e.LearningType).HasColumnName("LEARNING_TYPE");

                entity.Property(e => e.PageTags)
                    .IsRequired()
                    .HasColumnName("PAGE_TAGS")
                    .HasMaxLength(50);

                entity.Property(e => e.RefId).HasColumnName("REF_ID");
            });

            modelBuilder.Entity<Learning>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("('NULL')");

                entity.Property(e => e.LearningType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("('NULL')");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnName("CAPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.Categories)
                    .IsRequired()
                    .HasColumnName("CATEGORIES")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationSource)
                    .IsRequired()
                    .HasColumnName("CREATION_SOURCE")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Object).HasColumnName("OBJECT");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("PATH")
                    .HasMaxLength(50);

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnName("TAGS")
                    .HasMaxLength(50);

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnName("THUMBNAIL")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
