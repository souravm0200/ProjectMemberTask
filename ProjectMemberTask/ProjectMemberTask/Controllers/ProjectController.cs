using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectProjectTask.Controllers
{
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/project")]
        public HttpResponseMessage GetAllProjects()
        {
            try
            {
                var data = ProjectService.GetAllProjects();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/project/{id}")]
        public HttpResponseMessage GetProjectById(int id)
        {
            try
            {
                var data = ProjectService.GetProjectById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/project")]
        public HttpResponseMessage AddProject([FromBody] ProjectDTO project)
        {
            try
            {
                var data = ProjectService.AddProject(project);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPatch]
        [Route("api/project")]
        public HttpResponseMessage UpdateProject([FromBody] ProjectDTO project)
        {
            try
            {
                var data = ProjectService.UpdateProject(project);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/project/{id}")]
        public HttpResponseMessage DeleteProject(int id)
        {
            try
            {
                var data = ProjectService.DeleteProject(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }





    }
}