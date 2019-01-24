using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonOfTheYear.Models
{
    public class Person
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth_Year { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

       
        // Static method that returns a List of PersonOfTheYear objects.Takes two
        // parameters: startYear and endYear used for filtering the list of all people
        // to just those whose years fall within the desired range
        public static List<Person> GetPersons(int startYear, int endYear)
        {
            List<Person> people = new List<Person>(); //Create new List to store PersonOfTheYear objects
            string path = Environment.CurrentDirectory;//Sets path variable to current directory
            string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\personOfTheYear.csv"));//Finds location of datafile and combines with initial path
            string[] myFile = File.ReadAllLines(newPath);//Reads in all lines of the data file and stores as a string array

            for (int i = 1; i < myFile.Length; i++)//For each string in the myFile array, skipping the top row (column names)
            {
                string[] fields = myFile[i].Split(',');
                people.Add(new Person 
                {
                    Year = Convert.ToInt32(fields[0]), 
                    Honor = fields[1], 
                    Name = fields[2], 
                    Country = fields[3], 
                    Birth_Year = (fields[4] == "") ? 0 : Convert.ToInt32(fields[4]),
                    DeathYear = (fields[5] == "") ? 0 : Convert.ToInt32(fields[5]),
                    Title = fields[6], 
                    Category = fields[7], 
                    Context = fields[8], 
                });
            }