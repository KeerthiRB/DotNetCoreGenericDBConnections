using DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaryPort
{
    public interface IPatientCore
    {
        PatientObject GetPatient(string PID);

    }
}
