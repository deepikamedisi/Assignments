using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Customer

    {
        int Customerid;
        string Name;
        int Age;
        double Phone;
        string City;
        public Customer()
        {
            Console.WriteLine(" enter the customer ID");
            this.Customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name");
            this.Name = Console.ReadLine();
            Console.WriteLine("enter the age");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the phone");
            this.Phone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the city");
            this.City = Console.ReadLine();

        }
        public Customer(int Customer_id, string Name, int age, double phone, string city)
        {
            this.Customerid = Customer_id;
            this.Name = Name;
            this.Age = age;
            this.Phone = phone;
            this.City = city;
        }
        public void display(Customer ob)
        {

            Console.WriteLine($"{ob.Customerid}\t\t\t{ob.Name}\t{ob.Age}\t\t{ob.Phone}\t\t{ob.City}");
        }
        public static void Main(string[] args)
        {
            Customer d1 = new Customer();
            Customer d2 = new Customer(2, "maneesha", 22, 9379349288,"Hyd");

            Console.WriteLine("CUSTOMER_ID\t\tNAME\t\tAGE\t\tPHONE_NO\t\tCITY");
            d1.display(d1);
            d2.display(d2);

            Console.Read();
        }
    }
}

    

