﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Article.Entities;

namespace DbContexts.ArticleConfigurations
{
    public class ArticleCommentConfig : IEntityTypeConfiguration<ArticleComment>
    {
        public void Configure(EntityTypeBuilder<ArticleComment> e)
        {
            e.ToTable("ArticleComment");
            e.Property(p => p.ArticleCommentId).ValueGeneratedNever();
            e.Property(p => p.ArticleId).IsRequired();
            e.Property(p => p.Comment).IsUnicode(false).IsRequired();
            e.Property(p => p.UserIdOrEmail).IsUnicode(false).HasMaxLength(100);
            e.Property(p => p.UserSocialAvatarUrl).IsUnicode(false);
            e.Property(p => p.IsAdminCommented);
            e.Property(p => p.CommentedDate).IsRequired().HasColumnType("datetime2(7)");
        }
    }
}