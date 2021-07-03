using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceCalculator
{
  public  class CombSeq
    {
        List<Country> countries;

        public List<Country> Countries { get => countries; set => countries = value; }

        public  string Print_alfa_codes_in_series()
        {
            String alphacodes = new String("");
            foreach(var country in countries)
            {
             alphacodes = alphacodes + " {"  + country.alpha2Code + "} ";
            }
            return alphacodes;
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;
        //    if(obj is CombSeq)
        //    {
        //        CombSeq objToCheck = (CombSeq)obj;
                
        //    }
        //    //return base.Equals(obj);
        //}
    }


    //class CombSeq
    //{
    //    List<Double> sequence;

    //    public List<Double> Sequence { get => sequence; set => sequence = value; }
    //}
}
