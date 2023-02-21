using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Student_council_kit
{
    public partial class student_councilContext : DbContext
    {
        private static student_councilContext _context = new student_councilContext();
        public student_councilContext()
        {
        }

        public static student_councilContext GetContext()
        {
            if (_context == null)
                _context = new student_councilContext();

            return _context;
        }
        public student_councilContext(DbContextOptions<student_councilContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventsParticipant> EventsParticipants { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<StudentCouncil> StudentCouncils { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\Program Files\\SQLiteStudio\\student_council");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direction>(entity =>
            {
                entity.HasKey(e => e.IdDirection);

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("VARCHAR (2000)")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR (200)")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.IdEvent);

                entity.Property(e => e.IdEvent).HasColumnName("id_event");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnType("DATE")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("VARCHAR (2000)")
                    .HasColumnName("description");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR (200)")
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("VARCHAR (100)")
                    .HasColumnName("status");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdDirection);
            });

            modelBuilder.Entity<EventsParticipant>(entity =>
            {
                entity.ToTable("Events_participant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEvent).HasColumnName("id_event");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.EventsParticipants)
                    .HasForeignKey(d => d.IdEvent);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.EventsParticipants)
                    .HasForeignKey(d => d.IdUser);
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.IdFaculty);

                entity.Property(e => e.IdFaculty).HasColumnName("id_faculty");

                entity.Property(e => e.NameFaculty)
                    .IsRequired()
                    .HasColumnType("VARCHAR (50)")
                    .HasColumnName("name_faculty");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.IdPost);

                entity.Property(e => e.IdPost).HasColumnName("id_post");

                entity.Property(e => e.NamePost)
                    .IsRequired()
                    .HasColumnType("VARCHAR (200)")
                    .HasColumnName("name_post");
            });

            modelBuilder.Entity<StudentCouncil>(entity =>
            {
                entity.ToTable("Student_council");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPost).HasColumnName("id_post");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.StudentCouncils)
                    .HasForeignKey(d => d.IdPost)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StudentCouncils)
                    .HasForeignKey(d => d.IdUser);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("VARCHAR (255)")
                    .HasColumnName("email");

                entity.Property(e => e.IdFaculty).HasColumnName("id_faculty");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("VARCHAR (200)")
                    .HasColumnName("login");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("VARCHAR (100)")
                    .HasColumnName("name");

                entity.Property(e => e.NumGroup).HasColumnName("num_group");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("VARCHAR (200)")
                    .HasColumnName("password");

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasColumnType("VARCHAR (100)")
                    .HasColumnName("patronymic");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnType("VARCHAR (200)")
                    .HasColumnName("role");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnType("VARCHAR (100)")
                    .HasColumnName("surname");

                entity.HasOne(d => d.IdFacultyNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdFaculty);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
