using NUnit.Framework;
using System;
using JaggedArrayManipulator;

namespace JaggedArrayManipulator_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_GetAnalyzedMethod()
        {
            int numberOfRows = 5;
            double[][] matrix = new double[numberOfRows][];
            matrix[0] = new double[] { 10, 20, 30 };
            matrix[1] = new double[] { 1, 2, 3 };
            matrix[2] = new double[] { 2 };
            matrix[3] = new double[] { 2 };
            matrix[4] = new double[] { 10, 10 };

            double[][] matrixAfterAnalyzing = new double[numberOfRows][];
            matrixAfterAnalyzing[0] = new double[] { 20, 40, 60 };
            matrixAfterAnalyzing[1] = new double[] { 1, 2, 3 };
            matrixAfterAnalyzing[2] = new double[] { 2 };
            matrixAfterAnalyzing[3] = new double[] { 2 };
            matrixAfterAnalyzing[4] = new double[] { 5, 5 };

            CollectionAssert.AreEqual(matrixAfterAnalyzing, Program.GetAnalyzedMatrix(matrix, numberOfRows));
        }
        [Test]
        public void Test_GetAnalyzedMethod_When_PassingEmptyArray()
        {
            double[][] matrix = new double[0][];

            double[][] matrixAfterAnalyzing = new double[0][];

            CollectionAssert.AreEqual(matrixAfterAnalyzing, Program.GetAnalyzedMatrix(matrix, 0));
        }

        [Test]
        public void Test_AreCoordinateValid()
        {
            int numberOfRows = 5;
            double[][] matrix = new double[numberOfRows][];
            matrix[0] = new double[] { 10, 20, 30 };
            matrix[1] = new double[] { 1, 2, 3 };
            matrix[2] = new double[] { 2 };
            matrix[3] = new double[] { 2 };
            matrix[4] = new double[] { 10, 10 };

            Assert.AreEqual(true, Program.AreCoordinatesValid(matrix, 0, 0));
            Assert.AreEqual(false, Program.AreCoordinatesValid(matrix, 5, 5));
            Assert.AreEqual(false, Program.AreCoordinatesValid(matrix, -1, 0));
        }

    }
}