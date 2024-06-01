using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLTV.Data.Model
{
    public partial class manage_libraryContext : DbContext
    {
        public manage_libraryContext()
        {
        }

        public manage_libraryContext(DbContextOptions<manage_libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<BorrowRequest> BorrowRequests { get; set; } = null!;
        public virtual DbSet<BorrowTracking> BorrowTrackings { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Reader> Readers { get; set; } = null!;
        public virtual DbSet<RoleReader> RoleReaders { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=manage_library;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_100_CS_AS_WS_SC_UTF8");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreateDay)
                    .HasPrecision(0)
                    .HasColumnName("create_day")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOffPages).HasColumnName("number_off_pages");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("price");

                entity.Property(e => e.PublicationYear)
                    .HasPrecision(0)
                    .HasColumnName("publication_year")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PublisherId).HasColumnName("publisher_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_book_author1");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_book_category1");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_book_publisher1");
            });

            modelBuilder.Entity<BorrowRequest>(entity =>
            {
                entity.ToTable("borrow_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DueDate)
                    .HasPrecision(0)
                    .HasColumnName("due_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReaderId).HasColumnName("reader_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasPrecision(0)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BorrowRequests)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_borrow_request_book");

                entity.HasOne(d => d.Reader)
                    .WithMany(p => p.BorrowRequests)
                    .HasForeignKey(d => d.ReaderId)
                    .HasConstraintName("FK_borrow_request_reader1");
            });

            modelBuilder.Entity<BorrowTracking>(entity =>
            {
                entity.ToTable("borrow_tracking");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FineAmound)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("fine_amound");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.ReturnDate)
                    .HasPrecision(0)
                    .HasColumnName("return_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnStatus).HasColumnName("return_status");

                entity.Property(e => e.UpdatedAt)
                    .HasPrecision(0)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.BorrowTrackings)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_borrow_tracking_borrow_request");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("publisher");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.ToTable("reader");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BooksBorrowed).HasColumnName("books_borrowed");

                entity.Property(e => e.BorrowedTime).HasColumnName("borrowed_time");

                entity.Property(e => e.DateOfBirth)
                    .HasPrecision(0)
                    .HasColumnName("date_of_birth")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("deposit");

                entity.Property(e => e.EndDay)
                    .HasPrecision(0)
                    .HasColumnName("end_day");

                entity.Property(e => e.IdentityCard)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("identity_card");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ReaderAddress)
                    .IsUnicode(false)
                    .HasColumnName("reader_address");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.StartDay)
                    .HasPrecision(0)
                    .HasColumnName("start_day")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_reader_role_reader");
            });

            modelBuilder.Entity<RoleReader>(entity =>
            {
                entity.ToTable("role_reader");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
