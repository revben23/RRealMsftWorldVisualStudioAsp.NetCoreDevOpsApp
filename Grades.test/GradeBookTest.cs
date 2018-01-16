using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Text;
using LearningCSharp;

namespace Grades.test
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            var result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);

        }
        [TestMethod]
        public void ComputesLowestGrade()
        {
            var book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            var result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);

        }
        [TestMethod]
        public void ComputesAverageGrade()
        {
            var book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            var result = book.ComputeStatistics();
            //Assert.AreEqual(85.1666666667f, result.AverageGrade);
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);

        }
    }   
}
