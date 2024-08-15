using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal_MVC.Models;

// this class defines the interface of the Projects Repository. 
//outlines methods that the repository will implement

namespace TelemetryPortal_MVC.Repositories
{

    public interface IProjectsRepo
    {
        Task<List<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectsByIdAsync(Guid id);
        Task AddProjectsAsync(Project project);
        Task UpdateProjectsAsync(Project project);
        Task DeleteProjectsAsync(Guid id);
        Task<bool> ProjectExistsAsync(Guid id);
    }

}
