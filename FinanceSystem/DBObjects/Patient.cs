using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSystem.DBObjects
{
    class Patient
    {
        public Int64 id { get; set; } 
        public string pid { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string middle_name { get; set; }
        public DateTime? dob { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string marital_status { get; set; }
        public bool is_alive { get; set; }
        public string contact_number { get; set; }
        public string conatct_email { get; set; }
        public string alternative_number { get; set; }
        public string alternative_email { get; set; }
        public int identity_id { get; set; }
        public string identity_number { get; set; }
        public DateTime? dod { get; set; }
        public int group { get; set; }
        public int sub_group { get; set; }
        public int created_by { get; set; }        
        public DateTime created_date_time { get; set; }
        public int updated_by { get; set; }
        public DateTime update_date_time { get; set; }
    }
}
