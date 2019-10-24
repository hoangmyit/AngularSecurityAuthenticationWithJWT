﻿// <auto-generated />
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(JWTDemoDbContext))]
    [Migration("20191024164504_update-relationship-CreateDatabase")]
    partial class updaterelationshipCreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Admin Role",
                            Name = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Manager Role",
                            Name = "Manager"
                        },
                        new
                        {
                            ID = 3,
                            Description = "User Role",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Password = "123",
                            Username = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            Password = "123",
                            Username = "Manager"
                        },
                        new
                        {
                            ID = 3,
                            Password = "123",
                            Username = "User"
                        },
                        new
                        {
                            ID = 4,
                            Password = "123",
                            Username = "Both"
                        });
                });

            modelBuilder.Entity("Entity.UserRole", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("RoleID");

                    b.Property<int>("ID");

                    b.HasKey("UserID", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            RoleID = 1,
                            ID = 1
                        },
                        new
                        {
                            UserID = 2,
                            RoleID = 2,
                            ID = 2
                        },
                        new
                        {
                            UserID = 3,
                            RoleID = 3,
                            ID = 3
                        },
                        new
                        {
                            UserID = 4,
                            RoleID = 1,
                            ID = 4
                        },
                        new
                        {
                            UserID = 4,
                            RoleID = 2,
                            ID = 5
                        });
                });

            modelBuilder.Entity("Entity.UserRole", b =>
                {
                    b.HasOne("Entity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
