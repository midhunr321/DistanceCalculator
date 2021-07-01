using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempApp
{
    public partial class Form1 : Form
    {
        private readonly double populationLimit = 550;

        public Form1()
        {
            InitializeComponent();
        }

        private void check_if_lat_lon_or_pop_is_missing_for_datas(List<Country> countries)
        {
            foreach (var country in countries)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Country[] countries;
            FileInfo fileinfo = new FileInfo("C:\\Downloads\\countriesV2.json");
            processJson();

            //JObject data = JObject.Parse(File.ReadAllText(@fileinfo.FullName));

            //countries = JsonConvert.DeserializeObject<Country>(yourJson);

            //using (StreamReader file = File.OpenText("C:\\Downloads\\countriesV2(1).json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    countries o2 = (Country[])JToken.ReadFrom(reader);
            //}
        }


        public void processJson()
        {
            //
            string json;
            using (StreamReader r = new StreamReader("C:\\Downloads\\countriesV2.json"))
            {
                json = r.ReadToEnd();
                //List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(json);
            }
            List<Country> countries =
               JsonConvert.DeserializeObject<List<Country>>(json);

            //List<Country> countries =
            //    JsonConvert.DeserializeObject<List<Country>>(json, new JsonSerializerSettings
            //    {
            //    });

            //var f = countries.Select(x => x.latlng);

            //now the countries which satisfy population condition
            List<Country> valid_countries =
                 get_countries_with_pop_great_or_eq_to_limit(countries, populationLimit);

            calculate_and_display_expected_permutation_count(valid_countries);


            double ans1 = get_total_distance_as_per_the_order(valid_countries, true);
            textBox1.Text = ans1.ToString();
            //textBox2.Text = get_total_distance_by_all_possible_lines(valid_countries).ToString();
            //double rounded_ans1 = Math.Round(ans1,2);
            textBox1_round.Text = ans1.ToString();



            double ans2 = get_total_distance_by_all_possible_lines(valid_countries, true);
            textBox2.Text = ans2.ToString();
            //double rounded_ans2 = Math.Round(ans2, 2);
            textBox2_round.Text = ans2.ToString();

        }

        //private string get_total_distance_by_all_possible_lines(List<Country> valid_countries)
        //{
        //    double total_distance = 0;
        //    int lastIndexToIterate = valid_countries.Count - 2;

        //}


        public double get_total_distance_by_all_possible_lines(List<Country> valid_countries,
            Boolean round_result_of_each_line)
        {
            double total_distance = 0;
            List<CombHolder> combinations = new List<CombHolder>();
            List<CombSeq> permuted_countriesSeqs =
                Permutate.get_various_permuted_country_sequences(valid_countries);
            //List<CombSeq> permuted_non_repeated_countriesSeqs
            //    = Permutate.remove_repetative_elements_from_permuted_list(permuted_countriesSeqs);
            ////now we have a whole list of permuted countries sequence
            ////we need to iterate through each list untill we get the total distance
            foreach (var countriesSeq in permuted_countriesSeqs)
            {
                int i = 0;
                int lastIndexToIterate = countriesSeq.Countries.Count - 2;

                foreach (var country in countriesSeq.Countries)
                {
                    if (i > lastIndexToIterate)
                        break;

                    var currentCountry = countriesSeq.Countries[i];
                    var nextCountry = countriesSeq.Countries[i + 1];

                    double result = get_distance_betwn_2combinations(currentCountry,
                       nextCountry, round_result_of_each_line);
                    total_distance = total_distance + result;
                    i++;
                }

            }


            return total_distance;

        }

        private double get_distance_betwn_2combinations(Country country1, Country country2,
            Boolean round_result_of_each_line)
        {
            double cal_distance = 0;

            var result = DistanceCal.getDistance(country1.latlng[0],
                country2.latlng[0], country1.latlng[1], country2.latlng[1],
                round_result_of_each_line);
            return result;
        }

        private double get_total_distance_as_per_the_order(List<Country> valid_countries,
            Boolean roundEachLine)
        {
            double total_distance = 0;
            int currentIndex = 0;
            int lastIndexToIterate = valid_countries.Count - 2;
            foreach (Country currCountry in valid_countries)
            {
                if (currentIndex > lastIndexToIterate)
                    break;

                int nextCountryIndex = currentIndex + 1;
                Country nextCountry = valid_countries[nextCountryIndex];

                var result = DistanceCal.getDistance(currCountry.latlng[0],
                    nextCountry.latlng[0], currCountry.latlng[1], nextCountry.latlng[1]
                    , roundEachLine);
                total_distance = total_distance + result;

                currentIndex++;
            }

            return total_distance;

        }

        List<Country> get_countries_with_pop_great_or_eq_to_limit(List<Country> countries,
            double pop_limit_val)
        {
            int i = 0;
            List<Country> valid_countries = new List<Country>();
            foreach (Country country in countries)
            {
                if (i == 20)
                {
                    break;
                }
                if (country.population >= pop_limit_val)
                    valid_countries.Add(country);


                i++;
            }

            return valid_countries;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
