using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineLesson.Domain.Entities;
using OnlineLesson.Service.DTOs;
using OnlineLesson.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OnlineLesson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;  
        }

        [HttpPost]
        public User Create(UserForCreationDto userDto)
        {
            return userService.Create(userDto);
        }

        [HttpGet]
        [Route("id")]
        public User Get(int Id)
        {
            return userService.Get(p => p.Id == Id);
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return userService.GetAll();
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return userService.Delete(p => p.Id == Id);
        }

        [HttpPut]
        public User Update(int Id, UserForCreationDto userDto)
        {
            return userService.Update(Id, userDto);
        }
    }
}
