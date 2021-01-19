using System;
using System.Collections.Generic;
using System.Linq;

namespace Leopard.Models
{
    public static class ShowRepository
    {
        static ShowRepository()
        {
            if (Shows != null) return;
            Shows = new List<Article>
            {
                new Article
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf1}"),
                    Title = "Show 1",
                    Description = "Show 1 Description",
                    IsPublished = false
                },
                new Article
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf2}"),
                    Title = "show 2",
                    Description = "show 2 Description",
                    IsPublished = false
                },
                
            };
        }

        public static List<Article> Shows { get; set; }

        public static void AddShow(Article entity)
        {
            entity.Id = Guid.NewGuid();            
            Shows.Add(entity);
        }

        public static void UpdateShow(Article entity)
        {
            var old = Shows.Where(e => e.Id == entity.Id).FirstOrDefault();
            old.Name = entity.Title;
            old.Description = entity.Description;
            old.ImageUrl = entity.ImageUrl;
            old.IsFinished = entity.IsPublished;

        }
    }
}
