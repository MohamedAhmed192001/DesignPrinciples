using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Closed_principle.After
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
                q.Print();
                Console.WriteLine("\n\n");
            }
            
        }
    }
}
