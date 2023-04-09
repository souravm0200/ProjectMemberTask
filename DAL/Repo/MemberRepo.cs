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

        public static Member GetMemberById(int id)
        {
            return Context.Members.Find(id);
        }

        public static bool AddMember(Member member)
        {
            Context.Members.Add(member);
            return Context.SaveChanges() > 0;
        }

        public static bool UpdateMember(Member member)
        {
            var dbmember = Context.Members.Find(member.Id);
            Context.Entry(dbmember).CurrentValues.SetValues(member);
            return Context.SaveChanges() > 0;
        }

        public static bool DeleteMember(int id)
        {
            var member = Context.Members.Find(id);
            Context.Members.Remove(member);
            return Context.SaveChanges() > 0;
        }
    }
}
