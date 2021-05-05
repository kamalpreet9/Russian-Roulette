using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Russian_Roulette;
namespace Russian_Roulette_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        GameClass Obj_GameLogic = new GameClass();
        [TestMethod]
        public void TestMethod1()
        {
            int rand_num = Obj_GameLogic.Rand_number();
            Assert.IsTrue(rand_num > 0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int rand_num = Obj_GameLogic.Rand_number();
            Assert.IsTrue(rand_num < 7);
        }
    }
}
