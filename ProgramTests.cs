using Microsoft.VisualStudio.TestTools.UnitTesting;
using a;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void addTest()
        {
            int x = 3;
            int y = 4;
            int res = a.Program.add(x, y);
            Assert.AreEqual(7, res);
        }
    }
}