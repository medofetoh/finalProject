using System;

namespace finalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To try simple level enter 1 ,to try lists enter 2 , to try work with json enter 3");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num == 1) {
                var proj1 = new Task1();
                proj1.DoAction();
            }
             else if (num == 2)
            {

                var proj2 = new Task2();
                proj2.DoAction();
            }

            else { 
            var proj3 = new Task3();
            proj3.DoAction();
        }
        }
    }
}
