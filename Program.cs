using System;
using System.Collections.Generic;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HumanResources Humanz = new HumanResources("Bangazon", "Steve", 3);
            Humanz.AddPolicy("first policy", "super cool");
            Marketing Marketz = new Marketing("Market Team", "Kevin", 1);
            Marketz.AddPolicy("Marketing policy", "Very neat!");
            Finance Financing = new Finance("Finance department", "Jared", 2);
            Financing.AddPolicy("Jared's Mandatory policy", "This is mandatory");

            List<Department> DepartmentList = new List<Department>();
            DepartmentList.Add(Humanz);
            DepartmentList.Add(Marketz);
            DepartmentList.Add(Financing);
            
            foreach(Department D in DepartmentList){
                Console.WriteLine(D);
            }

            string MeetFunctionHr = Humanz.Meet();
            Console.WriteLine("Human Resources: {0}", MeetFunctionHr);

            string MeetFunctionMarketing = Marketz.Meet();
            Console.WriteLine("Marketing: {0}", MeetFunctionMarketing);

            string MeetFunctionFinance = Financing.Meet();
            Console.WriteLine("Finance: {0}", MeetFunctionFinance);

        }
    }
}
