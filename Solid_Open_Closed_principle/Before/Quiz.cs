using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Closed_principle.Before
{
    internal class Quiz
    {
        public List<Question> questions = new List<Question>();

        public Quiz(List<Question> questions)
        {
            this.questions = questions;
        }

        public void Print()
        {
            foreach (Question q in questions)
            {
                Console.WriteLine($"{q.Title}  [{q.Mark}]");
                switch (q.questionType)
                {
                    case QuestionType.WH:
                        Console.WriteLine("  --------------------------------");
                        Console.WriteLine("  --------------------------------");
                        Console.WriteLine("  --------------------------------");
                        Console.WriteLine("  --------------------------------");
                        break;

                    case QuestionType.TRUEFALSE:
                        Console.WriteLine("  1. T");
                        Console.WriteLine("  2. F");
                        break;

                    case QuestionType.MULTIPLECHOICE:
                        foreach (var choice in q.Choices)
                        {
                            Console.WriteLine($"  {choice}");
                        }
                        break;


                    default:
                        break;
                }

                Console.WriteLine("\n\n");
            }
            
        }
    }
}
