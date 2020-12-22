using INTERVIEW_PREPARATION.Repositories;
using INTERVIEW_PREPARATION.Services;

namespace INTERVIEW_PREPARATION
{
    public class OperatingSystems : CSE
    {
        public OperatingSystems()
        {

          

        }

       

       

        public override string ToString()
        {

            return "OPERATING SYSTEMS"; 

        }



        public  int Start()
        {
            System.Console.WriteLine(" START OPERATING SYSTEM QUIZ ");
            IQuestion ques = new OperatingSystemsQuestions();

            int marks = ques.StartPrepration();

            System.Console.WriteLine(marks);

            return marks;


        }

        public void AddQuestion()
        {
            IQuestion q = new OperatingSystemsQuestions();
            q.AddQuestions();
        }





    }
}