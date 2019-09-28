using DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondaryPort
{
    public interface ITestClass
    {
        List<TestModel> GetPointTable();
    }
}
