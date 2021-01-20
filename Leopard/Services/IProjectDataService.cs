using System;
using System.Collections.Generic;
using Leopard.Models;

namespace Leopard.Services
{
    public interface IProjectDataService
    {
        List<Project> GetAllProjects();
        void AddProject(Project project);
        void UpdateProject(Project project);
    }
}
