using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locate_People_Package.Model
{
    public class EmailSearchRequestModel
    {
        public PersonName Name { get; set; }
        public PostAddr Address { get; set; }
        public string SSN { get; set; }
    }

    public class PersonName
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }


    public class PostAddr
    {
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string StreetName { get; set; }
        public string StreetNum { get; set; }
        public string Apt { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }

    public class PhoneSearchRequestModel
    {
        public PersonName Name { get; set; }
        public PostAddr Address { get; set; }
    }


    public class ReversePhoneSearchRequestModel
    {
        public string PhoneNumber { get; set; }
    }

}
