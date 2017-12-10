using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tests
{
    [TestClass()]
    public class ConnectDBTests
    {
        ConnectDB cdb = new ConnectDB();
        [TestMethod()]
        public void GetConnectTest()
        {
            try
            {
                cdb.GetConnect();
            }
            catch(Exception e)
            {
               
            }
        }
    }
}