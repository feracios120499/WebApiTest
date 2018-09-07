using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Book> books = new List<Book>()
        {
            new Book{Id=1,Name="123"}
        };
        // GET api/values
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET api/values/5
        public Book Get(int id)
        {
            return books[id];
        }

        // POST api/values
        [HttpPost]
        public void Post(Book book)
        {
            books.Add(book);
        }

        // PUT api/values/5
        public void Put(int id, Book value)
        {
            books[books.FindIndex(x=>x.Id==id)] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            books.RemoveAt(id);
            
        }
    }
}
