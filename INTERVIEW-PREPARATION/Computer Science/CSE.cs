using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
    public  class CSE : Department
    {
        List<Department> CSEsub;

/*
        public override void StartQuiz(Department d, string s)
        {
            if(s.Equals("Operating Systems"))
            {
                new OperatingSystems().Start();
            }
            else
            {
                new DBMS().Start();
            }
        }
*/

        public override List<Department> GetDepartmentWiseSubjects()
        {
            CSEsub = new List<Department>()
            {
                new OperatingSystems(), new DBMS()
            };

            return CSEsub;
        }




        public override string ToString()
        {
            return "CSE";
        }





    }




        
    
}
