namespace PizzaOrderingSystem;
class Program
{
    static int pizTypeLoopCheck = 1;
    static string pizzaType = "";
    static int pizSizeLoopCheck = 1;
    static string pizzaSize = "";
    static int pizCrustLoopCheck = 1;
    static string crustType = "";
    static void Main(string[] args)
    {
        Console.WriteLine("Its Pizza Time! Press any key to continue");
        Console.ReadKey(true);
        PizzaType();
        PizzaSize();
        CrustType();
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
    static void CrustType()
    {
        string crustTypeInput = "";
        while(pizCrustLoopCheck == 1)
        {
            Console.WriteLine("Please select your crust type: Classic, Thin, Thick or Stuffed?");
            crustTypeInput = Console.ReadLine();
            if(crustTypeInput == "Classic" || crustTypeInput == "classic" || crustTypeInput == "CLASSIC")
            {
                crustType = "classic";
                pizCrustLoopCheck = 0;
            }
            else if(crustTypeInput == "Thin" || crustTypeInput == "thin" || crustTypeInput == "THIN")
            {
                crustType = "thin";
                pizCrustLoopCheck = 0;
            }
            else if(crustTypeInput == "Thick" || crustTypeInput == "thick" || crustTypeInput == "THICK")
            {
                crustType = "thick";
                pizCrustLoopCheck = 0;
            }
            else if(crustTypeInput == "Stuffed" || crustTypeInput == "stuffed" || crustTypeInput == "STUFFED")
            {
                crustType = "stuffed";
                pizCrustLoopCheck = 0;
            }
            else
            {
                Console.WriteLine("Error, invalid input");
            }
        }
    }
    static void PizzaSauce()
    {
        string pizzaSauceInput = "";
        if(pizzaType == "savoury")
        {

        }
        else
        {
            
        }
    }

}
