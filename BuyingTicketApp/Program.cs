namespace BuyingTicketApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int tickets = 0;
            string input = "";

            while (tickets <=0)
            {
                try
                {
                    Console.WriteLine("How many tickets would you like to purchase?");
                    input = Console.ReadLine();
                    tickets = Int32.Parse(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number");

                }

            }

            Console.Clear();

            if (tickets == 1)
            {
             Console.WriteLine($"You have just purchased {input} ticket!");
            }
            else
            {
                Console.WriteLine($"You have just purchased {input} tickets!");
            }
            
            
        }
    }
}