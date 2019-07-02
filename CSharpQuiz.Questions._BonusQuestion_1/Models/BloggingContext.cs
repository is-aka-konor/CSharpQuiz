using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSharpQuiz.Questions._BonusQuestion_1.Models
{
    public partial class BloggingContext : DbContext
    {
        public BloggingContext()
        {
        }

        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<SearchCriteria> SearchCriteria { get; set; }

        // Unable to generate entity type for table 'dbo.search_results'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.search_criteria_archive'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=TMDEVVM\\ALPHA;database=Blogging;uid=sa;pwd=d8;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.Url).IsRequired();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.BlogId);
            });

            modelBuilder.Entity<SearchCriteria>(entity =>
            {
                entity.HasKey(e => e.CriteriaId)
                    .HasName("PK__search_criteria__09DE7BCC");

                entity.ToTable("search_criteria");

                entity.HasIndex(e => new { e.Datestamp, e.Criteria })
                    .HasName("ix_search_criteria")
                    .IsUnique();

                entity.Property(e => e.CriteriaId).HasColumnName("criteria_id");

                entity.Property(e => e.Criteria)
                    .IsRequired()
                    .HasColumnName("criteria")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Datestamp)
                    .HasColumnName("datestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResultCount).HasColumnName("result_count");

                entity.Property(e => e.SearchCount).HasColumnName("search_count");
            });
        }
    }
}
