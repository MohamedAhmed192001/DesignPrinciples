
using Encapsulate_what_varies;

namespace DesignPrinciples.EncapculateWhatVaries
{
    class prgram
    {

        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaConstants.CheesePizza);
            Console.WriteLine(pizza);
        }

    }


    class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        public static Pizza Create(string type)
        {
            Pizza pizza;
            if (type.Equals(PizzaConstants.CheesePizza))
                pizza = new Cheese();
            else if (type.Equals(PizzaConstants.VegeterianPizza))
                pizza = new Vegeterian();

            else
                pizza = new Chicken();

            return pizza;
        }

        public static Pizza Order(string type)
        {
            Pizza pizza = Create(type);
            Prepare();
            Cook();
            Cut();
            return pizza;
        }
        public static void Prepare()
        {
            Console.Write("Preparing.....");
            Thread.Sleep(500);
            Console.WriteLine(" Completed");
        }
        public static void Cook()
        {
            Console.Write("Cooking.....");
            Thread.Sleep(500);
            Console.WriteLine(" Completed");
        }
        public static void Cut()
        {
            Console.Write("Cutting and Boxing.....");
            Thread.Sleep(500);
            Console.WriteLine(" Completed");
        }

        public override string ToString()
        {
            return $"\n{Title}" +
                $"\n\tPrice: {Price.ToString("C")}";
        }
    }


    class Cheese : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Cheese)}";
        public override decimal Price => base.Price + 3m;
    }

    class Chicken : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}";
        public override decimal Price => base.Price + 6m;
    }

    class Vegeterian : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Vegeterian)}";
        public override decimal Price => base.Price + 4m;
    }
}



