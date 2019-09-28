using DomainObjects;
using FinanceSystem.DBObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSystem.Extention
{
   static class DBToBussiness
    {
        public static PatientObject BussinessPatientObject(this Patient p)
        {
            return new PatientObject
            {
                ID = p.id,
                PID = p.pid,
                FirstName = p.first_name,
                LastName = p.last_name,
                MiddleName = p.middle_name,
                Age = p.age
            };
        }
    }
}
