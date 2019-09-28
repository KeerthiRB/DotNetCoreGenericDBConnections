using DomainObjects;
using PrimaryPort;
using SecondaryPort;
using System;
using System.Collections.Generic;

namespace HospitalCore
{
    public class TestCoreClass: ITestCoreClass
    {
        ITestClass TestClass = null;
        public TestCoreClass(ITestClass testClass)
        {
            TestClass = testClass;
        }
        public List<TestModel> GetFootBallPoints()
        {
           return TestClass.GetPointTable();
        }
    }
}
