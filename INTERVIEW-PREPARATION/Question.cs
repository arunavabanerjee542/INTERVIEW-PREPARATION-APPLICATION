using System;

namespace INTERVIEW_PREPARATION
{
   public class Question
    {

        public string Qstring;
        public string op1;
        public string op2;
        public string op3;
        public string op4;
        public int answer;

        public Question(string Q ,string opt1, string opt2, string opt3,
            string opt4,int ans)
            {

            this.Qstring = Q;
            this.op1 = opt1;
            this.op2 = opt2;
            this.op3 = opt3;
            this.op4 = opt4;
            this.answer = ans;


        }


        public override string ToString()
        {
            return Qstring + "   " + op1 + " " + op2 + " " + op3 + " " + op4;
        }





        public static void SetQuestions(string m)
        {
            System.Console.WriteLine(m);
        }

       public static void SetOptions(string a, string b,string c,string d)
        {
            System.Console.WriteLine("1--> " +a);
            System.Console.WriteLine("2--> " + b);
            System.Console.WriteLine("3--> " + c);
            System.Console.WriteLine("4--> " + d);
        }

       public static int IsValidChoice()
        {

            int choice = 0;

            while (1 == 1)
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(" INVALID CHOICE ");
                    choice = 0;
                }
                if (choice > 0 && choice <= 4)
                {
                    break;
                }

            }

            return choice;




        }


        public static bool IsValidAnswer(int choice, int answer)
        {
            if(choice == answer)
            {
                return true;
            }

            Console.WriteLine(" SORRY CORRECTION ANSWER IS OPTION : "+ answer);
            return false;
        }




    }
}