using INTERVIEW_PREPARATION.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION.Services
{
    class OperatingSystemsQuestions : IQuestion
    {
        int marks=0;
        public int StartPrepration()
        {
            Question.SetQuestions("  Which of the following is not an operating system? ");
            Question.SetOptions("Windows.",
                "Linux",
                "Oracle", 
                "Dos");

            int choice = Question.IsValidChoice();

            if (Question.IsValidAnswer(choice, 3))
            {
                Console.WriteLine("CORRECT ANSWER ");
                marks++;
            }
            else
            {
                Console.WriteLine(" WRONG ANSWER ");
            }






            Question.SetQuestions(" What is the maximum length of the filename in DOS?");
            Question.SetOptions("4",
                "5",
                "8",
                "12");

            choice = Question.IsValidChoice();

            if (Question.IsValidAnswer(choice, 3))
            {
                Console.WriteLine("CORRECT ANSWER ");
                marks++;
            }
            else
            {
                Console.WriteLine(" WRONG ANSWER ");
            }




            Question.SetQuestions("When was the first operating system developed?");
            Question.SetOptions("1994",
                "1874",
                "1950",
                "1920");

            choice = Question.IsValidChoice();

            if (Question.IsValidAnswer(choice, 3))
            {
                Console.WriteLine("CORRECT ANSWER ");
                marks++;
            }
            else
            {
                Console.WriteLine(" WRONG ANSWER ");
            }



            Question.SetQuestions(" When were MS windows operating systems proposed");
            Question.SetOptions("1994",
                "1878",
                "1940",
                "1984");

            choice = Question.IsValidChoice();

            if (Question.IsValidAnswer(choice, 4))
            {
                Console.WriteLine("CORRECT ANSWER ");
                marks++;
            }
            else
            {
                Console.WriteLine(" WRONG ANSWER ");
            }





            return marks;













        }
    }
}
