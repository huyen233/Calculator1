using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void SetUp()
        {
        ;
        }
        [TestMethod]
        public void TestMethod1()
        {
           
        }
        public void THVoSoNghiem()
        {
            /*
             * *input 0 0
             * *output : VSN
             * */
            SimpleEquation s = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", s.SingleEquation());
        }
        private void THVoNghiem()
        {
            SimpleEquation se = new SimpleEquation()
        }
        public void THMotNghiem()
        {
        SimpleEquation s = new SimpleEquation(2, 1);
        Assert.AreEqual("-0.5", s.SingleEquation());
        }

        internal class SimpleEquation
        {
            public SimpleEquation()
            {
            }

            public SimpleEquation(int v1, int v2)
            {
            }
        }

        internal class Se
    {
    }
}
