using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5_HW_Comparers
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<TemperatureMeasurments> measurments = new List<TemperatureMeasurments>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBox1.Text, textBox3.Text, int.Parse(textBox2.Text)));
            MessageBox.Show("נוסף בהצלחה");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            students.Sort();
            MessageBox.Show("מוין בהצלחה");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            students.Sort(new SortStudentsByLastName());
            MessageBox.Show("מוין בהצלחה");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students.Sort(new SortStudentsByGrade());
            MessageBox.Show("מוין בהצלחה");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string city = textBox6.Text;
            
            int year = int.Parse(textBox4.Text);
            int month = int.Parse(textBox8.Text);
            int day = int.Parse(textBox9.Text);
            DateTime date = new DateTime(year, month, day);
            
            double deg = double.Parse(textBox5.Text);
           
            double moist = double.Parse(textBox7.Text);

            measurments.Add(new TemperatureMeasurments(city, date, deg, moist));
            MessageBox.Show("נוסף בהצלחה");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            measurments.Sort();
            MessageBox.Show("מוין בהצלחה");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            measurments.Sort(new SortMeasurmentsByCity());
            MessageBox.Show("מוין בהצלחה");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            measurments.Sort(new SortMeasurmentsByCityOrDate());
            MessageBox.Show("מוין בהצלחה");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            measurments.Sort(new SortMeasurmentsByTempOrCity());
            MessageBox.Show("מוין בהצלחה");
        }
    }
}
