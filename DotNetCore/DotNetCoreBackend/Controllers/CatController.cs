using Infra.NH.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetCoreBackend.Controllers
{
    [Route("api/[controller]")]
    public class CatController : Controller
    {
        [HttpGet]
        public IEnumerable<Cat> GetAll()
        {
            return GetCats();
        }

        [HttpGet("{name}")]
        public Cat Get(string name)
        {
            foreach(Cat cat in GetCats())
            {
                if (name == cat.Name)
                    return cat;
            }

            return new Cat() { Name = name };
        }

        [HttpPost]
        public Cat Insert([FromBody]Cat cat)
        {
            // write the new cat to database
            return cat;
        }

        [HttpPut("{name}")]
        public Cat Update(string name, [FromBody]Cat cat)
        {
            cat.Name = name;
            // write the updated cat to database
            return cat;
        }

        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            // delete the cat from the database

        }

        private List<Cat> GetCats()
        {
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat() { CatId = 1, Name = "Nami" });
            cats.Add(new Cat() { CatId = 2, Name = "Atena" });
            cats.Add(new Cat() { CatId = 3, Name = "Fumaça" });
            cats.Add(new Cat() { CatId = 4, Name = "Boris" });

            return cats;
        }
    }
}