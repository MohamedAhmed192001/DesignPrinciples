using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Closed_principle.After
{
    internal static class QuestionsBank
    {
        public static List<Question> GenerateQuestions()
        {
            return new List<Question>() {
                new WHQuestion()
                {
                    Title = "What are the four pillars of OOP?",
                    Mark = 8
                },
                new MultipleChoicesQuestion()
                {
                    Title = "Which of the following are value types?",
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
                new TrueFalseQuestion() 
                {
                    Title = "Earth is bigger than sun?",
                    Mark = 4

                },
                new MultipleChoicesQuestion()
                {
                    Title = "Which of the following is an 8-bytes Integer?",
                    Mark = 6,
                    Choices = new List<string>
                    {
                        "A: Char",
                        "B: Byte",
                        "C: String",
                        "D: Long",
                        "E: Short"
                    }
                },
                new MatchQuestion()
                {
                    Title = "Match column 1 value with single choice from 2nd column ",
                    Mark = 10,
                    Rows = new Dictionary<string, string> 
                    {
                        { "A","b" },
                        { "B","c" },
                        { "C","d" },
                        { "D","e" },
                        { "E","f" }
                    }
                }


            };
        }
    }
}
