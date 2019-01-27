using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represent a single user
    /// </summary>
    public class Person
    {
        /// <summary>
        /// User unique identifier.
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// The user First Name
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// The user Last Name
        /// </summary>
        public string LastName { get; set; } = "";
    }
}