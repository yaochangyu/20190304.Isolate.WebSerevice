using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab.DAL.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 調用簽核狀態_預期得到成功()
        {
            var repository = new ApproveRepository();
            var status = repository.GetStatus();
            Assert.AreEqual("成功",status);
        }
    }
}
