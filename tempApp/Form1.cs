using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DistanceCalculator;
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
using MathNet;
using System.Threading;

namespace tempApp
{
    public partial class Form1 : Form
    {
        private double populationLimit = 57100;

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
        private async void button1_Click(object sender, EventArgs e)
        {
            test_new_permutation();
            bool skipPossibilityDistance = true;
            Country[] countries;
            FileInfo fileinfo = new FileInfo("C:\\Downloads\\countriesV2.json");
            double resultTotalDistByOrder = 0;
            double resultTotalDistByAllPossibility = 0;

            var progress = new Progress<ProgRep>(value =>
            {
                labelPerCountDoneVal.Text = value.itemsProcessed.ToString();
                labelProcessDetail.Text = value.currentProcess;
                labelExpPerCountVal.Text = value.totalItems.ToString();
                var percent = (value.itemsProcessed / value.totalItems) * 100;
                percent = Math.Round(percent, 2);
                labelPercentVal.Text = percent.ToString() + "%";
            });


            button1.Enabled = false;
            await Task.Run(() =>
            processJson(out resultTotalDistByOrder, out resultTotalDistByAllPossibility, progress,
            skipPossibilityDistance));

            textBox1.Text = resultTotalDistByOrder.ToString();
            textBox2.Text = resultTotalDistByAllPossibility.ToString();
            button1.Enabled = true;

        }
        private void test_new_permutation()
        {
            List<String> elements = new List<string> { "A", "B", "C", "D" };

            var sorted = Permutations.PermutationErezRobinson.QuickPerm(elements);


        }


        public void processJson(out double ans1DistByOrder, out double ans2DistByAllPoss,
            IProgress<ProgRep> progress, bool skipPossibilityDistance)
        {
            //


            //populationLimit = read_PopulationLimit_from_textbox();

            string json;
            using (StreamReader r = new StreamReader("C:\\Downloads\\countriesV2.json"))
            {
                json = r.ReadToEnd();
                //List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(json);
            }
            List<CountryFull> countries =
               JsonConvert.DeserializeObject<List<CountryFull>>(json);

            //List<Country> countries =
            //    JsonConvert.DeserializeObject<List<Country>>(json, new JsonSerializerSettings
            //    {
            //    });

            //var f = countries.Select(x => x.latlng);

            //now the countries which satisfy population condition
            String filterType = new string("Normal");
            List<CountryFull> countriesFilteredByPop = new List<CountryFull>();
            if (filterType == "Normal")
            {
                countriesFilteredByPop =
               get_countries_with_pop_great_or_eq_to_limit(countries, populationLimit, progress);
            }
            else if (filterType == "Desc")
            {
                countriesFilteredByPop
                    = Permutate.get_countries_with_pop_great_but_first_process_then_filter_then_sort
                    (countries, populationLimit, progress, false);

            }
            else if (filterType == "Asc")
            {
                countriesFilteredByPop
                 = Permutate.get_countries_with_pop_great_but_first_process_then_filter_then_sort
                 (countries, populationLimit, progress, true);
            }		



            List<Country> valid_countries = convert_countryFull_to_country_and_select_20_items(countriesFilteredByPop);

            GlobalVars.expectedPermutationCount = calculate_expected_permutation_count(valid_countries);

            //check_if_the_array_can_hold_all_datas(GlobalVars.expectedPermutationCount);

            ans1DistByOrder = Permutate.get_total_distance_as_per_the_order(valid_countries,true);
            //textBox2.Text = get_total_distance_by_all_possible_lines(valid_countries).ToString();
            //double rounded_ans1 = Math.Round(ans1,2);

            if (skipPossibilityDistance == false)
            {
                ans2DistByAllPoss = Permutate
                    .get_total_distance_by_all_possible_lines(valid_countries, false, progress);
                //double rounded_ans2 = Math.Round(ans2, 2);
            }
            else
            {
                ans2DistByAllPoss = -1;
            }

        }

        private List<Country> convert_countryFull_to_country_and_select_20_items(List<CountryFull> countries)
        {
            List<Country> convertedCountries = new List<Country>();
            int i = 0;
            foreach (var country in countries)
            {
                if (i >= 20)
                    break;

                Country countryNew = new Country();
                countryNew.alpha2Code = country.alpha2Code;
                countryNew.latlng = country.latlng;
                countryNew.population = country.population;
                convertedCountries.Add(countryNew);
                i++;
            }
            return convertedCountries;
        }

        private void check_if_the_array_can_hold_all_datas(double expectedPermutationCount)
        {
            try
            {
                int index = (int)expectedPermutationCount;
                int[] test = new int[index];
            }
            catch (OverflowException)
            {
                MessageBox.Show("This Population limit cannot be carried out");
            }


        }

        private double calculate_expected_permutation_count(List<Country> valid_countries)
        {
            var expectedPermutCount = (MathNet.Numerics.SpecialFunctions.Factorial(valid_countries.Count)) / 2;
            GlobalVars.expectedPermutationCount = expectedPermutCount;
            return expectedPermutCount;
        }

        //private string get_total_distance_by_all_possible_lines(List<Country> valid_countries)
        //{
        //    double total_distance = 0;
        //    int lastIndexToIterate = valid_countries.Count - 2;

        //}






        List<CountryFull> get_countries_with_pop_great_or_eq_to_limit(List<CountryFull> countries,
            double pop_limit_val,
            IProgress<ProgRep> progress)
        {
            ProgRep progRep = new ProgRep();
            progRep.totalItems = countries.Count;

            int i = 0;
            List<CountryFull> valid_countries = new List<CountryFull>();
            foreach (CountryFull country in countries)
            {
                if (i == 20)
                {
                    break;
                }
                if (country.population >= pop_limit_val)
                    valid_countries.Add(country);

                progRep.currentProcess = "Filtering the countries with Population Limit";
                progRep.itemsProcessed = i;
                progress.Report(progRep);

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
            test_new_permutation();
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

        private double read_PopulationLimit_from_textbox()
        {
            double popLimit;
            double.TryParse(textBoxPopLimit.Text.ToString(), out popLimit);
            return popLimit;

        }
        private void buttonFixPopLimit_Click(object sender, EventArgs e)
        {
            populationLimit = read_PopulationLimit_from_textbox();
            button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWebPage_Click(object sender, EventArgs e)
        {
            WebHelper webHelper = new WebHelper();
            webHelper.findText("Population limit:");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
