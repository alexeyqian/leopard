﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Leopard.Models
{
    public static class ProjectRepository
    {
        static ProjectRepository()
        {
            if (Projects != null) return;
            
            Projects = new List<Project>
            {
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf1}"),
                    Name = "Project 1",
                    Description = "Project 1 Description",
                    IsStarted = false,
                    //Budget = 100000
                },
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf2}"),
                    Name = "Project 2",
                    Description = "Project 2 Description",
                    IsStarted = false,
                    //Budget = 200000
                },
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf3}"),
                    Name = "Project 3",
                    Description = "Project 3 Description",
                    IsStarted = false,
                    //Budget = 30000
                },
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf4}"),
                    Name = "Project 4",
                    Description = "Project 4 Description",
                    IsStarted = false,
                    //Budget = 400000
                },
            };
            
        }

        public static List<Project> Projects { get; set; }

        public static void Add(Project entity)
        {
            entity.Id = Guid.NewGuid();            
            Projects.Add(entity);
        }

        public static void Update(Project entity)
        {
            var old = Projects.Where(e => e.Id == entity.Id).FirstOrDefault();
            old.Name = entity.Name;
            old.Description = entity.Description;
            old.ImageUrl = entity.ImageUrl;
            old.IsStarted = entity.IsStarted;
            //old.Budget = entity.Budget;
        }

    }
}
