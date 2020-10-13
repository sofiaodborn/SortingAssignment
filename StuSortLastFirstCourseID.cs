using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    class StuSortLastFirstCourseID : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            int compareValue = x.LastName.ToUpper().CompareTo(y.LastName.ToUpper());

            if (compareValue == 0)
            {
                compareValue = x.FirstName.ToUpper().CompareTo(y.FirstName.ToUpper());
                if (compareValue == 0)
                {
                    compareValue = x.CourseID.ToUpper().CompareTo(y.CourseID.ToUpper());
                }
            }
            return compareValue;
        }
    }
}
