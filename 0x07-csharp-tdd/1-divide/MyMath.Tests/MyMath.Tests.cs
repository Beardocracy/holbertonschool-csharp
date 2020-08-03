using NUnit.Framework;
using System;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void NullMatrixCheck()
        {
            Assert.IsNull(Matrix.Divide(null, 5));
        }

        [Test]
        public void DivideByZero_ReturnsNull()
        {
            int[,] array1 = new int[2, 2] { 
                { 2, 4 },
                { 6, 8 }
            };
            Assert.IsNull(Matrix.Divide(array1, 0));
        }

        [Test]
        public void DivideByZero_Msg()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter originalOutput = Console.Out;
                Console.SetOut(sw);

                int[,] array1 = new int[1, 1];
                int[,] returnArray = Matrix.Divide(array1, 0);

                string expected = "Num cannot be 0\n";

                Assert.AreEqual(expected, sw.ToString());
                Console.SetOut(originalOutput);
                sw.Dispose();
            }
        }

        [Test]
        public void MatrixSize_ReturnsSame_rowsOrHeight()
        {
            int[,] array1 = new int[2, 2] { 
                { 2, 4 },
                { 6, 8 }
            };
            int[,] returnArray;

            returnArray = Matrix.Divide(array1, 2);

            Assert.AreEqual(array1.GetLength(0), returnArray.GetLength(0));
        }

        [Test]
        public void MatrixSize_ReturnsSame_colsOrWidth()
        {
            int[,] array1 = new int[2, 2] { 
                { 2, 4 },
                { 6, 8 }
            };
            int[,] returnArray;

            returnArray = Matrix.Divide(array1, 2);

            Assert.AreEqual(array1.GetLength(1), returnArray.GetLength(1));
        }

        [Test]
        public void MatrixDivide_CheckValues()
        {
            int[,] array1 = new int[2, 2] { 
                { 2, 4 },
                { 6, 8 }
            };
            int[,] expectedArray = new int[2, 2] { 
                { 1, 2 },
                { 3, 4 }
            };
            int[,] returnArray;


            returnArray = Matrix.Divide(array1, 2);

            Assert.AreEqual(expectedArray, returnArray);
        }
    }
}