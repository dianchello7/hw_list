using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HW_Comparers
{
    public class TemperatureMeasurments : IComparable<TemperatureMeasurments>
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double DegInCelcius { get; set; }
        public double Moisture { get; set; }

        public TemperatureMeasurments(){}

        public TemperatureMeasurments(string city, DateTime date, double degInCelcius, double moisture)
        {
            City = city;
            Date = date;
            DegInCelcius = degInCelcius;
            Moisture = moisture;
        }

        public int CompareTo(TemperatureMeasurments other)
        {
            if (this.Moisture == other.Moisture)
            {
                if(this.DegInCelcius == other.DegInCelcius)
                {
                    return this.City.CompareTo(other.City);
                }
                return (this.DegInCelcius.CompareTo(other.DegInCelcius)) * -1;
            }
            return (this.Moisture.CompareTo(other.Moisture)) * -1;
        }
    }


    public class SortMeasurmentsByCity : IComparer<TemperatureMeasurments>
    {
        public int Compare(TemperatureMeasurments x, TemperatureMeasurments y)
        {
            return x.City.CompareTo(y.City);
        }
    }

    public class SortMeasurmentsByCityOrDate : IComparer<TemperatureMeasurments>
    {
        public int Compare(TemperatureMeasurments x, TemperatureMeasurments y)
        {
            if (x.City == y.City)
            {
                return x.Date.CompareTo(y.Date);
            }
            return x.City.CompareTo(y.City);
        }
    }

    public class SortMeasurmentsByTempOrCity : IComparer<TemperatureMeasurments>
    {
        public int Compare(TemperatureMeasurments x, TemperatureMeasurments y)
        {
            if (x.DegInCelcius == y.DegInCelcius)
            {
                return x.City.CompareTo(y.City);
            }
            return (x.DegInCelcius.CompareTo(y.DegInCelcius)) * -1;
        }
    }
}
