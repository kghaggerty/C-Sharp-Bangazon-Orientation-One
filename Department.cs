using System;
using System.Collections.Generic;

namespace bangazon
    {
public class Department 
        {
            protected string _name; 
            protected string _supervisor; 
            protected int _employeeCount;

            public Department (string name, string supervisor, int employees){
                _name = name; 
                _supervisor = supervisor; 
                _employeeCount = employees;
            }

            List<Department> DepartmentList = new List<Department>();
        }
    }