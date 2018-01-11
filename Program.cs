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
        }
    }
}
