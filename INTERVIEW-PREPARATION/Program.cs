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

            List<Participant> plist = new List<Participant>();

            IStartPreparation start = new StartPreparation();

            Console.WriteLine(" TO START YOUR PREPARATION ENTER ---> 1 ");
            Console.WriteLine(" ADMINISTRATOR SERVICES ENTER 2 ----> 2");

            int choice = 0;


            while (1 == 1)
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("INVALID CHOICE");
                }

                if (choice > 0 && choice <= 2)
                {
                    break;
                }

            }



            while (1 == 1)
            {
                switch (choice)
                {
                    case 1:
                        {
                            start.StatrPrep(plist);

                            foreach (var x in plist)
                            {
                                Console.WriteLine("ID---> " + x.id + " " + " NAME--> " + x.name + " " +
                                 " DEPARTMENT ---> " + x.dept.ToString() + " " + " SUBJECT ---> " + x.subject + " " + " MARKS OBTAINED ---> " + x.MarksObtained);

                            }


                        }
                        break;




                    case 2:
                        break;


                }

            }

            



               }


        }
    }

