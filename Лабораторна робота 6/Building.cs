using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing;
using System;

namespace Лабораторна_робота_6
{
    public abstract class Building(int left, int top)
    {
        private int _left { get; set; } = left;
        private int _top { get; set; } = top;

        public static (int, int) GetCordinates()
        {
            Console.WriteLine("Input your cordinate(it must be less, then 10)");
            string[] coordinates = Console.ReadLine().Split(' ');
            int left = int.Parse(coordinates[0]);
            if(left > 9)
            {
                Console.WriteLine("Maximum 9.\nLeft corner set to 9!");
                left = 9;
            }
            int top = int.Parse(coordinates[1]);
            if (top > 9)
            {
                Console.WriteLine("Maximum 9.\nTop set to 9!");
                top = 9;
            }
            return (left, top);
            //Нашёл на GitHub причину ошибки:
            //If I remember correctly this is due to the current implementation relying on the window position related Console API's for going to the next line.
            //But it didn't account for window position staying the same after hitting the buffer size.
            //So that error will pop up after ~3k lines have been written.
        }
        public abstract void Draw(int left, int top);
    }

}
