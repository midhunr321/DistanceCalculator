using KellermanSoftware.CompareNetObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbForInterview
{

    class Permutate
    {
        private static void Swap(ref Country a, ref Country b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        private static void GetPer(Country[] list, List<CombSeq> combSeqs)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x, combSeqs);
        }

        private static List<Country> array_to_list(Country[] array)
        {
            List<Country> list = new List<Country>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            return list;
        }
        private static String print_all_sequences(List<CombSeq> combSeqs)
        {
            String sequences = new String("");
            foreach(var combSeq in combSeqs)
            {
                sequences = sequences + combSeq.Print_alfa_codes_in_series() + "\n" ;
            }
            return sequences;
        }
        private static void GetPer(Country[] list, int k, int m, List<CombSeq> combSeqs)
        {
            if (k == m)
            {
                CombSeq combSeq = new CombSeq();
                var convertedList = array_to_list(list);
                combSeq.Countries = array_to_list(list);
              if(reverse_of_this_element_is_already_exists_in_array
                    (combSeq,combSeqs)== false)
                {
                    combSeqs.Add(combSeq);
                }
               
                Console.Write(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m, combSeqs);
                    Swap(ref list[k], ref list[i]);
                }

        }

        private static bool reverse_of_this_element_is_already_exists_in_array
            (CombSeq newElement, List<CombSeq> existingList)
        {
            //if (existingList.Contains(newElement))
            //    return true;

            if (element_already_exists(newElement, existingList))
                return true;

                //now take reverse of the new element to be added
                CombSeq reversed = reverse_list(newElement);
            if (element_already_exists(reversed, existingList))
                return true;
            //if (existingList.Contains(reversed))
            //    return true;

            //no repetitions found then return false
            return false;
        }

        private static bool element_already_exists(CombSeq newElement, List<CombSeq> existingList)
        {
            foreach(var combseq in existingList)
            {
                CompareLogic comparelogic = new CompareLogic();
                var result = comparelogic.Compare(newElement, combseq);

                if (result.AreEqual)
                    return true;

                //if (combseq.Equals(newElement))
                //    return true;
            }
            return false;
        }

        public static List<CombSeq> get_various_permuted_country_sequences(List<Country> countries_b4_per)
        {
            Country[] countries_b4_per_arry = countries_b4_per.ToArray();
            List<CombSeq> permuted_countries_Seqs = new List<CombSeq>();
            GetPer(countries_b4_per_arry, permuted_countries_Seqs);
            return permuted_countries_Seqs;
        }

        //internal static List<CombSeq> remove_repetative_elements_from_permuted_list
        //    (List<CombSeq> permuted_countriesSeqs)
        //{
        //    int indexOfCurrent = 0;
        //    List<CombSeq> otherCountriesSeqs = new List<CombSeq>(permuted_countriesSeqs);
        //    foreach (CombSeq currentCountrySeq in permuted_countriesSeqs)
        //    {
        //        //first reverse rest all countryseq except this
        //        //then check if there is any matching for this countryseq
        //        //thus eliminate repetative elements.

        //        //step 1: remove the current countrySeq from otherCountriesSeqs
        //        otherCountriesSeqs.Remove(currentCountrySeq);

        //        // now we got otherCountriesSeqs without currentCountrySeq

        //        //step2:- now check if currentCountrySeq is matching with any elements of otherCountriesSeqs
        //        remove_reptative_elements(currentCountrySeq, otherCountriesSeqs);

        //    }



        //}



        //private static void remove_reptative_elements
        //    (CombSeq currentCountrySeq, List<CombSeq> otherCountriesSeqs)
        //{
        //    foreach (CombSeq otherCountriesSeq in otherCountriesSeqs)
        //    {
        //        CombSeq reversedOtherCountriesSeq = reverse_list(otherCountriesSeq);
        //        if(reversedOtherCountriesSeq.Countries.Contains(curr))
        //    }

        //}

        private static CombSeq reverse_list(CombSeq listToReverse)
        {
            CombSeq reversedList = new CombSeq();
            reversedList.Countries = new List<Country>();
            int lastIndex = listToReverse.Countries.Count - 1;
            int i = lastIndex;
            int j = 0;


            while (i >= 0 && j <= lastIndex )
            {
                reversedList.Countries.Insert(j, listToReverse.Countries[i]);
                i--;
                j++;
            }

            return reversedList;
        }
    }








    //class Permutate
    //{
    //    private static void Swap(ref double a, ref double b)
    //    {
    //        if (a == b) return;

    //        var temp = a;
    //        a = b;
    //        b = temp;
    //    }

    //    private static void GetPer(double[] list, List<CombSeq> combSeqs)
    //    {
    //        int x = list.Length - 1;
    //        GetPer(list, 0, x, combSeqs);
    //    }

    //    private static List<Double> array_to_list(Double[] array)
    //    {
    //        List<Double> list = new List<double>();
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            list.Add(array[i]);
    //        }
    //        return list;
    //    }
    //    private static void GetPer(double[] list, int k, int m, List<CombSeq> combSeqs)
    //    {
    //        if (k == m)
    //        {
    //            CombSeq combSeq = new CombSeq();
    //            var convertedList = array_to_list(list);
    //            combSeq.Sequence = array_to_list(list);
    //            combSeqs.Add(combSeq);
    //            Console.Write(list);
    //        }
    //        else
    //            for (int i = k; i <= m; i++)
    //            {
    //                Swap(ref list[k], ref list[i]);
    //                GetPer(list, k + 1, m, combSeqs);
    //                Swap(ref list[k], ref list[i]);
    //            }

    //    }

    //    public static List<CombSeq> main()
    //    {

    //        double[] arr = { 1, 2, 3 };
    //        List<CombSeq> combSeqs = new List<CombSeq>();
    //        GetPer(arr, combSeqs);
    //        return combSeqs;
    //    }
    //}
}
