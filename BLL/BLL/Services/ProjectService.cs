using BLL.DTOs;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectService
    {
        public static List<ProjectDTO> GetAllProjects()
        {
            var data = ProjectRepo.GetAllProjects();
            return ProjectConverter(data);
        }


        public static ProjectDTO GetProjectById(int id)
        {
            var data = ProjectRepo.GetProjectById(id);
            return ProjectConverter(data);
        }
        public static bool AddProject(ProjectDTO project)
        {
            var data = ProjectConverter(project);
            return ProjectRepo.AddProject(data);
        }

        public static bool UpdateProject(ProjectDTO project)
        {
            var data = ProjectConverter(project);
            return ProjectRepo.UpdateProject(data);
        }

        public static bool DeleteProject(int id)
        {
            return ProjectRepo.DeleteProject(id);
        }

























        //For converter

        private static List<ProjectDTO> ProjectConverter(IEnumerable<DAL.Models.Project> data)
        {
            return data.Select(ProjectConverter).ToList();
        }
        private static ProjectDTO ProjectConverter(DAL.Models.Project data)
        {
            var project = new ProjectDTO()
            {
                Id = data.Id,
                Title = data.Title,
                Status = data.Status,
                StartDate = data.StartDate,
                EndDate = data.EndDate,

            };
            return project;
        }

        private static DAL.Models.Project ProjectConverter(ProjectDTO data)
        {
            var project = new DAL.Models.Project()
            {
                Id = data.Id,
                Title = data.Title,
                Status = data.Status,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
            };
            return project;
        }
    }
}
