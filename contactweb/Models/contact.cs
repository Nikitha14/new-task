using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contactweb.Models
{
    public class contact
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhonePrimary { get; set; }
        public DateTime Birthday { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string Zipcode { get; set; }

    }
}