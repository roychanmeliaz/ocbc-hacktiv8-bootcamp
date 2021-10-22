﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentAPI.Models;

namespace PaymentAPI.Migrations
{
    [DbContext(typeof(ItemDataContext))]
    partial class ItemDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("PaymentAPI.Models.ItemData", b =>
                {
                    b.Property<int>("paymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("cardOwnerName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("expirationDate")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("securityCode")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("paymentDetailId");

                    b.ToTable("PaymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
