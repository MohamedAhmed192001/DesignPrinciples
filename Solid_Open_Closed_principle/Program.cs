

//using System.Diagnostics.Metrics;


using SOLID_Open_Closed_principle.After;

namespace DesignPrinciples.SOLID_Open_Closed_Principle
{

    class prgram
    {

        static void Main(string[] args)
        {
            var quiz = new SOLID_Open_Closed_principle.After.Quiz(SOLID_Open_Closed_principle.After.QuestionsBank.GenerateQuestions());
            quiz.Print();
        }
    }
}
