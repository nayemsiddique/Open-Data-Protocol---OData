using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odata.Models;
using System;
using System.Collections.Generic;

namespace Odata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        public ActionResult<List<User>> GetUser()
        {
            return Ok(new List<User>()
            {
                new User{
                    Id= Guid.NewGuid(),
                    Age=20,
                    Name="X X"
                },
                 new User{
                    Id= Guid.NewGuid(),
                    Age=21,
                    Name="y y"
                },
                  new User{
                    Id= Guid.NewGuid(),
                    Age=22,
                    Name="z z"
                },
                   new User{
                    Id= Guid.NewGuid(),
                    Age=23,
                    Name="s s"
                },
                    new User{
                    Id= Guid.NewGuid(),
                    Age=24,
                    Name="q q"
                }
            });
        }
    }
}
