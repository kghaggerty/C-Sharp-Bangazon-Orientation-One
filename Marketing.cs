using System;
using System.Collections.Generic;

namespace bangazon
{

    public class Marketing : Department
    {
        //Create new dictionary to store policies
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public Marketing(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
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

        public override string Meet()
        {
            return "Our Meeting Area is in on the roof";
        }
    }
}