using DataAccessFactories;
using FinanceSystem;
using HospitalCore;
using Microsoft.Extensions.DependencyInjection;
using PrimaryPort;
using SecondaryPort;
using System;

namespace DependencyResolver
{
    public static class ResolveDependency
    {
        public static void Resolve(IServiceCollection services)
        {
            services.AddTransient<ITestClass, TestClass>();
            services.AddTransient<ITestCoreClass, TestCoreClass>();
            services.AddTransient<IDBManager, DBManager>();
            services.AddTransient<IPatientInfo,PatientInfo>();
            services.AddTransient<IPatientCore, PatientCore>();
            services.AddTransient<IPatientInfo, PatientInfo>();
        }
    }
}
