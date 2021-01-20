using System;
using System.Collections.Generic;
using System.Linq;

namespace Leopard.Models
{
    public static class ArticleRepository
    {
        static ArticleRepository()
        {
            if (Articles != null) return;
            Articles = new List<Article>
            {
                new Article
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf1}"),
                    Title = "article 1",
                    Description = "article 1 Description",
                    IsPublished = false
                },
                new Article
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf2}"),
                    Title = "article 2",
                    Description = "article 2 Description",
                    IsPublished = false
                },

            };
        }

        public static List<Article> Articles { get; set; }

        public static void Add(Article entity)
        {
            entity.Id = Guid.NewGuid();
            // entity.GeneratedUrl = GenerateUrl(title);
            Articles.Add(entity);
        }

        public static void Update(Article entity)
        {
            var old = Articles.Where(e => e.Id == entity.Id).FirstOrDefault();
            old.Title = entity.Title;
            old.Description = entity.Description;
            old.Content = entity.Content;
            old.ImageUrl = entity.ImageUrl;
            old.IsPublished = entity.IsPublished;

        }
    }
}
