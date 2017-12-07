using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_StructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayDate = new int[3];
            arrayDate[0] = 21;
            arrayDate[1] = 11;
            arrayDate[2] = 12;
            Employee person = new Employee("LEHA", Vacancies.Manager, 2000, arrayDate);
            Console.WriteLine("Name; " + person.Name + " Vacancies; " + person.Vacanci + " Sallary; " + person.Sallary + " Employment date; " + person.EmploymentDate[0] + "." +  person.EmploymentDate[1] + "." + person.EmploymentDate[2]);
            Console.ReadLine();
        }
    }
}
