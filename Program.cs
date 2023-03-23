namespace PizzaOrderingSystem;
class Program
{
    static int pizTypeLoopCheck = 1;
    static string pizzaType = "";

    static int pizSizeLoopCheck = 1;
    static string pizzaSize = "";
    static void Main(string[] args)
    {
        Console.WriteLine("Its Pizza Time! Press any key to continue");
        Console.ReadKey(true);
        PizzaType();
        PizzaSize();
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
                pizTypeLoopCheck = 0;
            }
            else if(pizzaTypeInput == "Sweet" || pizzaTypeInput == "sweet" || pizzaTypeInput == "SWEET")
            {
                pizzaType = "sweet";
                pizTypeLoopCheck = 0;
            }
            else
            {
                Console.WriteLine("Error, invalid input");
            }
        }
    }
    static void PizzaSize()
    {
        string pizzaSizeInput = "";
        while(pizSizeLoopCheck == 1)
        {
            Console.WriteLine("Please select your pizza size: Small, Medium or Large?");
            pizzaSizeInput = Console.ReadLine();
            if(pizzaSizeInput == "Small" || pizzaSizeInput == "small" || pizzaSizeInput == "SMALL")
            {
                pizzaSize = "small";
                pizSizeLoopCheck = 0;
            }
            else if(pizzaSizeInput == "Medium" || pizzaSizeInput == "medium" || pizzaSizeInput == "MEDIUM")
            {
                pizzaSize = "medium";
                pizSizeLoopCheck = 0;
            }
            else if(pizzaSizeInput == "Large" || pizzaSizeInput == "large" || pizzaSizeInput == "LARGE")
            {
                pizzaSize = "large";
                pizSizeLoopCheck = 0;
            }
            else
            {
                Console.WriteLine("Error, invalid input");
            }
        }
    }

}
