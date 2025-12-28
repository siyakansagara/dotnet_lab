using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Employee
    {
        String name;
        int age;
        int salary;
        public void getInfo(string name)
        {
            this.name = name;
        }
        public void getInfo(String name, int age) 
        {
            this.name = name;
            this .age = age;
        }
        public void getInfo(String name, int age , int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Name is :" +name);
            Console.WriteLine("age is :" + age);
            Console.WriteLine("salary is :" + salary);
        }
    }
}
