using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
    class Participant : Person
    {
        public Department dept;
        public string subject;
        public int MarksObtained;
        public int id;

        public Participant(string n,int ID,Department d,string sub,int marks)
        {
            name = n;
            id = ID;
            subject = sub;
            MarksObtained = marks;
            dept = d;
            
        }


    }
}
