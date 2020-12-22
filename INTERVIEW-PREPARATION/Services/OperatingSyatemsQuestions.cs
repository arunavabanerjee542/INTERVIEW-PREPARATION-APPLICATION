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
        static List<Question> os = new List<Question>();


        int marks=0;

       

        public int StartPrepration()
        {

            AddFewDummyQuestions();

            foreach(var qest in os)
            {
                Console.WriteLine(qest.Qstring);
                Console.WriteLine();
                Console.WriteLine(qest.op1);
                Console.WriteLine(qest.op2);
                Console.WriteLine(qest.op3);
                Console.WriteLine(qest.op4);

                int choice = Question.IsValidChoice();

                if (Question.IsValidAnswer(choice, qest.answer))
                {
                    Console.WriteLine("CORRECT ANSWER ");
                    marks++;
                }
                else
                {
                    Console.WriteLine(" WRONG ANSWER ");
                }


            }




            return marks;

        }  // start preparation




        public void AddQuestions()
        {
            Console.WriteLine(" Enter your question ");
            string ques = Console.ReadLine();
            Console.WriteLine(" ENTER 4 OPTIONS ");
            string o1 = Console.ReadLine();
            string o2 = Console.ReadLine();
            string o3 = Console.ReadLine();
            string o4 = Console.ReadLine();

            Console.WriteLine(" Enter answer ");
            int ans = Convert.ToInt32(Console.ReadLine());

            os.Add(new Question(ques, o1, o2, o3, o4, ans));




        }



        public void AddFewDummyQuestions()
        {
            string q;
            string o1;
            string o2;
            string o3;
            string o4;

            int ans;

            q = " When were MS windows operating systems proposed";

                o1 = "1984";
                o2 = "1987";
                o3 = "1478";
                o4 = "1889";

            ans = 1;

            Question qs1 = new Question(q, o1, o2, o3, o4, ans);
            os.Add(qs1);


            q = " When was the first operating system developed ? ";

            o1 = "1984";
            o2 = "1950";
            o3 = "1478";
            o4 = "1889";

            ans = 2;

            Question qs2 = new Question(q, o1, o2, o3, o4, ans);
            os.Add(qs2);









        }












    }
}
