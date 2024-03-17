﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NSLPWebApi.Data;

#nullable disable

namespace NSLPWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240205175319_ModifyIngredientTable")]
    partial class ModifyIngredientTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NSLPWebApi.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.HasKey("DocumentId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"), 1L, 1);

                    b.Property<int>("APBM")
                        .HasColumnType("int");

                    b.Property<int>("APSM")
                        .HasColumnType("int");

                    b.Property<int>("APUM")
                        .HasColumnType("int");

                    b.Property<double>("AmountPerBulkUnit")
                        .HasColumnType("float");

                    b.Property<double>("AmountPerServing")
                        .HasColumnType("float");

                    b.Property<double>("AmountPerUnit")
                        .HasColumnType("float");

                    b.Property<bool>("Cold")
                        .HasColumnType("bit");

                    b.Property<bool>("Hot")
                        .HasColumnType("bit");

                    b.Property<int?>("IngredientSubTypeId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("MadeInUSA")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Sodiummg")
                        .HasColumnType("float");

                    b.HasKey("IngredientId");

                    b.HasIndex("APBM");

                    b.HasIndex("APSM");

                    b.HasIndex("APUM");

                    b.HasIndex("IngredientSubTypeId");

                    b.HasIndex("IngredientTypeId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("NSLPWebApi.Models.IngredientType", b =>
                {
                    b.Property<int>("IngredientTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientTypeId"), 1L, 1);

                    b.Property<string>("IngredientTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MPDM")
                        .HasColumnType("int");

                    b.Property<int>("MPWM")
                        .HasColumnType("int");

                    b.Property<int>("MXDM")
                        .HasColumnType("int");

                    b.Property<int>("MXWM")
                        .HasColumnType("int");

                    b.Property<double>("MaxPerDay")
                        .HasColumnType("float");

                    b.Property<double>("MaxPerWeek")
                        .HasColumnType("float");

                    b.Property<int>("MenuTypeId")
                        .HasColumnType("int");

                    b.Property<double>("MinPerDay")
                        .HasColumnType("float");

                    b.Property<double>("MinPerWeek")
                        .HasColumnType("float");

                    b.Property<string>("StudentAge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientTypeId");

                    b.HasIndex("MPDM");

                    b.HasIndex("MPWM");

                    b.HasIndex("MXDM");

                    b.HasIndex("MXWM");

                    b.HasIndex("MenuTypeId");

                    b.ToTable("IngredientTypes");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Measurement", b =>
                {
                    b.Property<int>("MeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeasurementId"), 1L, 1);

                    b.Property<string>("MeasurementName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeasurementId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"), 1L, 1);

                    b.Property<DateTime>("MenuDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MenuTypeId")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.HasIndex("MenuTypeId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("NSLPWebApi.Models.MenuToIngredientOrRecipe", b =>
                {
                    b.Property<int>("MenuToIngredientOrRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuToIngredientOrRecipeId"), 1L, 1);

                    b.Property<int>("Attendance")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<string>("Leftovers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeasurementId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<double>("QtyMeasurement")
                        .HasColumnType("float");

                    b.Property<double>("QtyServed")
                        .HasColumnType("float");

                    b.Property<double>("QuantityOffered")
                        .HasColumnType("float");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Temperature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuToIngredientOrRecipeId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("MeasurementId");

                    b.HasIndex("MenuId");

                    b.HasIndex("RecipeId");

                    b.ToTable("MenuToIngredientOrRecipes");
                });

            modelBuilder.Entity("NSLPWebApi.Models.MenuType", b =>
                {
                    b.Property<int>("MenuTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuTypeId"), 1L, 1);

                    b.Property<string>("MenuTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuTypeId");

                    b.ToTable("MenuTypes");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Till")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NSLPWebApi.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("MeasurementId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<bool>("Ordered")
                        .HasColumnType("bit");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("MeasurementId");

                    b.HasIndex("OrderId");

                    b.HasIndex("VendorId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("NSLPWebApi.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryId"), 1L, 1);

                    b.Property<string>("ProductCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductCategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"), 1L, 1);

                    b.Property<bool>("Cold")
                        .HasColumnType("bit");

                    b.Property<bool>("Hot")
                        .HasColumnType("bit");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("RecipeId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("NSLPWebApi.Models.RecipeToIngredient", b =>
                {
                    b.Property<int>("RecipeToIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeToIngredientId"), 1L, 1);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("MeasurementId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("RecipeToIngredientId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("MeasurementId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeToIngredients");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Setting", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<int>("AmountOfStudents")
                        .HasColumnType("int");

                    b.Property<string>("CEPFreeReduced")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SFAName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Ingredient", b =>
                {
                    b.HasOne("NSLPWebApi.Models.Measurement", "APBMeasurement")
                        .WithMany()
                        .HasForeignKey("APBM")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Measurement", "APSMeasurement")
                        .WithMany()
                        .HasForeignKey("APSM")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Measurement", "APUMeasurement")
                        .WithMany()
                        .HasForeignKey("APUM")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.IngredientType", "IngredientSubType")
                        .WithMany()
                        .HasForeignKey("IngredientSubTypeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("NSLPWebApi.Models.IngredientType", "IngredientType")
                        .WithMany()
                        .HasForeignKey("IngredientTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("APBMeasurement");

                    b.Navigation("APSMeasurement");

                    b.Navigation("APUMeasurement");

                    b.Navigation("IngredientSubType");

                    b.Navigation("IngredientType");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("NSLPWebApi.Models.IngredientType", b =>
                {
                    b.HasOne("NSLPWebApi.Models.Measurement", "MPDMeasurement")
                        .WithMany()
                        .HasForeignKey("MPDM")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Measurement", "MPWMeasurement")
                        .WithMany()
                        .HasForeignKey("MPWM")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("NSLPWebApi.Models.Measurement", "MXDMeasurement")
                        .WithMany()
                        .HasForeignKey("MXDM")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("NSLPWebApi.Models.Measurement", "MXWMeasurement")
                        .WithMany()
                        .HasForeignKey("MXWM")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("NSLPWebApi.Models.MenuType", "MenuType")
                        .WithMany()
                        .HasForeignKey("MenuTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MPDMeasurement");

                    b.Navigation("MPWMeasurement");

                    b.Navigation("MXDMeasurement");

                    b.Navigation("MXWMeasurement");

                    b.Navigation("MenuType");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Menu", b =>
                {
                    b.HasOne("NSLPWebApi.Models.MenuType", "MenuType")
                        .WithMany()
                        .HasForeignKey("MenuTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MenuType");
                });

            modelBuilder.Entity("NSLPWebApi.Models.MenuToIngredientOrRecipe", b =>
                {
                    b.HasOne("NSLPWebApi.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Measurement", "Measurement")
                        .WithMany()
                        .HasForeignKey("MeasurementId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Measurement");

                    b.Navigation("Menu");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NSLPWebApi.Models.OrderDetail", b =>
                {
                    b.HasOne("NSLPWebApi.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Measurement", "Measurement")
                        .WithMany()
                        .HasForeignKey("MeasurementId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Measurement");

                    b.Navigation("Order");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("NSLPWebApi.Models.Recipe", b =>
                {
                    b.HasOne("NSLPWebApi.Models.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("NSLPWebApi.Models.RecipeToIngredient", b =>
                {
                    b.HasOne("NSLPWebApi.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Measurement", "Measurement")
                        .WithMany()
                        .HasForeignKey("MeasurementId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSLPWebApi.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Measurement");

                    b.Navigation("Recipe");
                });
#pragma warning restore 612, 618
        }
    }
}
