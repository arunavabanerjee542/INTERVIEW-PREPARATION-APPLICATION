using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
    class Program
    {
        static void Main(string[] args)
        {

            Department dep = new Department();

            var x = dep.GetDepartment("CSE");

        var subject = x.GetSubjects("OS");

            subject.StartQuiz();

           




        }
    }
}
