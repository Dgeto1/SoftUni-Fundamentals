using System;

namespace rageExepnses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int countTrashHeadset = numberLostGames / 2;
            int countTrashMouse = numberLostGames / 3;
            int countTrashKeyboard = numberLostGames / 6;
            int countTrashDispaly = numberLostGames / 12;
            double finalPrice = countTrashHeadset * headsetPrice + countTrashMouse * mousePrice + countTrashKeyboard * keyboardPrice + countTrashDispaly*displayPrice;
            Console.WriteLine($"Rage expenses: {finalPrice:f2} lv.");
        }
    }
}

