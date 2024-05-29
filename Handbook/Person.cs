using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country {  get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string Settlement { get; set; }
        public string Postcode { get; set; }
        public string FullName => Name + " " + Surname;

        public Person(int id, string name, string surname, string country, string region, string district, string settlement, string postcode) 
        { 
            Id = id;
            Name = name;
            Surname = surname;
            Country = country;
            Region = region;
            District = district;
            Settlement = settlement;
            Postcode = postcode;
        }
    }
}
