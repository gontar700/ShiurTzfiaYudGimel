using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Objects;


namespace ShiurTzfiaYudGimel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            Book book = new Book("Katav Hazit", "Ron Ben Ishai", 455, 89.90);
            Console.WriteLine(book.GetPrice());
            book.ChangePrice(20);
            Console.WriteLine("Price increased in 20%");
            Console.WriteLine(book.GetPrice());
        }
    }
}
