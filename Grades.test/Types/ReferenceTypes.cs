﻿using LearningCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.test.Types
{   [TestClass]
    class TypesTest
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "revi";
            name = name.ToUpper();

            Assert.AreEqual("REVI", name);
        }

        [TestMethod]
        public void DateTimeTest()
        {
            DateTime date = new DateTime(2018, 1, 15);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }
        private void IncrementNumber( ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(ref book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }
        private void GiveBookAName( ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }


        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "Scott";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }


        [TestMethod]
        public void GradeBookVariableHodlingAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

           
            g1.Name = "Revi Bennett";
            Assert.AreEqual(g1.Name, g2);
        }
    }
}
