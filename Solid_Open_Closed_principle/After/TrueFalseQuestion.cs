namespace SOLID_Open_Closed_principle.After
{
    class TrueFalseQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title}  [{Mark}]");
            Console.WriteLine("  1. T");
            Console.WriteLine("  2. F");
        }
    }

}


