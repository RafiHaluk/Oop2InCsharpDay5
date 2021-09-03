using System;
using System.Collections.Generic;

namespace Oop2InCsharpDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Individual individual = new Individual();
            individual.ID = "41703099";
            individual.Individual_Social_Number = "25120035558";
            individual.Individual_Name = "Rafi Haluk";
            individual.Individual_LastName = "DEDE";
            
            
            Corporate corporate = new Corporate();
            corporate.ID = "74522144";
            corporate.Corporate_Name = "RONIC BESİN A.Ş";
            corporate.Corporate_Address = "konmaz mahallesi 92. sokak numara 3 MASLAK/İSTANBUL";
            corporate.Corporate_TaxNumber = "65111238541";

            Corporate corporate1 = new Corporate();
            corporate1.ID = "9565114";
            corporate1.Corporate_Name = "HERBLİFE BESİN A.Ş";
            corporate1.Corporate_Address = "okul sokak no 32 daire 3 BAYRAMPAŞA/İSTANBUL";
            corporate1.Corporate_TaxNumber = null;

            //Gerçek Muşteri - Tüzel Müşteri olmak üzere iki tane nesnem var, ancak farklı tiplerde özellikleri var ve birbirinin yerine kullanılamazlar...
            //SOLID solıd's L  sırf birbirine benziyor diye inheritance yapmamak..

            //Customers individualX = new Corporate();
            //Customers corporateX = new Corporate();

            Customer_Operations customer_Operations = new Customer_Operations();
            customer_Operations.Add_Individual(individual);
            customer_Operations.Add_Corporate(corporate);
            customer_Operations.Add_Corporate(corporate1);
            

        }
    }
}
