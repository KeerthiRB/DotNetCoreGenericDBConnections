using DataAccessFactories;
using DomainObjects;
using FinanceSystem.DBObjects;
using FinanceSystem.Extention;
using SecondaryPort;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinanceSystem
{
    public class PatientInfo : IPatientInfo
    {
        IDBManager DBManager = null;
        public PatientInfo(IDBManager dBManager)
        {
            DBManager = dBManager;
        }
        public PatientObject GetPatient(string PID)
        {
            IDbConnection connection = null;
            PatientObject patientObject = new PatientObject();
           var dataReader= DBManager.SetUpDataBase("FinanceSytem").GetDataReader("SSP_GetPatient", System.Data.CommandType.StoredProcedure, new List<IDbDataParameter> { DBManager.CreateParameter("@PID",PID,DbType.String) }.ToArray(),out connection);
            try
            {
                while (dataReader.Read())
                {
                    patientObject.ID = (Int64)dataReader["id"];
                    patientObject.PID = dataReader["pid"].ToString();
                    patientObject.FirstName = dataReader["first_name"].ToString();
                    patientObject.LastName = dataReader["last_name"].ToString();
                    patientObject.MiddleName = dataReader["middle_name"].ToString();
                    patientObject.DOB = (DateTime)dataReader["dob"];
                    patientObject.Age = (int)dataReader["age"];
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                dataReader.Close();
                connection.Close();
            }
            //return patientObject;
            return DBManager.SetUpDataBase("FinanceSytem").GetDataTable("SSP_GetPatient", System.Data.CommandType.StoredProcedure, new List<IDbDataParameter> { DBManager.CreateParameter("@PID", PID, DbType.String) }.ToArray()).ToList<Patient>().FirstOrDefault().BussinessPatientObject();
        }
    }
}
