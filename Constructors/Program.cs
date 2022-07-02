using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        { //Constructor=Bir class'ı newlediğimiz zaman çalışan bloktur.

            Customer customer = new Customer { Id = 1, FirstName = "Sabit", LastName = "Ünsür", City = "Ankara" };


            //Bu kullanım için yapıcı metoda paramtere olarak verilmesi gerekir.
            Customer customer1 = new Customer(2, "Ege", "Ünsür", "Ankara");

            Console.WriteLine(customer1.City);

        }
    }

    class Customer
    {

        //İkisinin de çalışabilmesi için bu şekilde yazılması gerekti.
        public Customer()
        {

        }

        //Newleme yapıldığında otomatik bu constructor çalışıyordur arka planda
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            //Constructor haricinde Console.WriteLine ile yazılması istenen şeyin gözükmesi için arkaplanda eşitleme yapılır.
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

            // Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }


}
