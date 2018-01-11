using System;
using System.Collections.Generic;

namespace bangazon
{

    public class HumanResources : Department
    {
        //Create new dictionary to store policies
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public HumanResources(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {

        }
        //Add some policies
        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Key}", $"{policy.Value}");
            }
        }

        public string toString()
        {
            return $"{_name} {_supervisor} {_employeeCount}";
        }

        public override string Meet()
        {
            return "Our Meeting Area is in the basement";
            
        }

    }
}