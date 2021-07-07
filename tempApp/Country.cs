using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceCalculator
{
   public class Country
    {
     public String alpha2Code;
     public double[] latlng;
        public double population;


        public string Alpha2Code { get => alpha2Code; set => alpha2Code = value; }
       
        public double[] Latlng { get => latlng; set => latlng = value; }
      

       
    }


}
