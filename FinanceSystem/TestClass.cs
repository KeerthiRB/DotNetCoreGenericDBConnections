using DataAccessFactories;
using DomainObjects;
using SecondaryPort;
using System;
using System.Collections.Generic;

namespace FinanceSystem
{
    public class TestClass:ITestClass
    {
        IDBManager DBManager = null;
        public TestClass(IDBManager dBManager)
        {
            DBManager = dBManager;
        }
        public List<TestModel> GetPointTable()
        {
            
           return DBManager.SetUpDataBase("FootBall").GetDataSet("SSP_GetScore_Bord", System.Data.CommandType.StoredProcedure).Tables[0].ToList<TestModel>();
           
        }
    }
}
