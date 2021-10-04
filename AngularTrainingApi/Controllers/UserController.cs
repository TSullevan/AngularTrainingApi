using AngularTrainingApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AngularTrainingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        [HttpPost]
        public User Create([FromBody] User user)
        {
            return user;
        }

        [HttpPut]
        public User Update([FromBody] User user)
        {
            return user;
        }

        [HttpGet]
        [Route("{id}")]
        public User Get(int id)
        {
            return new User()
            {
                Name = "Luís Henrique Mandetta",
                Cpf = "100.000.001-01",
                Telephone1 = "(10) 10000-1000",
                Telephone2 = "(10) 10000-1000"
            };
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return true;
        }

        [HttpPost]
        [Route("list")]
        public IEnumerable<User> List([FromBody] object query)
        {
            return new List<User>()
            {
                new User()
                {
                    Name = "Luís Henrique Mandetta",
                    Cpf = "100.000.001-01",
                     Telephone1 = "(10) 10000-1000",
                     Telephone2 = "(10) 10000-1000"
                },
                new User()
                {
                    Name = "Henrique Meirelles",
                    Cpf = "202.020.002-02",
                     Telephone1 = "(20) 20000-2000",
                     Telephone2 = "(20) 20000-2000"
                },
                new User()
                {
                    Name = "Everaldo Meirelles",
                    Cpf = "303.033.302-02",
                    Telephone1 = "(30) 30000-3000",
                    Telephone2 = "(30) 30000-3000"
                }
            };
        }

        [HttpPost]
        [Route("combo")]
        public IEnumerable<ComboItem> Combo([FromBody] object query)
        {
            return new List<ComboItem>()
            {
                new ComboItem()
                {
                    Id = 1,
                    Text = "Luís Henrique Mandetta"
                },
                new ComboItem()
                {
                    Id = 2,
                    Text = "Henrique Meirelles"
                },
                new ComboItem()
                {
                    Id = 3,
                    Text = "Everaldo Meirelles"
                }
            };
        }
    }
}
