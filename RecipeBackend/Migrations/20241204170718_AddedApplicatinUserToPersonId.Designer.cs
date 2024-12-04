﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RecipeBackend.Data;

#nullable disable

namespace RecipeBackend.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20241204170718_AddedApplicatinUserToPersonId")]
    partial class AddedApplicatinUserToPersonId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubAllergy", b =>
                {
                    b.Property<Guid>("AllergyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AllergyId");

                    b.ToTable("HubAllergies");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubCuisine", b =>
                {
                    b.Property<Guid>("CuisineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CuisineId");

                    b.ToTable("HubCuisines");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubDietaryRestriction", b =>
                {
                    b.Property<Guid>("DietaryRestrictionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DietaryRestrictionId");

                    b.ToTable("HubDietaryRestrictions");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubDietaryTag", b =>
                {
                    b.Property<Guid>("DietaryTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DietaryTagId");

                    b.ToTable("HubDietaryTags");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubIngredient", b =>
                {
                    b.Property<Guid>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IngredientId");

                    b.ToTable("HubIngredients");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubPerson", b =>
                {
                    b.Property<Guid>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId");

                    b.ToTable("HubPersons");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubRecipe", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RecipeId");

                    b.ToTable("HubRecipes");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinkIngredientAllergy.LinkIngredientAllergy", b =>
                {
                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AllergyId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IngredientId", "AllergyId");

                    b.HasIndex("AllergyId");

                    b.ToTable("LinkIngredientAllergies");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonAllergy", b =>
                {
                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AllergyId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId", "AllergyId");

                    b.HasIndex("AllergyId");

                    b.ToTable("LinkPersonAllergies");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonCuisinePreference", b =>
                {
                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CuisineId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId", "CuisineId");

                    b.HasIndex("CuisineId");

                    b.ToTable("LinkPersonCuisinePreferences");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonDietaryRestriction", b =>
                {
                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DietaryRestrictionId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId", "DietaryRestrictionId");

                    b.HasIndex("DietaryRestrictionId");

                    b.ToTable("LinkPersonDietaryRestrictions");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonRecipe", b =>
                {
                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("LinkPersonRecipe");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksRecipe.LinkRecipeCuisine", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CuisineId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RecipeId", "CuisineId");

                    b.HasIndex("CuisineId");

                    b.ToTable("LinkRecipeCuisines");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksRecipe.LinkRecipeDietaryTag", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DietaryTagId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RecipeId", "DietaryTagId");

                    b.HasIndex("DietaryTagId");

                    b.ToTable("LinkRecipeDietaryTags");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Satellites.SatIngredient", b =>
                {
                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IngredientId", "LoadDate");

                    b.ToTable("SatIngredients");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Satellites.SatPerson", b =>
                {
                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("RecordSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId", "LoadDate");

                    b.ToTable("SatPersons");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Satellites.SatRecipe", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LoadDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Instructions")
                        .HasColumnType("text");

                    b.Property<string>("RecordSource")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("RecipeId", "LoadDate");

                    b.ToTable("SatRecipes");
                });

            modelBuilder.Entity("RecipeBackend.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RecipeBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RecipeBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RecipeBackend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinkIngredientAllergy.LinkIngredientAllergy", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubAllergy", "Allergy")
                        .WithMany("Ingredients")
                        .HasForeignKey("AllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.DataModels.Hubs.HubIngredient", "Ingredient")
                        .WithMany("Allergies")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergy");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonAllergy", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubAllergy", "Allergy")
                        .WithMany("Persons")
                        .HasForeignKey("AllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.DataModels.Hubs.HubPerson", "Person")
                        .WithMany("Allergies")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergy");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonCuisinePreference", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubCuisine", "Cuisine")
                        .WithMany("Persons")
                        .HasForeignKey("CuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.DataModels.Hubs.HubPerson", "Person")
                        .WithMany("CuisinePreferences")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuisine");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonDietaryRestriction", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubDietaryRestriction", "DietaryRestriction")
                        .WithMany("Persons")
                        .HasForeignKey("DietaryRestrictionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.DataModels.Hubs.HubPerson", "Person")
                        .WithMany("DietaryRestrictions")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietaryRestriction");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksPerson.LinkPersonRecipe", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubPerson", "Person")
                        .WithMany("Recipes")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.DataModels.Hubs.HubRecipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksRecipe.LinkRecipeCuisine", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubCuisine", "Cuisine")
                        .WithMany("Recipes")
                        .HasForeignKey("CuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.DataModels.Hubs.HubRecipe", "Recipe")
                        .WithMany("Cuisines")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuisine");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Links.LinksRecipe.LinkRecipeDietaryTag", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubDietaryTag", "DietaryTag")
                        .WithMany("Recipes")
                        .HasForeignKey("DietaryTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBackend.DataModels.Hubs.HubRecipe", "Recipe")
                        .WithMany("DietaryTags")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietaryTag");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Satellites.SatIngredient", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubIngredient", "Ingredient")
                        .WithMany("SatIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Satellites.SatPerson", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubPerson", "Person")
                        .WithMany("SatPersons")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Satellites.SatRecipe", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubRecipe", "Recipe")
                        .WithMany("SatRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBackend.Models.ApplicationUser", b =>
                {
                    b.HasOne("RecipeBackend.DataModels.Hubs.HubPerson", "Person")
                        .WithOne("ApplicationUser")
                        .HasForeignKey("RecipeBackend.Models.ApplicationUser", "PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubAllergy", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubCuisine", b =>
                {
                    b.Navigation("Persons");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubDietaryRestriction", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubDietaryTag", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubIngredient", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("SatIngredients");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubPerson", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("ApplicationUser")
                        .IsRequired();

                    b.Navigation("CuisinePreferences");

                    b.Navigation("DietaryRestrictions");

                    b.Navigation("Recipes");

                    b.Navigation("SatPersons");
                });

            modelBuilder.Entity("RecipeBackend.DataModels.Hubs.HubRecipe", b =>
                {
                    b.Navigation("Cuisines");

                    b.Navigation("DietaryTags");

                    b.Navigation("SatRecipes");
                });
#pragma warning restore 612, 618
        }
    }
}
