namespace Лабораторна_робота_6
{
    internal class Dome : Building
    {
        public Dome(int left, int top) : base(left, top) { }
        //В С# можно наследовать классы, но нельзя наследовать конструкторы.
        //При этом можно сделать ссылку на базовый конструктор с помощью слова base. 
        public override void Draw(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            //10 spaces("          ")
            Console.WriteLine("    @                                         @    ");
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine("   @@@                                       @@@   ");
            Console.SetCursorPosition(left, top + 2);
            Console.WriteLine("   @@@                                       @@@   ");
            Console.SetCursorPosition(left, top + 3);
            Console.WriteLine("   @@@                                       @@@   ");
            Console.SetCursorPosition(left, top + 4);
            Console.WriteLine("   @@@                                       @@@   ");
            Console.SetCursorPosition(left, top + 5);
            Console.WriteLine("  @@@@@          @@             @@          @@@@@  ");
            Console.SetCursorPosition(left, top + 6);
            Console.WriteLine("  @@@@@         @@@@           @@@@         @@@@@  ");
            Console.SetCursorPosition(left, top + 7);
            Console.WriteLine(" @@@@@@@      @@@@@@@@       @@@@@@@@      @@@@@@@ ");
            Console.SetCursorPosition(left, top + 8);
            Console.WriteLine("@@@@@@@@@   @@@@@@@@@@@@   @@@@@@@@@@@@   @@@@@@@@@");
            Console.SetCursorPosition(left, top + 9);
            Console.WriteLine("@@@@@@@@@   @@@@@@@@@@@@   @@@@@@@@@@@@   @@@@@@@@@");
            Console.SetCursorPosition(left, top + 10);
            Console.WriteLine("  @@@@@     @@@@@@@@@@@@   @@@@@@@@@@@@     @@@@@  ");
            Console.SetCursorPosition(left, top + 11);
            Console.WriteLine("  @@@@@      @@@@@@@@@@     @@@@@@@@@@      @@@@@  ");
            Console.SetCursorPosition(left, top + 12);
            Console.WriteLine("  @@@@@       @@@@@@@@       @@@@@@@@       @@@@@  ");
        }

    }
}
