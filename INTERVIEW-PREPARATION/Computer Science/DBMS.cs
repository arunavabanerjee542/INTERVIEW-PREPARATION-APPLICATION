using INTERVIEW_PREPARATION.Repositories;
using INTERVIEW_PREPARATION.Services;

namespace INTERVIEW_PREPARATION
{
    public  class DBMS: CSE
    {
        public DBMS()
        {
        }

        public override string ToString()
        {

            return "DBMS";

        }

        public int Start()
        {
            System.Console.WriteLine(" START DBMS QUIZ ");

            IQuestion questions = new DbmsQuestion();

            int marks = questions.StartPrepration();

            System.Console.WriteLine(marks);
            return marks;

        }


        public void AddQuestion()
        {
            IQuestion q = new DbmsQuestion();
            q.AddQuestions();
        }





    }





}