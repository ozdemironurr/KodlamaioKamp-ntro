using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CustomerManager:Customer
    {
        public void Add() { Console.WriteLine("Customer added!"); }
        public void Update() { Console.WriteLine("Customer updated!"); }
    }
}
