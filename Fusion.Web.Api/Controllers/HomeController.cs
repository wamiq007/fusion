using Fusion.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fusion.Web.Api.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {
        UserService userService =new UserService();

        [HttpGet]
        [Route("users")]
        [Authorize]
        public IHttpActionResult GetAllUsers()
        {
            var user = userService.GetAllUsers();
            return Ok(user);
        }
    }
}
