using BLL.DTOs;
using DAL.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MemberService
    {
        public static List<MemberDTO> GetAllMembers()
        {
            var data = MemberRepo.GetAllMembers();
            return MemberConverter(data);
        }


        private static List<MemberDTO> MemberConverter(IEnumerable<DAL.Models.Member> data)
        {
            return data.Select(MemberConverter).ToList();
        }
        private static MemberDTO MemberConverter(DAL.Models.Member data)
        {
            var member = new MemberDTO()
            {
                Id = data.Id,
                Role=data.Role,
                Name= data.Name,

            };
            return member;
        }

        private static DAL.Models.Member MemberConverter(MemberDTO data)
        {
            var member = new DAL.Models.Member()
            {
                Id = data.Id,
                Role = data.Role,
                Name = data.Name,

            };
            return member;
        }
    }
}
