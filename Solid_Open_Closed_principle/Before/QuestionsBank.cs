using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Closed_principle.Before
{
    internal static class QuestionsBank
    {
        public static List<Question> GenerateQuestions()
        {
            return new List<Question>() {
                new Question()
                {
                    Title = "What are the four pillars of OOP?",
                    questionType = QuestionType.WH,
                    Mark = 8
                },
                new Question()
                {
                    Title = "Which of the following are value types?",
                    questionType = QuestionType.MULTIPLECHOICE,
                    Mark = 6,
                    Choices = new List<string>
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: LOng"
                    }
                    
                },
                new Question() 
                {
                    Title = "Earth is bigger than sun?",
                    questionType = QuestionType.TRUEFALSE,
                    Mark = 4

                },
                new Question()
                {
                     Title = "Which of the following is an 8-bytes Integer?",
                    questionType = QuestionType.MULTIPLECHOICE,
                    Mark = 6,
                    Choices = new List<string>
                    {
                        "A: Char",
                        "B: Byte",
                        "C: String",
                        "D: Long",
                        "E: Short"
                    }
                }
            
            
            };
        }
    }
}
