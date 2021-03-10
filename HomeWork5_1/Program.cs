using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HomeWork5_1
{
    class Program
    {

        static void Main(string[] args)
        {
        
            var InputText = Console.ReadLine();
            File.WriteAllLines("Homework5.1.txt", new[] { InputText });


        }
    } 
}
