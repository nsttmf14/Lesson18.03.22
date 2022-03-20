using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly string path = "..\\..\\Files\\JSONexample.json";
        private void Form1_Load(object sender, EventArgs e)
        {
            dynamic passengers = new List<Json>();

            string json = File.ReadAllText(path);

            passengers = JsonConvert.DeserializeObject<Json>(json);
            PassengersDGV.Rows.Add(passengers.Name, passengers.Surname, passengers.Age, passengers.Place);
            CountriesDGV.Rows.Add(passengers.Name, passengers.Country);
            PrepaymentDGV.Rows.Add(passengers.Name, passengers.Surname, passengers.Prepayment);
        }
    }
}
