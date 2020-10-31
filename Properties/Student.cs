using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3.Properties
{
    class Student
    {
        string name;

        string id;

        string department;

        float cgpa;
        public string getName()
        {
            return name;
        }
        public void setName(String Name)
        {
            name = Name;
        }
        public string getId()
        {
            return id;
        }
        public void setId(String Id)
        {
            id = Id;
        }
        public string getdept()
        {
            return department;
        }
        public void setDepartment(String Department)
            
        {
            department= Department;
        }
        public float getCgpa()
        {
            return cgpa;
        }
        public void setCgpa(float Cgpa)
        {
            cgpa = Cgpa;
                
        }


        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("CGPA : " + cgpa);

        }

    }
}
