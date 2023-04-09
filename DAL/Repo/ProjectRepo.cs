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
    }
}
