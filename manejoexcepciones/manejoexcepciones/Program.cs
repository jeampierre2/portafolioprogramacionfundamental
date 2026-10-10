using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejoexcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("coloque una cantidad");
                int cantidad = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("error del formato");
            }
            finally
            {
                Console.WriteLine("fin del prorama");
            }
        }
    }
}