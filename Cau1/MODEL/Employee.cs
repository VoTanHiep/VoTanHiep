using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intuit.Ipp.Data;

namespace Cau1.MODEL
{
    public class Employee
    {
        public String IdEmployee { set; get; }
        public String Name { set; get; }
        public DateTime DateBirth { set; get; }
        public String Gender { set; get; }
        public String PlaceBirth { set; get; }
        public Department Department { get; set; }

        public String Depart
        {
            get
            {
                return Department.Name_Department;
            }


        }
    }
}
