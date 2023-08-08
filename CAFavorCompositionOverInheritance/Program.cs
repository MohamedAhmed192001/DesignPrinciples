
using System.Xml.Schema;

namespace DesignPrinciples.CAFavorCompositionOverInheritance
{
    class prgram
    {

        static void Main(string[] args)
        {
            var choice = 0;
            Pizza pizza = new Pizza();
            do
            {
                Console.Clear();
                choice = ReadChoice(choice);
                if (choice >= 1 && choice <= 7)
                {
                    ITopping topping = null;
                    switch(choice)
                    {
                        case 1:
                            topping = new Chichen();
                            break;
                        case 2:
                            topping = new Vegeterian();
                            break;
                        case 3:
                            topping = new Mexican();
                            break;
                        case 4:
                            topping = new Tomato();
                            break;
                        case 5:
                            topping = new Cheese();
                            break;
                        case 6:
                            topping = new BlackOlive();
                            break;
                        case 7:
                            topping = new GreenPaper();
                            break;
                        default:
                            break;
                    }
                    pizza.AddTopping(topping);
                    Console.WriteLine("Press any key to continue... (0 to exist)");
                }
            } while (choice != 0);
            Console.WriteLine(pizza);
            Console.ReadKey();
        }

        public static int ReadChoice(int choice)
        {
            Console.WriteLine("Available toppings...");
            Console.WriteLine("--------------");
            Console.WriteLine("1- Chichen");
            Console.WriteLine("2- Vegeterian");
            Console.WriteLine("3- Mexican");
            Console.WriteLine("4- Tomato");
            Console.WriteLine("5- Cheese");
            Console.WriteLine("6- BlackOlive");
            Console.WriteLine("7- GreenPaper");

            Console.WriteLine("Select a topping (0 to finish):");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;

            }
            return choice;
        }
        //public static Pizza CreatePizza(int choice)
        //{
            
        //}
    
    }

    
    class Pizza
    {
        public virtual decimal Price => 10m;

        public List<ITopping> toppings = new List<ITopping>();
        public void AddTopping(ITopping topping) => toppings.Add(topping);

        public decimal Calculate()
        {
            var total = Price;
            foreach (var topping in toppings)
            {
                total += topping.Price;
            }
            return total;
        }

        public override string ToString()
        {
            var output = $"\n{nameof(Pizza)}";
            output += $"\n\t Base price: {Price.ToString("C")}";
            foreach (var topping in toppings)
            {
                output += $"\n\t {topping.Title} ({topping.Price.ToString("C")})";
            }
            output += "\n\t-----------------------";
            output += $"\n\tTotal price: {Calculate().ToString("C")}";
            return output;
        }
    }


    public interface ITopping
    {
        string Title { get; }
        decimal Price { get; }
    }

    public class Chichen : ITopping
    {
        public string Title => nameof(Chichen);

        public decimal Price => 6m;
    }

    public class Vegeterian : ITopping
    {
        public string Title => nameof(Vegeterian);

        public decimal Price => 3m;
    }

    public class Mexican : ITopping
    {
        public string Title => nameof(Mexican);

        public decimal Price => 3m;
    }


    public class Tomato : ITopping
    {
        public string Title => nameof(Tomato);

        public decimal Price => 3m;
    }

    public class Cheese : ITopping
    {
        public string Title => nameof(Cheese);

        public decimal Price => 2m;
    }



    public class BlackOlive : ITopping
    {
        public string Title => nameof(BlackOlive);

        public decimal Price => 4m;
    }

    public class GreenPaper : ITopping
    {
        public string Title => nameof(GreenPaper);

        public decimal Price => 2.5m;
    }

}



    


