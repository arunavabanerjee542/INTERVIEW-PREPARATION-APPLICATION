using INTERVIEW_PREPARATION.Electrical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
  

    class EEE : Department
    {

        List<Department> EEEsub;


        public override List<Department> GetDepartmentWiseSubjects()
        {
            EEEsub = new List<Department>() 
            {
                new DigitalElectronics(), new Microprocessor()
            };

            return EEEsub;


        }






    }

   

}
