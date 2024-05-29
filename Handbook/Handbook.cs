using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Handbook
{
    public class Handbook
    {
        public List<Person> People;
        private const string PATH = "Handbook.txt";
        public Handbook(List<Person> persons)
        {
            People = persons;
        }

        public List<Person> Search(int? id = null, string name = null, string surname = null, string country = null, string region = null, string district = null, string settlement = null, string postcode = null)
        {
            return People.Where(p =>
                (!id.HasValue || p.Id == id.Value) &&
                (string.IsNullOrEmpty(name) || p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(surname) || p.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(country) || p.Country.Equals(country, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(region) || p.Region.Equals(region, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(district) || p.District.Equals(district, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(settlement) || p.Settlement.Equals(settlement, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(postcode) || p.Postcode.Equals(postcode, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public void SaveData()
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(PATH, jsonString);
        }

        public static Handbook LoadData()
        {
            if (!File.Exists(PATH))
            {
                return new Handbook([]);
            }
            return JsonSerializer.Deserialize<Handbook>(File.ReadAllText(PATH))!;
        }
    }
}
