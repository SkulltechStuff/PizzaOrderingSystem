namespace PizzaOrderingSystem;
class Program
{
    static int pizTypeLoopCheck = 1;
    static string pizzaType = "";
    static int pizSizeLoopCheck = 1;
    static string pizzaSize = "";
    static int pizCrustLoopCheck = 1;
    static string crustType = "";
    static int pizSauceLoopCheck = 1;
    static string pizzaSauce = "";
    static int pizTopLoopCheck = 1;
    static int continueLoopCheck = 1;
    static List<string> pizzaToppings = new List<string>();
    static void Main(string[] args)
    {
        Console.WriteLine("Its Pizza Time! Press any key to continue");
        Console.ReadKey(true);
        PizzaType();
        PizzaSize();
        CrustType();
        PizzaSauce();
        PizzaToppings();
        PizzaDetails();
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
                pizzaType = "Savoury";
                pizTypeLoopCheck = 0;
            }
            else if(pizzaTypeInput == "Sweet" || pizzaTypeInput == "sweet" || pizzaTypeInput == "SWEET")
            {
                pizzaType = "Sweet";
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
                pizzaSize = "Small";
                pizSizeLoopCheck = 0;
            }
            else if(pizzaSizeInput == "Medium" || pizzaSizeInput == "medium" || pizzaSizeInput == "MEDIUM")
            {
                pizzaSize = "Medium";
                pizSizeLoopCheck = 0;
            }
            else if(pizzaSizeInput == "Large" || pizzaSizeInput == "large" || pizzaSizeInput == "LARGE")
            {
                pizzaSize = "Large";
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
                crustType = "Classic";
                pizCrustLoopCheck = 0;
            }
            else if(crustTypeInput == "Thin" || crustTypeInput == "thin" || crustTypeInput == "THIN")
            {
                crustType = "Thin";
                pizCrustLoopCheck = 0;
            }
            else if(crustTypeInput == "Thick" || crustTypeInput == "thick" || crustTypeInput == "THICK")
            {
                crustType = "Thick";
                pizCrustLoopCheck = 0;
            }
            else if(crustTypeInput == "Stuffed" || crustTypeInput == "stuffed" || crustTypeInput == "STUFFED")
            {
                crustType = "Stuffed";
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
        if(pizzaType == "Savoury")
        {
            while(pizSauceLoopCheck == 1)
            {
                Console.WriteLine("Please select your sauce type: Tomato, BBQ, or Ranch?");
                pizzaSauceInput = Console.ReadLine();
                if(pizzaSauceInput == "Tomato" || pizzaSauceInput == "tomato" || pizzaSauceInput == "TOMATO")
                {
                    pizzaSauce = "Tomato";
                    pizSauceLoopCheck = 0;
                }
                else if(pizzaSauceInput == "Bbq" || pizzaSauceInput == "bbq" || pizzaSauceInput == "BBQ")
                {
                    pizzaSauce = "BBQ";
                    pizSauceLoopCheck = 0;
                }
                else if(pizzaSauceInput == "Ranch" || pizzaSauceInput == "ranch" || pizzaSauceInput == "RANCH")
                {
                    pizzaSauce = "Ranch";
                    pizSauceLoopCheck = 0;
                }
                else
                {
                    Console.WriteLine("Error, invalid input");
                } 
            }
        }
        else
        {
            while(pizSauceLoopCheck == 1)
            {
                Console.WriteLine("Please select your chocolate sauce type: White, Milk, or Dark?");
                pizzaSauceInput = Console.ReadLine();
                if(pizzaSauceInput == "White" || pizzaSauceInput == "white" || pizzaSauceInput == "WHITE")
                {
                    pizzaSauce = "White Choc";
                    pizSauceLoopCheck = 0;
                }
                else if(pizzaSauceInput == "Milk" || pizzaSauceInput == "milk" || pizzaSauceInput == "MILK")
                {
                    pizzaSauce = "Milk Choc";
                    pizSauceLoopCheck = 0;
                }
                else if(pizzaSauceInput == "Dark" || pizzaSauceInput == "dark" || pizzaSauceInput == "DARK")
                {
                    pizzaSauce = "Dark Choc";
                    pizSauceLoopCheck = 0;
                }
                else
                {
                    Console.WriteLine("Error, invalid input");
                } 
            }
        }
    }
    static void PizzaToppings()
    {
        string pizTopInput = "";
        string continueProgram = "";
        while(pizTopLoopCheck == 1)
        {
            continueLoopCheck = 1;
            if(pizzaType == "savoury")
            {
                Console.WriteLine("Please choose from the available toppings: Anchovies, Bell Peppers, Chicken, Ham, Jalapenos, Meatballs, Mozzarella, Mushrooms, Pepperoni, Pineapple, Sweetcorn");
                pizTopInput = Console.ReadLine();
                if(pizTopInput == "Anchovies" || pizTopInput == "anchovies" || pizTopInput == "ANCHOVIES")
                {
                    pizzaToppings.Add("Anchovies");
                }
                else if(pizTopInput == "Bell Peppers" || pizTopInput == "bell peppers" || pizTopInput == "Bell Peppers")
                {
                    pizzaToppings.Add("Bell Peppers");
                }
                else if(pizTopInput == "Chicken" || pizTopInput == "chicken" || pizTopInput == "CHICKEN")
                {
                    pizzaToppings.Add("Chicken");
                }
                else if(pizTopInput == "Ham" || pizTopInput == "ham" || pizTopInput == "HAM")
                {
                    pizzaToppings.Add("Ham");
                }
                else if(pizTopInput == "Jalapenos" || pizTopInput == "jalapenos" || pizTopInput == "JALAPENOS")
                {
                    pizzaToppings.Add("Jalopenos");
                }
                else if(pizTopInput == "Meatballs" || pizTopInput == "meatballs" || pizTopInput == "MEATBALLS")
                {
                    pizzaToppings.Add("Meatballs");
                }
                else if(pizTopInput == "Mozzarella" || pizTopInput == "mozzarella" || pizTopInput == "MOZZARELLA")
                {
                    pizzaToppings.Add("Mozzarella");
                }
                else if(pizTopInput == "Mushrooms" || pizTopInput == "mushrooms" || pizTopInput == "MUSHROOMS")
                {
                    pizzaToppings.Add("Mushrooms");
                }
                else if(pizTopInput == "Pepperoni" || pizTopInput == "pepperoni" || pizTopInput == "PEPPERONI")
                {
                    pizzaToppings.Add("Pepperoni");
                }
                else if(pizTopInput == "Pineapple" || pizTopInput == "pineapple" || pizTopInput == "PINEAPPLE")
                {
                    pizzaToppings.Add("Pineapple");
                }
                else if(pizTopInput == "Sweetcorn" || pizTopInput == "sweetcorn" || pizTopInput == "SWEETCORN")
                {
                    pizzaToppings.Add("Sweetcorn");
                }
                else
                {
                    Console.WriteLine("Error, invalid input");
                } 
            }
            else
            {
                Console.WriteLine("Please choose from the available toppings: Candy Corn, M&Ms, Marshmallow, Nuts, Oreo, Skittles, Strawberries");
                pizTopInput = Console.ReadLine();
                if(pizTopInput == "Candy Corn" || pizTopInput == "candy corn" || pizTopInput == "CANDY CORN")
                {
                    pizzaToppings.Add("Candy Corn");
                }
                else if(pizTopInput == "M&Ms" || pizTopInput == "m&ms" || pizTopInput == "M&MS")
                {
                    pizzaToppings.Add("M&Ms");
                }
                else if(pizTopInput == "Marshmallow" || pizTopInput == "marshmallow" || pizTopInput == "MARSHMALLOW")
                {
                    pizzaToppings.Add("Marshmallow");
                }
                else if(pizTopInput == "Nuts" || pizTopInput == "nuts" || pizTopInput == "NUTS")
                {
                    pizzaToppings.Add("Nuts");
                }
                else if(pizTopInput == "Oreo" || pizTopInput == "oreo" || pizTopInput == "OREO")
                {
                    pizzaToppings.Add("Oreo");
                }
                else if(pizTopInput == "Skittles" || pizTopInput == "skittles" || pizTopInput == "SKITTLES")
                {
                    pizzaToppings.Add("Skittles");
                }
                else if(pizTopInput == "Strawberries" || pizTopInput == "strawberries" || pizTopInput == "STRAWBERRIES")
                {
                    pizzaToppings.Add("Strawberries");
                }
                else
                {
                    Console.WriteLine("Error, invalid input");
                }
            }
            while(continueLoopCheck == 1)
            {
                Console.WriteLine("Do you want any more toppings?");
                continueProgram = Console.ReadLine();
                if(continueProgram == "no" || continueProgram == "n")
                {
                    pizTopLoopCheck = 0;
                    continueLoopCheck = 0;
                }
                else if (continueProgram == "yes" || continueProgram == "y")
                {
                    continueLoopCheck = 0;
                }
                else
                {
                    Console.WriteLine("Error, invalid input");
                }
            }
        }
    }
    static void PizzaDetails()
    {
        Console.WriteLine($"Pizza Type: {pizzaType}");
        Console.WriteLine($"Pizza Size: {pizzaSize}");
        Console.WriteLine($"Crust Type: {crustType}");
        Console.WriteLine($"Pizza Sauce: {pizzaSauce}");
        Console.WriteLine($"Pizza Toppings: {PizzaToppingList()}");
    }

    static string PizzaToppingList()
        {
            string toppingsFinal = "";
            foreach(string topping in pizzaToppings)
            {
                toppingsFinal += topping + ", ";
            }

            toppingsFinal = toppingsFinal.Substring(0, toppingsFinal.Length - 2);
            return toppingsFinal;
        }
}