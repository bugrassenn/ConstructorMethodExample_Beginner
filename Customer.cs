using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodExample
{
    internal class Customer
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Job;
        public int Age;


        public Customer(int id, string firstName, string lastName, string job, int age)
        {
            Console.WriteLine("Constructor method working"); // sadece bu kısım ekrana basılır

            // sınıftakilerle eşleştirme yaparak main kısımda  id firstname... çağırımı yapabiliriz.
            // eğer eşitleme yapmazsak bize değer dönmezler. ekrana basılmaz.
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Job = job;
            Age = age;
        }
    }
}
