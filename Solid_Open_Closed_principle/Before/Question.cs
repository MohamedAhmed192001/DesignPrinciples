using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Closed_principle.Before
{
    internal class Question
    {
        public string  Title { get; set; }
        public int Mark { get; set; }
        public QuestionType questionType { get; set; }
        public List<string> Choices { get; set; } = new List<string>();
    }
}
