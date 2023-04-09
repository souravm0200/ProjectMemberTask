using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ProjectRepo
    {
        private static readonly ProjectMemberDBContext Context;

        static ProjectRepo()
        {
            Context = new ProjectMemberDBContext();
        }

        public static IEnumerable<Project> GetAllProjects()
        {
            return Context.Projects.ToList();
        }


        public static Project GetProjectById(int id)
        {
            return Context.Projects.Find(id);
        }

        public static bool AddProject(Project project)
        {
            Context.Projects.Add(project);
            return Context.SaveChanges() > 0;
        }

        public static bool UpdateProject(Project project)
        {
            var dbProject = Context.Projects.Find(project.Id);
            Context.Entry(dbProject).CurrentValues.SetValues(project);
            return Context.SaveChanges() > 0;
        }

        public static bool DeleteProject(int id)
        {
            var project = Context.Projects.Find(id);
            Context.Projects.Remove(project);
            return Context.SaveChanges() > 0;
        }
    }
}
