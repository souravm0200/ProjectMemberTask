using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class MemberRepo
    {
        private static readonly ProjectMemberDBContext Context;

        static MemberRepo()
        {
            Context = new ProjectMemberDBContext();
        }

        public static IEnumerable<Member> GetAllMembers()
        {
            return Context.Members.ToList();
        }
    }
}
