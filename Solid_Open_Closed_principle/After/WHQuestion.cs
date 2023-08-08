namespace SOLID_Open_Closed_principle.After
{
    class WHQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title}  [{Mark}]");
            Console.WriteLine("  --------------------------------");
            Console.WriteLine("  --------------------------------");
            Console.WriteLine("  --------------------------------");
            Console.WriteLine("  --------------------------------");
        }
    }

}
