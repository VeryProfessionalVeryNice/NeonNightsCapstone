﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNeon
{
    public class Customer
    {
        private int id;
        private string companyName;
        private string jobType;
        private string addressLine1;
        private string addressLine2;
        private string city;
        private string state;
        private string zip;

        public int Id { get => id; set => id = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string AddressLine1 { get => addressLine1; set => addressLine1 = value; }
        public string AddressLine2 { get => addressLine2; set => addressLine2 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string JobType { get => jobType; set => jobType = value; }

        public Customer() { }

        public Customer(string companyName, string jobType, string addressLine1, string addressLine2, string city, string state, string zip)
        {
            id = 0;
            this.companyName = companyName;
            this.jobType = jobType;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public Customer(int id, string companyName, string jobType, string addressLine1, string addressLine2, string city, string state, string zip)
        {
            this.id = id;
            this.companyName = companyName;
            this.jobType = jobType;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public override string ToString()
        {
            return $"ID: {id}\r\nName: {companyName}\r\nJob Type: {jobType}\r\nAddress: {addressLine1} {addressLine2}\r\nCity: {city}\r\nState: {state}\r\nZip: {zip}\r\n";
        }
    }
}
