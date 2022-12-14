// <auto-generated />
using System;
using Labb_1_Avancerat.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb_1_Avancerat.NET.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220928080813_addedListtoLoanorderForReturnedBooks")]
    partial class addedListtoLoanorderForReturnedBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb_1_Avancerat.NET.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookTitle = "Svanen",
                            CategoryId = 1
                        },
                        new
                        {
                            BookId = 2,
                            BookTitle = "Pistolen",
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 3,
                            BookTitle = "Nakna Pistolen",
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("Labb_1_Avancerat.NET.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Komedi"
                        });
                });

            modelBuilder.Entity("Labb_1_Avancerat.NET.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "narfgren@hotmail.com",
                            FirstName = "Lucas",
                            LastName = "Narfgren"
                        });
                });

            modelBuilder.Entity("Labb_1_Avancerat.NET.Models.LoanOrder", b =>
                {
                    b.Property<int>("LoanOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfLoan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfReturn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LoanOrderId1")
                        .HasColumnType("int");

                    b.HasKey("LoanOrderId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LoanOrderId1");

                    b.ToTable("LoanOrders");
                });

            modelBuilder.Entity("Labb_1_Avancerat.NET.Models.Book", b =>
                {
                    b.HasOne("Labb_1_Avancerat.NET.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb_1_Avancerat.NET.Models.LoanOrder", b =>
                {
                    b.HasOne("Labb_1_Avancerat.NET.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb_1_Avancerat.NET.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb_1_Avancerat.NET.Models.LoanOrder", null)
                        .WithMany("ReturnedBooks")
                        .HasForeignKey("LoanOrderId1");
                });
#pragma warning restore 612, 618
        }
    }
}
