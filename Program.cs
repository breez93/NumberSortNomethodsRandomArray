using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberSortRandomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 10; x++)
            {
                int[] numerosAleatorios = new int[DevolveArray()];

                for (int countX = 0; countX < numerosAleatorios.Length; countX++)
                {
                    int temp;
                    for (int countY = 0 + 1; countY < numerosAleatorios.Length; countY++)
                    {
                        if (countX > countY)
                        {
                            temp = countY;
                            countY = countX;
                            countX = temp;
                        }
                    }
                    Console.WriteLine(countX);
                        
                }
            }
            
            
            int DevolveArray()
            {
                Random numerosAleatorios = new Random();
                numerosAleatorios.Next();
                return Convert.ToInt32(numerosAleatorios);
            }

        }

    }
}
