using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //int,decimal,float,enum,booelan value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;

            //arrays,class,interface  reference types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 100;

            Console.WriteLine("Sayılar1[0]" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";

            //Person1 ve Person2 isimleri aynıdır çünkü referans numaraları ile bellekte aynı yere gider (Adres Eşitlemesi)

            Customer customer = new Customer();
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //Inheritance yaptığımız için sorun çıkmadı
            Person person3 = customer;
            customer.FirstName = "Salih";
            Console.WriteLine(person3.FirstName);

            //Customerdaki creditcardnumbera ulaşmak için boxing yapılır
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();

            personManager.Add(person3);

            personManager.Add(employee);

            personManager.Add(customer);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }

    //BASE CLASS = PERSON CLASSIDIR.
    class Customer : Person
    {

        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {

        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        //İstediğimiz zaman hem employee,hem müsteri, hem de person ile calısmak icin base classı parametre verdik
        public void Add(Person person)
        {

            Console.WriteLine(person.FirstName);

        }


    }





}
