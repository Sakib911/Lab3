using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Course
    {
        String courseName;
        String courseCode;
        int courseCredit;
        public string getCourseName()
        {
            return courseName;
        }
        public void setCourseName(String CourseName)
        {
            courseName=CourseName;
        }

        public string getCourseCode()
        {
            return courseName;
        }
        public void setCourseCode(String CourseCode)
        {
            courseCode = CourseCode;
        }
        public int getCourseCredit()
        {
            return courseCredit;
        }
        public void setCourseCredit(int CourseCredit)
        {
            courseCredit = CourseCredit;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + courseName);
            Console.WriteLine("Code : " + courseCode);
            Console.WriteLine("Credit : " + courseCredit);
           
        }
    }
}
