﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservationCore.Db;

#nullable disable

namespace RestaurantReservationCore.Db.Migrations
{
    [DbContext(typeof(RestaurantReservationDbContext))]
    partial class RestaurantReservationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "987654321"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "bob.brown@example.com",
                            FirstName = "Bob",
                            LastName = "Brown",
                            PhoneNumber = "456123789"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "charlie.white@example.com",
                            FirstName = "Charlie",
                            LastName = "White"
                        },
                        new
                        {
                            CustomerId = 6,
                            Email = "emily.davis@example.com",
                            FirstName = "Emily",
                            LastName = "Davis",
                            PhoneNumber = "789456123"
                        },
                        new
                        {
                            CustomerId = 7,
                            Email = "david.wilson@example.com",
                            FirstName = "David",
                            LastName = "Wilson"
                        },
                        new
                        {
                            CustomerId = 8,
                            Email = "grace.taylor@example.com",
                            FirstName = "Grace",
                            LastName = "Taylor",
                            PhoneNumber = "321654987"
                        },
                        new
                        {
                            CustomerId = 9,
                            Email = "ethan.anderson@example.com",
                            FirstName = "Ethan",
                            LastName = "Anderson"
                        },
                        new
                        {
                            CustomerId = 10,
                            Email = "olivia.moore@example.com",
                            FirstName = "Olivia",
                            LastName = "Moore",
                            PhoneNumber = "159753258"
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            FirstName = "Tom",
                            LastName = "Jones",
                            Position = "Waiter",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            FirstName = "Sarah",
                            LastName = "Connor",
                            Position = "Chef",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 3,
                            FirstName = "Michael",
                            LastName = "Scott",
                            Position = "Manager",
                            RestaurantId = 2
                        },
                        new
                        {
                            EmployeeId = 4,
                            FirstName = "Dwight",
                            LastName = "Schrute",
                            Position = "Waiter",
                            RestaurantId = 2
                        },
                        new
                        {
                            EmployeeId = 5,
                            FirstName = "Pam",
                            LastName = "Beesly",
                            Position = "Receptionist",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 6,
                            FirstName = "Jim",
                            LastName = "Halpert",
                            Position = "Assistant Manager",
                            RestaurantId = 2
                        },
                        new
                        {
                            EmployeeId = 7,
                            FirstName = "Angela",
                            LastName = "Martin",
                            Position = "Chef",
                            RestaurantId = 3
                        },
                        new
                        {
                            EmployeeId = 8,
                            FirstName = "Stanley",
                            LastName = "Hudson",
                            Position = "Waiter",
                            RestaurantId = 3
                        },
                        new
                        {
                            EmployeeId = 9,
                            FirstName = "Ryan",
                            LastName = "Howard",
                            Position = "Waiter",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 10,
                            FirstName = "Kelly",
                            LastName = "Kapoor",
                            Position = "Waiter",
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("MenuItemId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1,
                            Description = "Delicious cheese pizza",
                            Name = "Pizza",
                            Price = 12.99,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 2,
                            Description = "Juicy beef burger",
                            Name = "Burger",
                            Price = 9.9900000000000002,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 3,
                            Description = "Fresh garden salad",
                            Name = "Salad",
                            Price = 6.9900000000000002,
                            RestaurantId = 2
                        },
                        new
                        {
                            MenuItemId = 4,
                            Description = "Creamy Alfredo pasta",
                            Name = "Pasta",
                            Price = 10.99,
                            RestaurantId = 2
                        },
                        new
                        {
                            MenuItemId = 5,
                            Description = "Grilled steak",
                            Name = "Steak",
                            Price = 19.989999999999998,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 6,
                            Description = "Fresh sushi rolls",
                            Name = "Sushi",
                            Price = 15.99,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 7,
                            Description = "Hot chicken soup",
                            Name = "Soup",
                            Price = 5.9900000000000002,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 8,
                            Description = "Spicy beef tacos",
                            Name = "Tacos",
                            Price = 8.9900000000000002,
                            RestaurantId = 2
                        },
                        new
                        {
                            MenuItemId = 9,
                            Description = "Vanilla ice cream",
                            Name = "Ice Cream",
                            Price = 3.9900000000000002,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 10,
                            Description = "Crispy French fries",
                            Name = "Fries",
                            Price = 2.9900000000000002,
                            RestaurantId = 1
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2024, 10, 18, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7421),
                            ReservationId = 1,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 2,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2024, 10, 17, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7425),
                            ReservationId = 2,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 3,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2024, 10, 16, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7427),
                            ReservationId = 3,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 4,
                            EmployeeId = 4,
                            OrderDate = new DateTime(2024, 10, 15, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7429),
                            ReservationId = 4,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 5,
                            EmployeeId = 9,
                            OrderDate = new DateTime(2024, 10, 14, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7431),
                            ReservationId = 5,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 6,
                            EmployeeId = 7,
                            OrderDate = new DateTime(2024, 10, 13, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7433),
                            ReservationId = 6,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 7,
                            EmployeeId = 8,
                            OrderDate = new DateTime(2024, 10, 12, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7435),
                            ReservationId = 7,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 8,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2024, 10, 11, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7437),
                            ReservationId = 8,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 9,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2024, 10, 10, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7439),
                            ReservationId = 9,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            OrderId = 10,
                            EmployeeId = 6,
                            OrderDate = new DateTime(2024, 10, 9, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7441),
                            ReservationId = 10,
                            TotalAmount = 0.0
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            MenuItemId = 1,
                            OrderId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemId = 2,
                            MenuItemId = 2,
                            OrderId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 3,
                            MenuItemId = 3,
                            OrderId = 2,
                            Quantity = 3
                        },
                        new
                        {
                            OrderItemId = 4,
                            MenuItemId = 4,
                            OrderId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 5,
                            MenuItemId = 5,
                            OrderId = 3,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemId = 6,
                            MenuItemId = 6,
                            OrderId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 7,
                            MenuItemId = 7,
                            OrderId = 4,
                            Quantity = 4
                        },
                        new
                        {
                            OrderItemId = 8,
                            MenuItemId = 8,
                            OrderId = 5,
                            Quantity = 3
                        },
                        new
                        {
                            OrderItemId = 9,
                            MenuItemId = 9,
                            OrderId = 6,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemId = 10,
                            MenuItemId = 10,
                            OrderId = 7,
                            Quantity = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            CustomerId = 1,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 10, 20, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7323),
                            RestaurantId = 1,
                            TableId = 1
                        },
                        new
                        {
                            ReservationId = 2,
                            CustomerId = 2,
                            PartySize = 2,
                            ReservationDate = new DateTime(2024, 10, 21, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7366),
                            RestaurantId = 1,
                            TableId = 2
                        },
                        new
                        {
                            ReservationId = 3,
                            CustomerId = 3,
                            PartySize = 6,
                            ReservationDate = new DateTime(2024, 10, 22, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7376),
                            RestaurantId = 2,
                            TableId = 3
                        },
                        new
                        {
                            ReservationId = 4,
                            CustomerId = 4,
                            PartySize = 8,
                            ReservationDate = new DateTime(2024, 10, 23, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7379),
                            RestaurantId = 2,
                            TableId = 4
                        },
                        new
                        {
                            ReservationId = 5,
                            CustomerId = 5,
                            PartySize = 10,
                            ReservationDate = new DateTime(2024, 10, 24, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7381),
                            RestaurantId = 3,
                            TableId = 5
                        },
                        new
                        {
                            ReservationId = 6,
                            CustomerId = 6,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 10, 25, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7383),
                            RestaurantId = 3,
                            TableId = 6
                        },
                        new
                        {
                            ReservationId = 7,
                            CustomerId = 7,
                            PartySize = 6,
                            ReservationDate = new DateTime(2024, 10, 26, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7385),
                            RestaurantId = 1,
                            TableId = 7
                        },
                        new
                        {
                            ReservationId = 8,
                            CustomerId = 8,
                            PartySize = 2,
                            ReservationDate = new DateTime(2024, 10, 27, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7387),
                            RestaurantId = 2,
                            TableId = 8
                        },
                        new
                        {
                            ReservationId = 9,
                            CustomerId = 9,
                            PartySize = 8,
                            ReservationDate = new DateTime(2024, 10, 28, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7390),
                            RestaurantId = 3,
                            TableId = 9
                        },
                        new
                        {
                            ReservationId = 10,
                            CustomerId = 10,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 10, 29, 15, 20, 2, 579, DateTimeKind.Local).AddTicks(7392),
                            RestaurantId = 1,
                            TableId = 10
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Address = "123 Main St",
                            Name = "Gourmet Paradise",
                            OpeningHours = "9 AM - 10 PM",
                            PhoneNumber = "555-1234"
                        },
                        new
                        {
                            RestaurantId = 2,
                            Address = "456 Elm St",
                            Name = "Food Haven",
                            OpeningHours = "10 AM - 11 PM",
                            PhoneNumber = "555-5678"
                        },
                        new
                        {
                            RestaurantId = 3,
                            Address = "789 Oak St",
                            Name = "Taste Buds",
                            OpeningHours = "11 AM - 12 AM",
                            PhoneNumber = "555-9876"
                        },
                        new
                        {
                            RestaurantId = 4,
                            Address = "789 Elm St",
                            Name = "The Great Restaurant",
                            OpeningHours = "11 AM - 12 AM",
                            PhoneNumber = "555-9876"
                        },
                        new
                        {
                            RestaurantId = 5,
                            Address = "789 Main St",
                            Name = "The Best Restaurant",
                            OpeningHours = "11 AM - 12 AM",
                            PhoneNumber = "555-9876"
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            Capacity = 4,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 2,
                            Capacity = 2,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 3,
                            Capacity = 6,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 4,
                            Capacity = 8,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 5,
                            Capacity = 10,
                            RestaurantId = 3
                        },
                        new
                        {
                            TableId = 6,
                            Capacity = 4,
                            RestaurantId = 3
                        },
                        new
                        {
                            TableId = 7,
                            Capacity = 6,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 8,
                            Capacity = 2,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 9,
                            Capacity = 8,
                            RestaurantId = 3
                        },
                        new
                        {
                            TableId = 10,
                            Capacity = 4,
                            RestaurantId = 1
                        });
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.Views.CustomerReservationsByRestaurant", b =>
                {
                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.ToTable((string)null);

                    b.ToView("CustomersReservationByRestaurant", (string)null);
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Employee", b =>
                {
                    b.HasOne("RestaurantReservationCore.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.MenuItem", b =>
                {
                    b.HasOne("RestaurantReservationCore.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("MenuItems")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Order", b =>
                {
                    b.HasOne("RestaurantReservationCore.Db.DataModels.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservationCore.Db.DataModels.Reservation", "Reservation")
                        .WithMany("Orders")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.OrderItem", b =>
                {
                    b.HasOne("RestaurantReservationCore.Db.DataModels.MenuItem", "MenuItem")
                        .WithMany("OrderItems")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservationCore.Db.DataModels.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Reservation", b =>
                {
                    b.HasOne("RestaurantReservationCore.Db.DataModels.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservationCore.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestaurantReservationCore.Db.DataModels.Table", "Table")
                        .WithMany("Reservations")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Restaurant");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Table", b =>
                {
                    b.HasOne("RestaurantReservationCore.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.MenuItem", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Reservation", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Restaurant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("MenuItems");

                    b.Navigation("Reservations");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("RestaurantReservationCore.Db.DataModels.Table", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
