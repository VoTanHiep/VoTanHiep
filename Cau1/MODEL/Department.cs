﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intuit.Ipp.Data;

namespace Cau1.MODEL
{
    public class Department
    {
        public List<Employee> Employees { get; set; }
        public int IdDepartment { set; get; }
        public String Name_Department { set; get; }
    }
}
