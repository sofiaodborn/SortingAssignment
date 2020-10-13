using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.getTestStudents();

            Console.WriteLine(Student.SortTitle("Not Sorted"));
            Console.WriteLine(Student.ColumnHeader());

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }





            // Sort using built in Student IComparer default sort...
            Console.WriteLine(Student.SortTitle("Sorted by Last Name and First Name Using Built in IComparable"));
            
            Console.WriteLine(Student.ColumnHeader());

            students.Sort();
            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }





            Console.WriteLine(Student.SortTitle("Sorted by Course Grade, Last Name, and then First Name Using IComparer"));

            Console.WriteLine(Student.ColumnHeader());

            StuSortCourseGradeLastFirst stuSortCourseGradeLastFirst = new StuSortCourseGradeLastFirst();

            students.Sort(stuSortCourseGradeLastFirst);

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }





            Console.WriteLine(Student.SortTitle("Sorted by Last Name, First Name, and then CourseID Using IComparer"));

            Console.WriteLine(Student.ColumnHeader());

            StuSortLastFirstCourseID stuSortLastFirstCourseID = new StuSortLastFirstCourseID();

            students.Sort(stuSortLastFirstCourseID);

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }





            Console.WriteLine(Student.SortTitle("Sorted by Last Name, First Name, CourseID, and then CourseGrade Using IComparer"));

            Console.WriteLine(Student.ColumnHeader());

            StuSortLastFirstCourseIDCourseGrade stuSortLastFirstCourseIDCourseGrade = new StuSortLastFirstCourseIDCourseGrade();

            students.Sort(stuSortLastFirstCourseIDCourseGrade);

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }








            Console.WriteLine("\nPress <ENTER> to quit...");
            Console.ReadKey();
        }
    }
}
