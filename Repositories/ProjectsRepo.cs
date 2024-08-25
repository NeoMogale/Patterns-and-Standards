using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

//Implements all the methods defined in the generic & interface class

namespace TelemetryPortal_MVC.Repositories
{
    
    public class ProjectsRepo : GenericRepo<Project>, IProjectsRepo
    {
        public ProjectsRepo(TechtrendsContext context) : base(context) { }

        public async Task<List<Project>> GetAllProjectsAsync()
        {
            return (await GetAllGenericAsync()).ToList();
        }

        public async Task<Project> GetProjectsByIdAsync(Guid id)
        {
             var project = await GetGenericByIdAsync(id);
            
            // if statement throws an exception should a null be a possible return value!
            if(project == null)
            {
                throw new InvalidOperationException($"Project with ID {id} does not exist.");
            }
            return project;
        }

        public async Task AddProjectsAsync(Project project)
        {
           
            await AddGenericAsync(project);
        }

        public async Task UpdateProjectsAsync(Project project)
        {
           
            await UpdateGenericAsync(project); 
        }

        public async Task DeleteProjectsAsync(Guid id)
        {
           
            await DeleteGenericAsync(id); 
        }

        public async Task<bool> ProjectExistsAsync(Guid id)
        {
            return await GenericExistsAsync(id);
        }
    }
}
