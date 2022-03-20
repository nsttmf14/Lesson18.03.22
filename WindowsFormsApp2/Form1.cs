using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); // создаем новый пустой кэш данных
            ds.ReadXml("..\\..\\Files\\XMLexample.xml"); // записываем в него XML-данные из файла

            foreach (DataRow passenger in ds.Tables["passenger"].Rows)
            {
                PassengersDGV.Rows.Add(passenger["Имя"], passenger["Фамилия"], passenger["Возраст"], passenger["Место"]);
                CountriesDGV.Rows.Add(passenger["Имя"], passenger["Страна"]);
                PrepaymentDGV.Rows.Add(passenger["Имя"], passenger["Фамилия"], passenger["Предоплата"]);
            }
        }
    }
}
