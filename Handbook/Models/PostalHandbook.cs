using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handbook.Models
{
    public class PostalHandbook
    {
        [JsonInclude]
        public List<Person> People;
        private const string PATH = "Handbook.txt";
        public PostalHandbook(List<Person> people)
        {
            People = people;
        }

        public List<Person> Search(int? id = null, string name = null, string surname = null, string country = null, string region = null, string district = null, string settlement = null, string postcode = null)
        {
            return People.Where(p =>
                (!id.HasValue || p.Id == id.Value) &&
                (string.IsNullOrEmpty(name) || p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(surname) || p.Surname.Contains(surname, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(country) || p.Country.Contains(country, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(region) || p.Region.Contains(region, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(district) || p.District.Contains(district, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(settlement) || p.Settlement.Contains(settlement, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(postcode) || p.Postcode.Contains(postcode, StringComparison.OrdinalIgnoreCase))
            ).OrderBy(p => p.Surname).ToList();
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

        public static PostalHandbook LoadData()
        {
            if (!File.Exists(PATH))
            {
                return new PostalHandbook([]);
            }
            return JsonSerializer.Deserialize<PostalHandbook>(File.ReadAllText(PATH))!;
        }
    }
}
