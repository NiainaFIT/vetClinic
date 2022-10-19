using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace vetClinic.Services.Database
{
    public partial class VetStationDbContext : DbContext
    {
        public VetStationDbContext()
        {
        }

        public VetStationDbContext(DbContextOptions<VetStationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; } = null!;
        public virtual DbSet<AnimalImage> AnimalImages { get; set; } = null!;
        public virtual DbSet<AnimalMicrochip> AnimalMicrochips { get; set; } = null!;
        public virtual DbSet<AnimalTreatement> AnimalTreatements { get; set; } = null!;
        public virtual DbSet<Appointement> Appointements { get; set; } = null!;
        public virtual DbSet<AppointementStatus> AppointementStatuses { get; set; } = null!;
        public virtual DbSet<Breed> Breeds { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ClientAnimal> ClientAnimals { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; } = null!;
        public virtual DbSet<Microchip> Microchips { get; set; } = null!;
        public virtual DbSet<Note> Notes { get; set; } = null!;
        public virtual DbSet<NoteType> NoteTypes { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderInvoice> OrderInvoices { get; set; } = null!;
        public virtual DbSet<OrderItem> OrderItems { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductType> ProductTypes { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<PurchaseItem> PurchaseItems { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<ServiceMeasure> ServiceMeasures { get; set; } = null!;
        public virtual DbSet<ServiceType> ServiceTypes { get; set; } = null!;
        public virtual DbSet<Specie> Species { get; set; } = null!;
        public virtual DbSet<SpeciesService> SpeciesServices { get; set; } = null!;
        public virtual DbSet<TreatementService> TreatementServices { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-TPA7RE7\\MSSQLSERVEREXP;Initial Catalog=VetStationDb;Persist Security Info=True;User Id=sa;Password=test");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animal");

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.BreedId).HasColumnName("BreedID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfDeath).HasColumnType("datetime");

                entity.Property(e => e.IsAlive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsDangerous)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsSterilized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Breed)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.BreedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Animal_Breed");
            });

            modelBuilder.Entity<AnimalImage>(entity =>
            {
                entity.ToTable("AnimalImage");

                entity.Property(e => e.AnimalImageId).HasColumnName("AnimalImageID");

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.Caption).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalImages)
                    .HasForeignKey(d => d.AnimalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnimalImage_Animal");
            });

            modelBuilder.Entity<AnimalMicrochip>(entity =>
            {
                entity.ToTable("AnimalMicrochip");

                entity.Property(e => e.AnimalMicrochipId)
                    .ValueGeneratedNever()
                    .HasColumnName("AnimalMicrochipID");

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ExternalMicrochipNumber).HasMaxLength(20);

                entity.Property(e => e.MicrochipId).HasColumnName("MicrochipID");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalMicrochips)
                    .HasForeignKey(d => d.AnimalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnimalMicrochip_Animal");

                entity.HasOne(d => d.Microchip)
                    .WithMany(p => p.AnimalMicrochips)
                    .HasForeignKey(d => d.MicrochipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnimalMicrochip_Microchip");
            });

            modelBuilder.Entity<AnimalTreatement>(entity =>
            {
                entity.ToTable("AnimalTreatement");

                entity.Property(e => e.AnimalTreatementId)
                    .ValueGeneratedNever()
                    .HasColumnName("AnimalTreatementID");

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.AppointementId).HasColumnName("AppointementID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalTreatements)
                    .HasForeignKey(d => d.AnimalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnimalTreatement_Animal");

                entity.HasOne(d => d.Appointement)
                    .WithMany(p => p.AnimalTreatements)
                    .HasForeignKey(d => d.AppointementId)
                    .HasConstraintName("FK_AnimalTreatement_Appointement1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AnimalTreatements)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AnimalTreatement_User");
            });

            modelBuilder.Entity<Appointement>(entity =>
            {
                entity.ToTable("Appointement");

                entity.Property(e => e.AppointementId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppointementID");

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.AppointemenStatusId).HasColumnName("AppointemenStatusID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VetId).HasColumnName("VetID");

                entity.HasOne(d => d.AppointemenStatus)
                    .WithMany(p => p.Appointements)
                    .HasForeignKey(d => d.AppointemenStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointement_AppointementStatus");
            });

            modelBuilder.Entity<AppointementStatus>(entity =>
            {
                entity.ToTable("AppointementStatus");

                entity.Property(e => e.AppointementStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppointementStatusID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EditedByUserId).HasColumnName("EditedByUserID");

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<Breed>(entity =>
            {
                entity.ToTable("Breed");

                entity.Property(e => e.BreedId).HasColumnName("BreedID");

                entity.Property(e => e.BreedName).HasMaxLength(200);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.SpeciesId).HasColumnName("SpeciesID");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.Breeds)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Breed_Specie");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId)
                    .ValueGeneratedNever()
                    .HasColumnName("CityID");

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.IdcardNumber)
                    .HasMaxLength(20)
                    .HasColumnName("IDCardNumber");

                entity.Property(e => e.Jmbg)
                    .HasMaxLength(13)
                    .HasColumnName("JMBG");

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.Ppt)
                    .HasMaxLength(20)
                    .HasColumnName("PPT");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Client_City");
            });

            modelBuilder.Entity<ClientAnimal>(entity =>
            {
                entity.ToTable("ClientAnimal");

                entity.Property(e => e.ClientAnimalId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientAnimalID");

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.AnimalIdcardNo)
                    .HasMaxLength(50)
                    .HasColumnName("AnimalIDCardNo");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsCurrentOwner)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.ClientAnimals)
                    .HasForeignKey(d => d.AnimalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientAnimal_Animal");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientAnimals)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientAnimal_Client");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CountryID");

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");
            });

            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.ToTable("InvoiceItem");

                entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");

                entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.OrderInvoiceId).HasColumnName("OrderInvoiceID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.OrderInvoice)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.OrderInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceItem_OrderInvoice");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceItem_Product");
            });

            modelBuilder.Entity<Microchip>(entity =>
            {
                entity.ToTable("Microchip");

                entity.Property(e => e.MicrochipId)
                    .ValueGeneratedNever()
                    .HasColumnName("MicrochipID");

                entity.Property(e => e.BatchSerialNumber).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(15);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EditedByUserId).HasColumnName("EditedByUserID");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("Note");

                entity.Property(e => e.NoteId)
                    .ValueGeneratedNever()
                    .HasColumnName("NoteID");

                entity.Property(e => e.AnimalTreatementId).HasColumnName("AnimalTreatementID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.NoteTypeId).HasColumnName("NoteTypeID");

                entity.HasOne(d => d.AnimalTreatement)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.AnimalTreatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Note_AnimalTreatement");

                entity.HasOne(d => d.NoteType)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.NoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Note_NoteType");
            });

            modelBuilder.Entity<NoteType>(entity =>
            {
                entity.ToTable("NoteType");

                entity.Property(e => e.NoteTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("NoteTypeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.NoteName).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(20);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Client");
            });

            modelBuilder.Entity<OrderInvoice>(entity =>
            {
                entity.ToTable("OrderInvoice");

                entity.Property(e => e.OrderInvoiceId).HasColumnName("OrderInvoiceID");

                entity.Property(e => e.DateOfInvoice).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TotalWithPdv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TotalWithPDV");

                entity.Property(e => e.TotalWithoutPdv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TotalWithoutPDV");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderInvoices)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderInvoice_Order");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderInvoices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderInvoice_User");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemsId);

                entity.Property(e => e.OrderItemsId).HasColumnName("OrderItemsID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ProductTypeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductType");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.ToTable("ProductType");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.Property(e => e.DateOfPurchase).HasColumnType("datetime");

                entity.Property(e => e.Napomena).HasMaxLength(500);

                entity.Property(e => e.Pdv)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PDV");

                entity.Property(e => e.PurchaseInvoice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseReceiptNo).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchase_User");
            });

            modelBuilder.Entity<PurchaseItem>(entity =>
            {
                entity.ToTable("PurchaseItem");

                entity.Property(e => e.PurchaseItemId).HasColumnName("PurchaseItemID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UlazStavke_Product");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseItems)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UlazStavke_Purchase");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateReviewed).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Review_Client");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Review_Product");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeactivated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ServiceID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceMeasureId).HasColumnName("ServiceMeasureID");

                entity.Property(e => e.ServiceName).HasMaxLength(200);

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.HasOne(d => d.ServiceMeasure)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ServiceMeasureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_ServiceMeasure");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_ServiceType");
            });

            modelBuilder.Entity<ServiceMeasure>(entity =>
            {
                entity.ToTable("ServiceMeasure");

                entity.Property(e => e.ServiceMeasureId)
                    .ValueGeneratedNever()
                    .HasColumnName("ServiceMeasureID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.MeasureName).HasMaxLength(20);

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.ToTable("ServiceType");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ServiceTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<Specie>(entity =>
            {
                entity.ToTable("Specie");

                entity.Property(e => e.SpecieId).HasColumnName("SpecieID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.SpecieName).HasMaxLength(50);
            });

            modelBuilder.Entity<SpeciesService>(entity =>
            {
                entity.ToTable("SpeciesService");

                entity.Property(e => e.SpeciesServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("SpeciesServiceID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SpecieId).HasColumnName("SpecieID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.SpeciesServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpeciesService_Service");

                entity.HasOne(d => d.Specie)
                    .WithMany(p => p.SpeciesServices)
                    .HasForeignKey(d => d.SpecieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpeciesService_Specie");
            });

            modelBuilder.Entity<TreatementService>(entity =>
            {
                entity.Property(e => e.TreatementServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("TreatementServiceID");

                entity.Property(e => e.AnimalTreatementId).HasColumnName("AnimalTreatementID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.HasOne(d => d.AnimalTreatement)
                    .WithMany(p => p.TreatementServices)
                    .HasForeignKey(d => d.AnimalTreatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TreatementServices_AnimalTreatement");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TreatementServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TreatementServices_Service");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeactivated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Jmbg)
                    .HasMaxLength(13)
                    .HasColumnName("JMBG");

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.PasswordHash).HasMaxLength(50);

                entity.Property(e => e.PasswordSalt).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.UserRoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserRoleID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
