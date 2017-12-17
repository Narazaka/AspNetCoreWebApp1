using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApp1.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private ApplicationDbContext dbContext = ApplicationDbContext.Current;

        [HttpGet]
        public IEnumerable<Models.User> Get()
        {
            return dbContext.Users.ToList();
        }

        [HttpGet("{id}")]
        public Models.User Get(long id)
        {
            return dbContext.Users.Find(id);
        }

        [HttpPost]
        public void Post([FromBody]string name)
        {
            dbContext.Users.Add(new Models.User { Name = name });
            dbContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string name)
        {
            var user = dbContext.Users.Find(id);
            if (user == null) {
                return;
            } else {
                user.Name = name;
                dbContext.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dbContext.Users.Remove(dbContext.Users.Find(id));
            dbContext.SaveChanges();
        }
    }
}
