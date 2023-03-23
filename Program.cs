namespace PizzaOrderingSystem;
class Program
{
    static int pizTypeLoopCheck = 1;
    static string pizzaType = "";
    static void Main(string[] args)
    {
        Console.WriteLine("Its Pizza Time! Press any key to continue");
        Console.ReadKey(true);
        PizzaType();
        Console.WriteLine("Press any key to finish");
        Console.ReadKey(true);
    }

    static void PizzaType()
    {
        string pizzaTypeInput = "";
        while(pizTypeLoopCheck == 1)
        {
            Console.WriteLine("Please select your pizza type: Savoury or Sweet?");
            pizzaTypeInput = Console.ReadLine();
            if(pizzaTypeInput == "Savoury" || pizzaTypeInput == "savoury" || pizzaTypeInput == "SAVOURY")
            {
                pizzaType = "savoury";
                Console.WriteLine(pizzaType);
                pizTypeLoopCheck = 0;
            }
            else if(pizzaTypeInput == "Sweet" || pizzaTypeInput == "sweet" || pizzaTypeInput == "SWEET")
            {
                pizzaType = "sweet";
                Console.WriteLine(pizzaType);
                pizTypeLoopCheck = 0;
            }
            else
            {
                Console.WriteLine("Error, invalid input");
            }
        }
    }
}
