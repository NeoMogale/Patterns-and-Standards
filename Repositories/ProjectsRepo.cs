using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

//Implements all the methods defined in the interface class

namespace TelemetryPortal_MVC.Repositories
{
    
    public class ProjectsRepo : IProjectsRepo
    {
        private readonly TechtrendsContext _context;
        public ProjectsRepo(TechtrendsContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetAllProjectsAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetProjectsByIdAsync(Guid id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(p => p.ProjectId == id);
            
            // if statement throws an exception should a null be a possible return value!

            if(project == null)
            {
                throw new InvalidOperationException("Project does not exist!");
            }
            return project;
        }

        public async Task AddProjectsAsync(Project project)
        {
            project.ProjectId = Guid.NewGuid();
            _context.Add(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProjectsAsync(Project project)
        {
            _context.Update(project);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProjectsAsync(Guid id)
        {
            var project = await _context.Projects.FindAsync(id);
            if(project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ProjectExistsAsync(Guid id)
        {
            return await _context.Projects.AnyAsync(q => q.ProjectId == id);
        }
    }
}
