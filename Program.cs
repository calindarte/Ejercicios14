using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppG02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.SetCursorPosition(20, 4); Console.Write("Digite un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(20, 6); Console.Write("Digite un numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(20, 8); Console.Write("Digite un numero: ");
            n3 = int.Parse(Console.ReadLine());

            if ((n1 > n2) && (n2 > n3))
            {
                Console.SetCursorPosition(20, 10); Console.WriteLine("Orden: " + n1 + " - " + n2 + " - "+n3);
            }
            else if ((n1>n3) && (n3>n2))
            {
                Console.SetCursorPosition(20, 10); Console.WriteLine("Orden: "+n1+" - "+n3+" - "+n2);
            }
            else if ((n2>n1)&&(n1>n3))
            {
                Console.SetCursorPosition(20, 10); Console.WriteLine("Orden: "+n2+" - "+n1+" - "+n3);
            }
            else if ((n2>n3)&&(n3>n1))
            {
                Console.SetCursorPosition(20, 10); Console.WriteLine("Orden: "+n2+" - "+n3+" - "+n1);
            }
            else if ((n3>n1) &&(n1>n2))
            {
                Console.SetCursorPosition(20, 10); Console.WriteLine("Orden: "+n3+" - "+n1+" - "+n2);
            }
            else
            {
                Console.SetCursorPosition(20, 10); Console.WriteLine("Orden: "+n3+" - "+n2+" - "+n1);
            }
        }
    }
}
