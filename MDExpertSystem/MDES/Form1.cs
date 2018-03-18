using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDES
{
    public partial class Form1 : Form
    {
        #region Properties
        public string fileName = "hmdes.clp";
        public string assertString { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Fever { get; set; }
        public string Symptom1 { get; set; }
        public string Symptom2 { get; set; }
        #endregion

        ClipsFramework cw;

        public Form1()
        {
            InitializeComponent();
            cw = new ClipsFramework();
            cw.Load(fileName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            GetFormValues();
            assertString = string.Format("(preference (gender {0})(age {1})(weight {2})(fever {3})(symptom1 {4})(symptom2 {5}))", Gender, Age, Weight, Fever, Symptom1, Symptom2);
            cw.Reset();
            cw.CreateAssert(assertString);
            cw.Run();
            string response = cw.GetResponse();
            if (!string.IsNullOrEmpty(response))
                lblResult.Text = response;
            else
            {
                ApplyStrategy();
            }

        }

        private void ApplyStrategy()
        {
            cw.Reset();
            LoadAssertsHmdes();
            var results = LoadResultsByDimensions();
            var response = TranslateFinalResult(results);
            lblResult.Text = "You have been diagnosed with " + response;
        }

        private Dictionary<string, int> LoadResultsByDimensions()
        {
            List<string> _results = new List<string>();
            Dictionary<string,int> _resultFinal = new Dictionary<string, int>();
            _results.Add(ByGender(Gender));
            _results.Add(ByWeight(Weight));
            _results.Add(BySymptom(Symptom1));
            _results.Add(BySymptom(Symptom2));
            _results.Add(ByAge(Age));
            _results.Add(ByFever(Fever));
            
            int cM1 = _results.Count(x => x == "1");
            int cM2 = _results.Count(x => x == "2");
            int cM3 = _results.Count(x => x == "3");
            int cM4 = _results.Count(x => x == "4");
            int cM5 = _results.Count(x => x == "5");
            int cM6 = _results.Count(x => x == "6");

            _resultFinal.Add("Disease 1", cM1);
            _resultFinal.Add("Disease 2", cM2);
            _resultFinal.Add("Disease 3", cM3);
            _resultFinal.Add("Disease 4", cM4);
            _resultFinal.Add("Disease 5", cM5);
            _resultFinal.Add("Disease 6", cM6);

            return _resultFinal;
        }

        private string TranslateFinalResult(Dictionary<string, int> results)
        {
            return results.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        }


        private void GetFormValues()
        {
            
            Gender = "2";
            if (comboBoxGender.SelectedItem.ToString() == "Female")
            {
                Gender = "1";
            }else if (comboBoxGender.SelectedItem.ToString() == "Male")
            {
                Gender = "2";
            }

            Age = "1";
            if (comboBoxAge.SelectedItem.ToString() == "teenage")
            {
                Age = "1";
            }
            else if (comboBoxAge.SelectedItem.ToString() == "adult")
            {
                Age = "2";
            }

            Weight = "1";
            if (comboBoxWeight.SelectedItem.ToString() == "no")
            {
                Weight = "1";
            }
            else if (comboBoxWeight.SelectedItem.ToString() == "yes")
            {
                Weight = "2";
            }
            
            Fever = rbFever.Checked ? "y" : "n";

            Symptom1 = "1";
            switch (comboBoxSymptom1.SelectedItem.ToString())
            {
                case "1":
                    Symptom1 = "1";
                    break;
                case "headache":
                    Symptom1 = "2";
                    break;
                case "3":
                    Symptom1 = "3";
                    break;
                case "4":
                    Symptom1 = "4";
                    break;
                case "5":
                    Symptom1 = "5";
                    break;
                default:
                    Symptom1 = "1";
                    break;
            }

            Symptom2 = "1";
            switch (comboBoxSymptom2.SelectedItem.ToString())
            {
                case "1":
                    Symptom2 = "1";
                    break;
                case "2":
                    Symptom2 = "2";
                    break;
                case "3":
                    Symptom2 = "3";
                    break;
                case "4":
                    Symptom2 = "4";
                    break;
                case "5":
                    Symptom2 = "5";
                    break;
                default:
                    Symptom2 = "1";
                    break;
            }
        }

        private void LoadAssertsHmdes()
        {
            string disease1 = "(diagnosis(disease 1)(gender 2)(age 1)(weight 1)(fever n)(symptom1 1)(symptom2 1))";
            string disease2 = "(diagnosis(disease 2)(gender 2)(age 1)(weight 1)(fever y)(symptom1 2)(symptom2 2))";
            string disease3 = "(diagnosis(disease 3)(gender 2)(age 2)(weight 2)(fever y)(symptom1 3)(symptom2 3))";
            string disease4 = "(diagnosis(disease 4)(gender 1)(age 1)(weight 2)(fever y)(symptom1 4)(symptom2 4))";
            string disease5 = "(diagnosis(disease 5)(gender 1)(age 2)(weight 1)(fever y)(symptom1 5)(symptom2 5))";
            string disease6 = "(diagnosis(disease 5)(gender 1)(age 2)(weight 1)(fever n)(symptom1 1)(symptom2 5))";
            cw.CreateAssert(disease1);
            cw.CreateAssert(disease2);
            cw.CreateAssert(disease3);
            cw.CreateAssert(disease4);
            cw.CreateAssert(disease5);
            cw.CreateAssert(disease6);

        }

        private string FindByOtherStrategy(string StrategyProperty, string valueToSearch, string compOperator)
        {
            return cw.GetFact("diagnosis", StrategyProperty, valueToSearch, "disease", "0", compOperator);
        }

        #region Little Strategy finding in facts
        private string ByGender(string value)
        {
            return FindByOtherStrategy("gender", value, "<=");
        }
        private string ByAge(string value)
        {
            return FindByOtherStrategy("age", value, "eq");
        }
        private string ByWeight(string value)
        {
            return FindByOtherStrategy("weight", value, ">=");
        }
        private string BySymptom(string value)
        {
            return FindByOtherStrategy("symptom", value, "<=");
        }
        private string ByFever(string value)
        {
            return FindByOtherStrategy("fever", value, "eq");
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}


