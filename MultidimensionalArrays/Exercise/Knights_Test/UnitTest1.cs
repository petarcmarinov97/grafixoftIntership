using NUnit.Framework;
using Knights;

namespace Knights_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ReturnIsCellInMatrix()
        {
            int numberOfRows = 5;
            char[][] matrix = new char[numberOfRows][];
            matrix[0] = new char[] { '0', 'K', '0', 'K', '0' };
            matrix[1] = new char[] { 'K', '0', '0', '0', 'K' };
            matrix[2] = new char[] { '0', '0', 'K', '0', '0' };
            matrix[3] = new char[] { 'K', '0', '0', '0', 'K' };
            matrix[4] = new char[] { '0', 'K', '0', 'K', '0' };

            Assert.AreEqual(true, Program.ReturnIsCellInMatrix(0, 0, matrix));
            Assert.AreEqual(false, Program.ReturnIsCellInMatrix(5, 5, matrix));
            Assert.AreEqual(false, Program.ReturnIsCellInMatrix(-1, 0, matrix));
        }

        [Test]
        public void Test_GetKnightsInDanger()
        {
            int numberOfRows = 5;
            char[][] matrix = new char[numberOfRows][];
            matrix[0] = new char[] { '0', 'K', '0', 'K', '0' };
            matrix[1] = new char[] { 'K', '0', '0', '0', 'K' };
            matrix[2] = new char[] { '0', '0', 'K', '0', '0' };
            matrix[3] = new char[] { 'K', '0', '0', '0', 'K' };
            matrix[4] = new char[] { '0', 'K', '0', 'K', '0' };

            char[][] secondMatrix = new char[2][];
            secondMatrix[0] = new char[] { 'K','K' };
            secondMatrix[1] = new char[] { 'K','K' };

            char[][] thirdMatrix = new char[0][];
            

            int currentKnightsInDanger = 0;

            Assert.AreEqual(1, Program.GetKnightsInDanger(0, 1, matrix, currentKnightsInDanger));
            Assert.AreEqual(0, Program.GetKnightsInDanger(0, 1, secondMatrix, currentKnightsInDanger));
            Assert.AreEqual(0, Program.GetKnightsInDanger(0, 1, thirdMatrix, currentKnightsInDanger));
            
        }
    }
}