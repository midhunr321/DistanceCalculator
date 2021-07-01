using System;
using System.Collections.Generic;
using System.Text;

namespace ProbForInterview
{
   public class Country
    {
     public String alpha2Code;
     public String alpha3Code;
     public String[] altSpellings;
     public Double area;
     public String[] borders;
     public String[] callingCodes;
     public String capital;
     public Currency[] currencies;
     public String demonym;
     public String flag;
     public String gini;
     public Language[] languages;
     public double[] latlng;
     public String name;
     public String nativeName;
     public int numericCode;
     public double population;
     public String region;
     public RegionalBloc[] regionalBlocs;
     public String[] timezones;
     public String[] topLevelDomain;
     public KeyValuePair<String, String> translations;
     public String cioc;

        public string Alpha2Code { get => alpha2Code; set => alpha2Code = value; }
        public string Alpha3Code { get => alpha3Code; set => alpha3Code = value; }
        public string[] AltSpellings { get => altSpellings; set => altSpellings = value; }
        public double Area { get => area; set => area = value; }
        public string[] Borders { get => borders; set => borders = value; }
        public String[] CallingCodes { get => callingCodes; set => callingCodes = value; }
        public string Capital { get => capital; set => capital = value; }
        public string Demonym { get => demonym; set => demonym = value; }
        public string Flag { get => flag; set => flag = value; }
        public String Gini { get => gini; set => gini = value; }
        public double[] Latlng { get => latlng; set => latlng = value; }
        public string Name { get => name; set => name = value; }
        public string NativeName { get => nativeName; set => nativeName = value; }
        public int NumericCode { get => numericCode; set => numericCode = value; }
        public double Population { get => population; set => population = value; }
        public string Region { get => region; set => region = value; }
        public string[] Timezones { get => timezones; set => timezones = value; }
        public string[] TopLevelDomain { get => topLevelDomain; set => topLevelDomain = value; }
        public KeyValuePair<string, string> Translations { get => translations; set => translations = value; }
        public string Cioc { get => cioc; set => cioc = value; }
        public Currency[] Currencies { get => currencies; set => currencies = value; }
        public Language[] Languages { get => languages; set => languages = value; }
        public RegionalBloc[] RegionalBlocs { get => regionalBlocs; set => regionalBlocs = value; }

       
    }


}
