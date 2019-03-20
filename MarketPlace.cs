using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceCadets
{
    class MarketPlace
    {

        public void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tWelcome to the Market"); /// TODO: add something with more imagination later
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=====================================================");
            Console.WriteLine("=====================================================\n\n");
        }
        public void ChoiceMenu()
        {
            Greeting();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tYou can do one of four things:\n" +
                              "\n\t1) Buy Something" +
                              "\n\t2) Sell Something" +
                              "\n\t3) Stand around and be ackward" +
                              "\n\t4) Leave -- although technically you aren't doing that HERE, ");
            Console.WriteLine("\t            it's more of a transitory process that begins here,");
            Console.WriteLine("\t            but if you do choose that option know that we are excited");
            Console.WriteLine("\t            excited to be the start of that new journey in your life.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nOh mighty Space Trader please honor us with your selection: ");

        }



        private void BuyItemsMenu(List<Tuple<string, int, double>> buy)
        {
            int i = 0;
            ConsoleKeyInfo userInput = Console.ReadKey();
            switch (userInput.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 1;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 1;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[1].Item1} || Quantity: {buy[1].Item2} || Price: {buy[1].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 2;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[1].Item1} || Quantity: {buy[1].Item2} || Price: {buy[1].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 2;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[2].Item1} || Quantity: {buy[2].Item2} || Price: {buy[2].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 3;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[3].Item1} || Quantity: {buy[3].Item2} || Price: {buy[3].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 3;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave");
                    i = 4;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    Console.WriteLine($"Item: {buy[0].Item1} || Quantity: {buy[0].Item2} || Price: {buy[0].Item3}\n");
                    Console.WriteLine("1) Purchase");
                    Console.WriteLine("2) Leave [Escape]");
                    i = 4;
                    BuyChoiceSelection(buy, i);
                    break;
                case ConsoleKey.Escape:
                    break;
            }
        }
        /// <summary>
        /// TODO: Update account and Inventory
        /// </summary>
        /// <param name="sell"></param>


        private void BuyChoiceSelection(List<Tuple<string, int, double>> sell, int i)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            switch (userInput.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Enter Qty to purchase: \n");
                    int qtyToPurchase = Console.Read();
                    double price = qtyToPurchase * sell[i].Item3;
                    Console.WriteLine($"That will cost {price:C}");
                    Console.WriteLine("Do you wish to complete the purchase?\n");
                    Console.WriteLine("1) Yes");/// update bank account and inventory
                    Console.WriteLine("2) No"); /// leave
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.Write("Enter Qty to purchase: \n");
                    int qtyToPurchase_ = Console.Read();
                    double price_ = qtyToPurchase_ * sell[i].Item3;
                    Console.WriteLine($"That will cost {price_:C}");
                    Console.WriteLine("Do you wish to complete the purchase?\n");
                    Console.WriteLine("1) Yes");/// update bank account and inventory
                    Console.WriteLine("2) No"); /// leave
                    break;
                case ConsoleKey.Escape:
                    break;
            }
        }
    }
}