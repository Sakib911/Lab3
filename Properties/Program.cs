using LAB3.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setName("Sakib");
            s1.setCgpa(3);
            s1.setDepartment("CSE");
            s1.setId("19-39426-1");
            s1.ShowInfo();
            Console.WriteLine();
            Triangle t1 = new Triangle();
            t1.setX(4);
            t1.setY(5);
            t1.setZ(4);
            t1.TestTriangle();
            Course c1 = new Course();
            c1.setCourseName("OOP2");
            c1.setCourseCode("1145");
            c1.setCourseCredit(3);
            
            Account a1 = new Account();
            a1.setBalance(5000);
            a1.setAccName("sakib");
            a1.setAcid("325");
            a1.Deposit(5000);
            Console.WriteLine(a1.getBalance());

            a1.withdraw(3000);
            Console.WriteLine(a1.getBalance());



        }

    }
}
