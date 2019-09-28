using DomainObjects;
using PrimaryPort;
using SecondaryPort;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalCore
{
    public class PatientCore:IPatientCore
    {
        IPatientInfo _patientInfo;
        public PatientCore(IPatientInfo patientInfo)
        {
            _patientInfo = patientInfo;
        }

        public PatientObject GetPatient(string PID)
        {
            return _patientInfo.GetPatient(PID);
        }
    }
}
