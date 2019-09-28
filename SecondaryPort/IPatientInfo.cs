using DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondaryPort
{
    public interface IPatientInfo
    {
        PatientObject GetPatient(string PID);
    }
}
