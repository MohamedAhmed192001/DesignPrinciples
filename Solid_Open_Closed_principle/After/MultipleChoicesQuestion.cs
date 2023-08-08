namespace SOLID_Open_Closed_principle.After
{
    class MultipleChoicesQuestion : Question
    {
        public List<string> Choices { get; set; } = new List<string>();
        public override void Print()
        {
            Console.WriteLine($"{Title}  [{Mark}]");
            foreach (var choice in Choices)
            {
                Console.WriteLine($"  {choice}");
            }
        }
    }
}


