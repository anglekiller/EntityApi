﻿using System.Collections.Generic;
using System.Linq;
using EntityframworkCodeFirst.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntityframworkCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Books>> Get()
        {
            using (var _context = new apiDBcontext())
            {
               // Publisher publisher = _context.Publishers.FirstOrDefault();
               // _context.Publishers.Remove(publisher);
               // _context.SaveChanges();
                return _context.Books.ToArray() ;
            }
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
