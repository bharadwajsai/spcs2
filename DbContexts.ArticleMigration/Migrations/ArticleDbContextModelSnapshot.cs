﻿// <auto-generated />
using System;
using DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbContexts.ArticleMigration.Migrations
{
    [DbContext(typeof(ArticleDbContext))]
    partial class ArticleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Article.Entities.Article", b =>
                {
                    b.Property<long>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActiveDays")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(7);

                    b.Property<string>("AllRelatedSubjectsIncludesVersionsWithComma")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("AttachedAssetsInCloudCount");

                    b.Property<Guid?>("AttachedAssetsInCloudStorageId");

                    b.Property<string>("AttachedAssetsStoredInCloudBaseFolderPath")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("AttachmentURLsComma")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("BiodataUrl")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Body")
                        .HasMaxLength(100);

                    b.Property<string>("Commits")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<bool>("HireMe");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsArchived");

                    b.Property<bool>("IsArticleInDraftMode");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("License");

                    b.Property<string>("OpenSourceUrls")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("SocialURLsWithComma")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag1")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag10")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag11")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag12")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag2")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag3")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag4")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag5")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag6")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag7")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag8")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Tag9")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("TotalVotedPersonsCount");

                    b.Property<int>("TotalVotes");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("UserEmail")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("UserId")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("UserLoggedInSocialProviderName")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("UserPhoneNumber")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("UserSocialAvatarUrl")
                        .HasMaxLength(2000)
                        .IsUnicode(false);

                    b.HasKey("ArticleId");

                    b.ToTable("Article");
                });
#pragma warning restore 612, 618
        }
    }
}
