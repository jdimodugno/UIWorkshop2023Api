using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business;
using Shared.Models;
using Shared.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BreadMaker.Controllers
{
    [Route("api/[controller]")]
    public class IngredientsController : Controller
    {
        IngredientsBusiness component = new IngredientsBusiness();

        // GET: api/values
        [HttpGet]
        public IEnumerable<Ingredient> Get() => component.Read();

        // GET api/values/5
        [HttpGet("{id}")]
        public Ingredient Get(string id) => component.ReadOne(id);

        // POST api/values
        [HttpPost]
        public Ingredient Post([FromBody] IngredientDTO data) => component.Create(data);

        // PUT api/values/5
        [HttpPut("{id}")]
        public Ingredient Put(string id, [FromBody] IngredientDTO data) => component.Update(id, data);

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(string id) => component.Delete(id);
    }
}

