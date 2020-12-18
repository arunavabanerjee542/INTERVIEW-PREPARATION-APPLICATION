using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
    public  class CSE : Department
    {

        public virtual void StartQuiz()
        {
            // dummy just to call the child class overriden method
        }
        
        
        public override CSE GetSubjects(string s)
        {
            if(s.Equals("OS"))
                {
                Console.WriteLine("hjasdhcvjkcbkjcvbwklvjc");
                return new OperatingSystems();
            }
            else
            {
                return new DBMS();
            }

        }




        
    }
}
