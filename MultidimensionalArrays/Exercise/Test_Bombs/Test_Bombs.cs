using NUnit.Framework;
using System;
using System.Collections.Generic;
using Bombs;

namespace Test_Bombs
{
    public class Tests
    {
        public int[][] matrix;

        [SetUp]
        public void Setup()
        {
            matrix[0][0] = 8; matrix[0][1] = 3; matrix[0][2] = 2; matrix[0][3] = 5;
            matrix[1][0] = 6; matrix[1][1] = 4; matrix[1][2] = 7; matrix[1][3] = 9;
            matrix[2][0] = 9; matrix[2][1] = 9; matrix[2][2] = 3; matrix[2][3] = 6;
            matrix[3][0] = 6; matrix[3][1] = 8; matrix[3][2] = 1; matrix[3][3] = 2;
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Bombs.Program.BombCell(0, 1, 5), -2);
        };
        Assert.Pass();
        }
}
}