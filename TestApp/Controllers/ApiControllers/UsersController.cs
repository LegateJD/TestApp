using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using TestApp.Models;
using TestApp.Service;

namespace TestApp.Controllers.ApiControllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public DataResponse GetAll()
        {
            var users = _userService.GetAll();
            var dataResponse = new DataResponse {Data = users};

            return dataResponse;
        }
    }
}
