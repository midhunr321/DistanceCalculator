using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProbForInterview;
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
        private double populationLimit = 0;

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
            Country[] countries;
            FileInfo fileinfo = new FileInfo("C:\\Downloads\\countriesV2.json");
            double resultTotalDistByOrder =0 ;
            double resultTotalDistByAllPossibility=0;

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
            processJson(out resultTotalDistByOrder, out resultTotalDistByAllPossibility,progress));

            textBox1.Text = resultTotalDistByOrder.ToString();
            textBox2.Text = resultTotalDistByAllPossibility.ToString();
            button1.Enabled = true;
           
        }


        public void processJson(out double ans1DistByOrder, out double ans2DistByAllPoss,
            IProgress<ProgRep> progress )
        {
            //
           

            populationLimit = read_PopulationLimit_from_textbox();

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

        GlobalVars.expectedPermutationCount=calculate_expected_permutation_count(valid_countries);

            check_if_the_array_can_hold_all_datas(GlobalVars.expectedPermutationCount);

             ans1DistByOrder = get_total_distance_as_per_the_order(valid_countries, true);
            //textBox2.Text = get_total_distance_by_all_possible_lines(valid_countries).ToString();
            //double rounded_ans1 = Math.Round(ans1,2);

             ans2DistByAllPoss = Permutate
                .get_total_distance_by_all_possible_lines(valid_countries,true,progress);
            //double rounded_ans2 = Math.Round(ans2, 2);

        }

        private void check_if_the_array_can_hold_all_datas(double expectedPermutationCount)
        {
            int maxIndex = (int) expectedPermutationCount;
            int[] max = new int[maxIndex];
        }

        private double calculate_expected_permutation_count(List<Country> valid_countries)
        {
            var expectedPermutCount= (MathNet.Numerics.SpecialFunctions.Factorial(valid_countries.Count))/2;
            GlobalVars.expectedPermutationCount = expectedPermutCount;
            return expectedPermutCount;
        }

        //private string get_total_distance_by_all_possible_lines(List<Country> valid_countries)
        //{
        //    double total_distance = 0;
        //    int lastIndexToIterate = valid_countries.Count - 2;

        //}


      

      
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

       private double read_PopulationLimit_from_textbox()
        {
            double popLimit;
            double.TryParse(textBoxPopLimit.Text.ToString(),out popLimit);
            return popLimit;

        }
        private void buttonFixPopLimit_Click(object sender, EventArgs e)
        {
          populationLimit =   read_PopulationLimit_from_textbox();
            button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
