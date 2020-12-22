using INTERVIEW_PREPARATION.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION.Services
{
    class AdministratorControls : StartPreparation,IAdministratorControls
    {
        public void AddQuestion()
        {
  Console.WriteLine(" Enter the Department where you want to add the Question");

            dynamic dept = GetDept();

            Console.WriteLine(" ENTER THE SUBJECT IN WHICH YOU WANT YOU WANT TO ADD QUESTIONS ");

            dynamic sub = GetPrefferedSubject(dept);

            sub.AddQuestion();



            
        }
    }
}
