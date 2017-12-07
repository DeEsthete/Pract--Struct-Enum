using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_StructEnum
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacanci { get; set; }
        public int Sallary { get; set; }
        public int[] EmploymentDate { get; set; }

        public Employee(string name, Vacancies vacanci, int sallary, int[] employmentDate)
        {
            Name = name;
            Vacanci = vacanci;
            Sallary = sallary;
            EmploymentDate = new int[3];
            for (int i = 0; i < EmploymentDate.Length; i++)
            {
                EmploymentDate[i] = employmentDate[i];
            }
        }
    }
}
