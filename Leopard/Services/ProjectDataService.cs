using System;
using System.Collections.Generic;
using Leopard.Models;

namespace Leopard.Services
{
    public class ProjectDataService : IProjectDataService
    {
        public List<Project> GetAllProjects()
        {
            return ProjectRepository.Projects;
        }

        public void AddProject(Project entity)
        {
            ProjectRepository.Add(entity);
        }

        public void UpdateProject(Project entity)
        {
            ProjectRepository.Update(entity);
        }

    }
}
