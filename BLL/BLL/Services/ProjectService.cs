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
