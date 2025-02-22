namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
            Console.WriteLine("Price per small carpet is 25$");
            Console.WriteLine("Price per large carpet 35$");
            Console.WriteLine("Sales tax rate is 6%");

            Console.WriteLine("Enter Number of small carpets");
            int smallCarpetNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of large carpets");
            int largeCarpetNum = Convert.ToInt32(Console.ReadLine());

            int smallCarpetPrice = smallCarpetNum * 25;
            int largeCarpetPrice = largeCarpetNum * 35;
            int totalCarpetPrice = smallCarpetPrice + largeCarpetPrice; 
            Console.WriteLine($"Total price is {totalCarpetPrice}");

            double taxCost = 6.6 + totalCarpetPrice;
            Console.WriteLine(taxCost);





        }
    }
}
