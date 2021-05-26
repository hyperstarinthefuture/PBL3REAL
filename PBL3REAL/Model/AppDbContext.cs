using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PBL3REAL.Model
{
    public partial class AppDbContext : DbContext
    {
        public static AppDbContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AppDbContext();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static AppDbContext _Instance;
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ImgStorage> ImgStorages { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
   
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<StatusTime> StatusTimes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost ;Initial Catalog =HotelManagementREAL;Integrated Security=true");
            }
        }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("Pk_Tbl_id_user");

                entity.Property(e => e.UserCode)
                    .IsUnicode(false);

                entity.Property(e => e.UserGmail).IsUnicode(false);

                entity.Property(e => e.UserPassword).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.UserPhone).IsUnicode(false);
            });


            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.IdBook)
                    .HasName("Pk_appointment_id_appoint");

                entity.Property(e => e.BookBookdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BookCode).IsUnicode(false);

                entity.Property(e => e.BookNote).IsUnicode(false);

                entity.Property(e => e.BookStatus).IsUnicode(false);

                entity.HasOne(d => d.BookIdclientNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.BookIdclient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_booking_client");

                entity.HasOne(d => d.BookIduserNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.BookIduser)
                    .HasConstraintName("Fk_booking_user");
            });

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.Property(e => e.BooDetNote).IsUnicode(false);
                entity.HasKey(e => e.IdBoodet)
                    .HasName("Pk_appointment_detail_id_appdet");

                entity.HasOne(d => d.BoodetIdbookNavigation)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BoodetIdbook)
                    .HasConstraintName("Fk_booking_detail_booking");

                entity.HasOne(d => d.BoodetIdroomNavigation)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BoodetIdroom)
                    .HasConstraintName("Fk_booking_detail_room");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("Pk_client");

               *//* entity.Property(e => e.IdClient).ValueGeneratedNever();*//*

                entity.Property(e => e.CliGmail).IsUnicode(false);

                entity.Property(e => e.CliName).IsUnicode(false);

                entity.Property(e => e.CliPhone).IsUnicode(false);

                entity.Property(e => e.CliCode).IsUnicode(false);
                entity.Property(e => e.CliActiveflag)
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<ImgStorage>(entity =>
            {
                entity.HasKey(e => e.IdImgsto)
                    .HasName("Pk_ImgStorage_id_imgsto");

                entity.Property(e => e.ImgstoUrl).IsUnicode(false);

                entity.HasOne(d => d.ImgstoIdrootypNavigation)
                    .WithMany(p => p.ImgStorages)
                    .HasForeignKey(d => d.ImgstoIdrootyp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Fk_ImgStorage_room_type");

                entity.HasOne(d => d.ImgstoIduserNavigation)
                    .WithMany(p => p.ImgStorages)
                    .HasForeignKey(d => d.ImgstoIduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Fk_ImgStorage_user");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.IdInvoice)
                    .HasName("Pk_Invoice_id_invoice");

                entity.Property(e => e.InvCode).IsUnicode(false);

                entity.Property(e => e.InvCreatedate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvUpdatedate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.InvIdbookNavigation)
                    .WithOne(p => p.Invoice)
                    .HasForeignKey<Invoice>(d => d.InvIdbook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Invoice__inv_idb__540C7B00");
            });

           
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("Pk_role_id_role");

                entity.Property(e => e.RoleDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.IdRoom)
                    .HasName("Pk_room_id_room");

                entity.Property(e => e.RoomDescription).IsUnicode(false);

                entity.Property(e => e.RoomName).IsUnicode(false);

                entity.HasOne(d => d.RoomIdroomtypeNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.RoomIdroomtype)
                    .HasConstraintName("Fk_room_room_type");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.HasKey(e => e.IdRoomtype)
                    .HasName("Pk_room_type_id_roomtype");

                entity.Property(e => e.RotyDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.RotyName).IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("Pk_Tbl_id_status");

                entity.Property(e => e.StaDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.StaName).IsUnicode(false);
            });

            modelBuilder.Entity<StatusTime>(entity =>
            {
                entity.HasKey(e => e.IdStatim)
                    .HasName("Pk_status_time_id_statim");

                entity.Property(e => e.StatimFromdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatimTodate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.StatimIdroomNavigation)
                    .WithMany(p => p.StatusTimes)
                    .HasForeignKey(d => d.StatimIdroom)
                    .HasConstraintName("Fk_status_time_room");

                entity.HasOne(d => d.StatimIdstatusNavigation)
                    .WithMany(p => p.StatusTimes)
                    .HasForeignKey(d => d.StatimIdstatus)
                    .HasConstraintName("Fk_status_time_status");
            });

           


            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.IdUserol)
                    .HasName("Pk_user_role_id_userol");

              

                entity.HasOne(d => d.UserolIdroleNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserolIdrole)
                    .HasConstraintName("Fk_user_role_role");

                entity.HasOne(d => d.UserolIduserNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserolIduser)
                    .HasConstraintName("Fk_user_role_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }
*/
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
