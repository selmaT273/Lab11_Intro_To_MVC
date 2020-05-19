using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_Intro_To_MVC.Models
{
    public class PersonOfTheYear
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }


        public static List<PersonOfTheYear> GetPeople(int startYear, int endYear)
        {

            string[] getPeopleData = File.ReadAllLines("personOfTheYear.csv");

            return getPeopleData
                .Skip(1)
                .Select(eachData => eachData.Split(","))
                .Select(eachCol => new PersonOfTheYear()
                {
                    Year = int.Parse(eachCol[0]),
                    Honor = eachCol[1],
                    Name = eachCol[2],
                    Country = eachCol[3],
                    BirthYear = int.Parse(eachCol[4]),
                    DeathYear = int.Parse(eachCol[5]),
                    Title = eachCol[6],
                    Category = eachCol[7],
                    Context = eachCol[8]
                }).ToList();
        }
    }
}