using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Alpaslan", "Şen", "Engineer", 25);


            // constructorda sınıftan eşitleme yaptığımız için customer.Id bize yukarıda girdiğimiz 1 i döner
            // FirstName ise bize Alpaslanı döner. eğer eşitleme yapmasaydık bize boş değer dönücekti.
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.FirstName);

            Console.Read();
        }
    }
}
