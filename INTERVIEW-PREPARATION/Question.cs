using System;

namespace INTERVIEW_PREPARATION
{
   public class Question
    {

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