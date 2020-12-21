using INTERVIEW_PREPARATION.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION.Services
{
    class DbmsQuestion : IQuestion
    {
        int marks = 0;

        public int StartPrepration()
        {

            Question.SetQuestions(" 1>> A logical schema ");
            Question.SetOptions("Is the entire database.",
                "describe data in terms of relational tables and columns, object-oriented classes, and XML tags.",
                "Describes how data is actually stored on disk.", " BOTH Aand B");

            int choice = Question.IsValidChoice();

            if (Question.IsValidAnswer(choice, 1))
            {
                Console.WriteLine("CORRECT ANSWER ");
                marks++;
            }
            else
            {
                Console.WriteLine(" WRONG ANSWER ");
            }





            Question.SetQuestions(" Related fields in a database are grouped to form a ");
            Question.SetOptions("	Data file.",
                "Data record", "Menu", "Bank");



             choice = Question.IsValidChoice();

            if (Question.IsValidAnswer(choice, 2))
            {
                Console.WriteLine("CORRECT ANSWER ");
                marks++;
            }
            else
            {
                Console.WriteLine(" WRONG ANSWER ");
            }






            Question.SetQuestions(" The way a particular application views the data from the database that the application uses is a");
            Question.SetOptions("Module.",
               "Relational model.",
                "Schema", " Sub Schema");

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


            Question.SetQuestions(" What are the different view to present a Table ? ");
            Question.SetOptions("Datasheet View",
                "Pivote TableView", "Design View", "All Of Above");



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
