using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
   public class Department 
    {


        /*
        public virtual CSE GetSubjects(string name)
        {
            return null;  // dummy method to call child class method
        }

    */

        public virtual List<Department> GetDepartmentWiseSubjects()
        {
            return null;  // dummy method to call child class method
        }

        public virtual void  StartQuiz(Department d , string s)
        {
            Console.WriteLine("QUIZ STARTED");
        }




        public Department GetDepartment(string deptname)
        {
            if(deptname.Equals("CSE"))
            {
                return new CSE();
            }
            else if (deptname.Equals("ECE"))
            {
                return new ECE();
            }
            else
            {
                return new EEE();
            }


        }
    }
}
