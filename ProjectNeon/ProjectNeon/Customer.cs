using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNeon
{
    public class Customer
    {
        private int customerID;
        private string firstName;
        private string lastName;
        private string addressLine1;
        private string city;
        private string state;
        private string zip;

        public int CustomerID { get => customerID; set => customerID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string AddressLine1 { get => addressLine1; set => addressLine1 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
    }
}
