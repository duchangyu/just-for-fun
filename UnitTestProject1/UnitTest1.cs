using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Solution.Solution sln = new Solution.Solution();

            int[] A = {9,4,-3,-10};
            Assert.AreEqual(3, sln.solution(A));

            int[] B = { };
            Assert.AreEqual(-1, sln.solution(B));
        }


        [TestMethod]
        public void TestMethod2()
        {

            Solution.Solution sln = new Solution.Solution();

            Assert.AreEqual(0, sln.solution_Task2(""));

            Assert.AreEqual(1, sln.solution_Task2("d"));

            Assert.AreEqual(1, sln.solution_Task2("as"));

            Assert.AreEqual(1, sln.solution_Task2("aassaa"));

            Assert.AreEqual(1, sln.solution_Task2("dooernedeevrvn"));

            Assert.AreEqual(0, sln.solution_Task2("aabcba"));
        }

    }
}
