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
            Shows = new List<Show>
            {
                new Show
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf1}"),
                    Name = "Show 1",
                    Description = "Show 1 Description",
                    IsFinished = false
                },
                new Show
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf2}"),
                    Name = "show 2",
                    Description = "show 2 Description",
                    IsFinished = false
                },
                
            };
        }

        public static List<Show> Shows { get; set; }

        public static void AddShow(Show entity)
        {
            entity.Id = Guid.NewGuid();            
            Shows.Add(entity);
        }

        public static void UpdateShow(Show entity)
        {
            var old = Shows.Where(e => e.Id == entity.Id).FirstOrDefault();
            old.Name = entity.Name;
            old.Description = entity.Description;
            old.ImageUrl = entity.ImageUrl;
            old.IsFinished = entity.IsFinished;

        }
    }
}
