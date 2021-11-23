using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HW_Comparers
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Student(){}

        public Student(string fName, string lName, int grade)
        {
            FirstName = fName;
            LastName = lName;
            Grade = grade;
        }

        public int CompareTo(Student other)
        {
            if(this.LastName == other.LastName)
            {
                if (this.FirstName == other.FirstName)
                {
                    return (this.Grade.CompareTo(other.Grade)) * -1;
                }
                return this.FirstName.CompareTo(other.FirstName);
            }
            return this.LastName.CompareTo(other.LastName);
        }
    }


    public class SortStudentsByLastName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }

    public class SortStudentsByGrade : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (x.Grade.CompareTo(y.Grade)) * -1;
        }
    }
}
