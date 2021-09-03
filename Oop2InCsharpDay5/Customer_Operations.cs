using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2InCsharpDay5
{
    //manager ve operation sınıfları iş sınıflarıdır. burada kurallar olur
    class Customer_Operations
    {
        public void Add_Individual(Individual customer)
        {
            if (customer.ID == null || customer.Individual_LastName == null ||
                customer.Individual_Name == null || customer.Individual_Social_Number == null)
            {
                Console.WriteLine("Some attributes are missing, please check...");
            }
            else
            {
                List<string> list_of_individual = new List<string> {};
                list_of_individual.Add(customer.Individual_Name);
                Console.WriteLine(customer.Individual_Name+" successfully added.");
                
                foreach (var item in list_of_individual)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("***************");
            }
            
        }
        public void Add_Corporate(Corporate customer)
        {
            if (customer.ID == null || customer.Corporate_Name == null ||
                customer.Corporate_TaxNumber == null || customer.Corporate_Address == null)
            {
                Console.WriteLine("Some attributes are missing, please check...");
            }
            else
            {
                List<string> list_of_corporate = new List<string> { };
                list_of_corporate.Add(customer.Corporate_Name);
                Console.WriteLine(customer.Corporate_Name + " successfully added.");
                
                foreach (var item in list_of_corporate)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("***************");
            }
        }

    }
}
