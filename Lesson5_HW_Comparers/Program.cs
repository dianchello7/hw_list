using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5_HW_Comparers
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Avi", "Aginch", 34));
            students.Add(new Student("Noz", "Hajaj", 44));
            students.Add(new Student("Peter", "Parker", 99));
            students.Add(new Student("Elios", "Wizeman", 56));
            students.Add(new Student("Ivan", "Bolvan", 83));
            students.Add(new Student("Anton", "Goodmen", 62));

            students.Sort();
            students.Sort(new SortStudentsByLastName());
            students.Sort(new SortStudentsByGrade());


            List<TemperatureMeasurments> measurments = new List<TemperatureMeasurments>();

            measurments.Add(new TemperatureMeasurments("Bat Yam", new DateTime(2021, 8, 10), 37.4, 70));
            measurments.Add(new TemperatureMeasurments("Jerusalem", new DateTime(2021, 8, 3), 29.34, 35.5));
            measurments.Add(new TemperatureMeasurments("Rishon Lezion", new DateTime(2021, 8, 12), 38, 70.2));
            measurments.Add(new TemperatureMeasurments("Tzfat", new DateTime(2021, 8, 23), 28.5, 66.8));
            measurments.Add(new TemperatureMeasurments("Ber Yaakov", new DateTime(2021, 8, 10), 37.4, 70));
            measurments.Add(new TemperatureMeasurments("Ashdod", new DateTime(2021, 8, 11), 28.7, 40));

            measurments.Sort();
            measurments.Sort(new SortMeasurmentsByCity());
            measurments.Sort(new SortMeasurmentsByCityOrDate());
            measurments.Sort(new SortMeasurmentsByTempOrCity());



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
