﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Article.Dtos
{
    public class ArticleCommitDto
    {
        public long ArticleCommitId { get; set; }
        public string Commit { get; set; }
        public DateTime CommittedDate { get; set; }
        public string UserIdOrEmail { get; set; }
        public string UserSocialAvatarUrl { get; set; }
        public bool? IsAdminCommited { get; set; }   // typo mistakes can fix by any one, courtesy
        //Foreign key for Article
        public long ArticleId { get; set; }
    }
}
