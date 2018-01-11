using System;
using System.Collections.Generic;

namespace bangazon
    {
public class Department 
        {
            private string _name; 
            private string _supervisor; 
            private int _employeeCount;

            public Department (string name, string supervisor, int employees){
                _name = name; 
                _supervisor = supervisor; 
                _employeeCount = employees;
            }
        }
    }