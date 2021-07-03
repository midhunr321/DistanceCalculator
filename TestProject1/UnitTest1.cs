using NUnit.Framework;
using System.Collections.Generic;
using System;
using DistanceCalculator;


namespace TestProject1
{
    public class Tests
    {
        List<String> fullList = new List<string>();
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void Test1()
        {
            
           List<Country> valid_countries = new List<Country>();
         
            valid_countries.Add
                (new Country() { alpha2Code = "A", latlng = new Double[] { 37.09, -95.71 } });
            valid_countries.Add(new Country() 
            { alpha2Code = "B",latlng = new Double[] { 20.59, 78.96 } });
            valid_countries.Add(new Country() 
            { alpha2Code = "C", latlng = new Double[] { 35.86, 104.19 } });
            IProgress<ProgRep> progress = null;
         var ans =  Permutate.get_total_distance_by_all_possible_lines(valid_countries, true,progress);
        }


        [Test]
        public void Test2()
        {
            String[] list = new string[] { "A", "B", "C", "D" };
         Permutations.PermutationOuellet.ForAllPermutation(list, fdfdf);
           
        }
        
        private bool fdfdf(string[] arg)
        {
            fullList.Add(get_sequence(arg));
            return false;
        }

       
    }
}