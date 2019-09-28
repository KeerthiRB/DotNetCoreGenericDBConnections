using System;
using System.Collections.Generic;
using System.Text;

namespace DomainObjects
{
    public class PatientObject
    {
        public Int64 ID { get; set; }
        public string PID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string MaritalStatus { get; set; }
        public bool isAlive { get; set; }
        public string ContactNumber { get; set; }
        public string ConatctEmail { get; set; }
        public string AlternativeNumber { get; set; }
        public string AlternativeEmail { get; set; }
        public int IdentityId { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime DOD { get; set; }
        public int Group { get; set; }
        public int SubGroup { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
