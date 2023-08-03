using SpecFlowDatabaseTesting.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDatabaseTesting.Utils
{
    internal interface IWorldDatabase
    {
        List<City> GetAll();


    }
}
