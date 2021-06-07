using System;

namespace First_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = DateTime.Now;
            string name = Environment.UserName;
            Console.WriteLine("Привет," + (name));
            Console.WriteLine("Сегодня" + (data1));
        }
    }
}
