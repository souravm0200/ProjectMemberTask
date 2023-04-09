using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectMemberTask.Controllers
{
    public class MemberController : ApiController
    {
        [HttpGet]
        [Route("api/member")]
        public HttpResponseMessage GetAllMembers()
        {
            try
            {
                var data = MemberService.GetAllMembers();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/member/{id}")]
        public HttpResponseMessage GetMemberById(int id)
        {
            try
            {
                var data = MemberService.GetMemberById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/member")]
        public HttpResponseMessage AddMember([FromBody] MemberDTO member)
        {
            try
            {
                var data = MemberService.AddMember(member);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPatch]
        [Route("api/member")]
        public HttpResponseMessage UpdateMember([FromBody] MemberDTO member)
        {
            try
            {
                var data = MemberService.UpdateMember(member);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/member/{id}")]
        public HttpResponseMessage DeleteMember(int id)
        {
            try
            {
                var data = MemberService.DeleteMember(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }













    }
}