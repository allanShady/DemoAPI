using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// Information about people api call
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        /// <summary>
        /// Get the lsit of all user
        /// </summary>
        public PeopleController()
        {
            people.Add(new Person { Id = 2, FirstName = "Alan", LastName = "Camilo" });
            people.Add(new Person { Id = 3, FirstName = "Salman", LastName = "Camilo Mucusse" });
            people.Add(new Person { Id = 1, FirstName = "Ana", LastName = "Momade Camilo" });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        /// <summary>
        /// Get Fisrts names of all people.
        /// </summary>
        /// <returns></returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add(person.FirstName);
            }

            return output;
        }

        /// <summary>
        /// Get the list First Name of all users.
        /// </summary>
        /// <param name="userId">User unique identifier</param>
        /// <param name="age">age of the user</param>
        /// <returns></returns>
        [Route("api/People/GetFirstNames/{UserId:int}/{Age:int}")]
        [HttpGet]
        public List<string> GetFirstNamesByFilters(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.FirstName} {userId} - {age}");
            }

            return output;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            people.Remove(people.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
