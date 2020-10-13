using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    class Student : IComparable<Student>
    {

        public Student(int studentid, string lastname, string firstname, string courseid, double coursegrade)
        {
            StudentID = studentid;
            LastName = lastname;
            FirstName = firstname;
            CourseID = courseid;
            CourseGrade = coursegrade;
        }
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CourseID { get; set; }
        public double CourseGrade { get; set; }


        public static List<Student> getTestStudents()
        {
            // For testing purposes some duplicate student infomation will be used.

            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Jones", "Joan", "art0024", 3.0));
            students.Add(new Student(2, "Einstein", "Jose", "math0001", 3.3));
            students.Add(new Student(5, "Gonzales", "Miranda", "cs0024", 2.7));
            students.Add(new Student(4, "Lee", "Kim", "bs0024", 2.7));
            students.Add(new Student(3, "Jaspers", "Rachel", "cs0001", 2.7));
            students.Add(new Student(6, "gates", "Bill", "cs0001", 4.0));
            students.Add(new Student(6, "Gates", "Bill", "art0024", 3.0));
            students.Add(new Student(6, "Gates", "bill", "art0024", 1.0));
            students.Add(new Student(7, "Allison", "George", "math0023", 2.7));
            students.Add(new Student(7, "Allison", "Alice", "cs0001", 2.7));
            students.Add(new Student(8, "Sills", "Carol", "cs0001", 1.7));
            students.Add(new Student(8, "Sills", "Albert", "cs0001", 2.7));
            students.Add(new Student(9, "Starr", "Bert", "chem0020", 3.7));
            return students;
        }

        public override string ToString()
        {
            return $"{StudentID, -15} {LastName, -20} {FirstName, -20} {CourseID, -10} {CourseGrade, -5}";
        }

        public static string ColumnHeader()
        {
            return $"{"StudentID",-15} {"LastName",-20} {"FirstName",-20} {"CourseID",-10} {"CourseGrade",-5}" +
                $"{"\n=========",-16} {"========",-20} {"=========",-20} {"========",-10} {"===========",-5}";
        }

        public static string SortTitle(string sortTitle)
        {
            return $"Sort Type: {sortTitle}";
        }

        public int CompareTo(Student other)
        {
            int compareValue = LastName.ToUpper().CompareTo(other.LastName.ToUpper());

            if (compareValue == 0)
            {
                compareValue = FirstName.ToUpper().CompareTo(other.FirstName.ToUpper());               
            }
            return compareValue;
        }

        
    }
}
