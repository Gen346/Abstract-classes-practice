using Лабораторна_робота_6;


internal class Program
{

    private static void Main(string[] args)
    {
        var coordinates = Building.GetCordinates();
        int left = coordinates.Item1;
        int top = coordinates.Item2;

        Building dome = new Dome(left, top);
        Building tower = new Tower(left, top + 7);

        while (true)
        {
            Console.WriteLine("1. Show palace");
            Console.WriteLine("0. Exit");

            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Console.Clear();
                    dome.Draw(left, top);
                    tower.Draw(left, top + 7);
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choise!");
                    break;

            }
        }
    }
}