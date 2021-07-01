using NUnit.Framework;
using System.Collections.Generic;
using ProbForInterview;
using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void Test1()
        {
            ProbForInterview.Form1 form = new ProbForInterview.Form1();
           List<Country> valid_countries = new List<Country>();
         
            valid_countries.Add
                (new Country() { alpha2Code = "A", latlng = new Double[] { 37.09, -95.71 } });
            valid_countries.Add(new Country() 
            { alpha2Code = "B",latlng = new Double[] { 20.59, 78.96 } });
            valid_countries.Add(new Country() 
            { alpha2Code = "C", latlng = new Double[] { 35.86, 104.19 } });

         var ans =  form.get_total_distance_by_all_possible_lines(valid_countries, true);
        }
    }
}