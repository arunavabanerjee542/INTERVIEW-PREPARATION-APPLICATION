using INTERVIEW_PREPARATION.Repositories;
using INTERVIEW_PREPARATION.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEW_PREPARATION
{
    class Administrator : Person
    {
        IAdministratorControls admin;

        public void AddQuestions()
        {
            admin = new AdministratorControls();
            admin.AddQuestion();
        }

    }
}
