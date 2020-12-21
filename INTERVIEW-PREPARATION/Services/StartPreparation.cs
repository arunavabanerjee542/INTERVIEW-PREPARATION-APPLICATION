using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
    class StartPreparation : IStartPreparation
    {
       dynamic x;

        public void StatrPrep(List<Participant> plist)
        {
            Console.WriteLine(" ENTER PARTICIPANT NAME ");
            string name = Console.ReadLine();
            Console.WriteLine(" ENTER YOUR ID ");
            int id = GetId();
            dynamic department = GetDept();
            dynamic subject = GetPrefferedSubject(department);
            string sub = subject.ToString();

            Console.WriteLine(subject);

          int marks = subject.Start();

            Participant p = new Participant(name,id,department,sub,marks);

            plist.Add(p);




           

        }

        public int GetId()
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(" INVALIUD OPTION ");
                GetId();
            }
            return id;
        }


        public dynamic GetDept()
        {
           // Department d = new Department();

            Console.WriteLine(" Enter Your Department ");
            Console.WriteLine(" 1--> CSE "); 
            Console.WriteLine(" 2--> EEE ");
            Console.WriteLine(" 3--> ECE ");

            int c = 0;

            try
            {
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(" INVALID INPUT ");
                GetDept();
            }

           
        if(c==1)
            {
                return x = new CSE();
            }
        else if(c==2)
            {
                return x = new EEE();
            }
            else
            {
                return x = new ECE();
            }
           

        }



        public dynamic GetPrefferedSubject(dynamic d)
        {

            List<Department> dd = d.GetDepartmentWiseSubjects();

            int i = 0;
            foreach (var item in dd)
            {
                Console.WriteLine(i + " ----> " + item);
                i++;
            }

            Console.WriteLine(" Enter your preffered subject ");

            int c = 0;

            try
            {
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                GetPrefferedSubject(d);
            }

            var subject = dd[c];

            return subject;




        }
        








    }
}
