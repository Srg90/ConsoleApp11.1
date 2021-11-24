using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Решите линейное уравнение вида Y = ax + b");
                Console.WriteLine();
                Console.Write("Задайте вещественное значение А = ");
                double a = double.Parse(Console.ReadLine());
                //Console.WriteLine();
                Console.Write("Задайте вещественное значение B = ");
                double b = double.Parse(Console.ReadLine());

                Task11 var1 = new Task11(a, b);
                var1.root();

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();



        }
    }

    public struct Task11
    {
        public double a;
        public double b;

        public Task11(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void root()
        {
            if (this.a != 0 & this.b != 0)
            {
                double Y = -this.b / this.a;
                Console.WriteLine();
                Console.WriteLine("Корень линейного уравнения x = {0}", Math.Round(Y, 2));
            }
            if (this.a == 0 & this.b != 0)
            {
                double Y = -this.b / this.a;
                Console.WriteLine();
                Console.WriteLine("Ошибка! Попытка деления на ноль!");
            }
            if (this.a == 0 & this.b == 0)
            {
                double Y = -this.b / this.a;
                Console.WriteLine();
                Console.WriteLine("Ошибка! Деление 0 на 0 !");
            }
            if (this.b == 0 & this.a != 0)
            {
                double Y = -this.b / this.a;
                Console.WriteLine();
                Console.WriteLine("Корень линейного уравнения x = {0}", Math.Round(Y, 2));
                Console.WriteLine("Деление 0 на число всегда дает 0 !");
            }
        }

    }
}

    
