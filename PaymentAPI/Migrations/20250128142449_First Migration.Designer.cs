﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentAPI.Models;

#nullable disable

namespace PaymentAPI.Migrations
{
    [DbContext(typeof(PaymentDetailContext))]
    [Migration("20250128142449_First Migration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PaymentAPI.Models.PaymentDetailModels", b =>
                {
                    b.Property<int>("PaymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentDetailId"));

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("cardOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("expirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("securityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("PaymentDetailId");

                    b.ToTable("PaymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
