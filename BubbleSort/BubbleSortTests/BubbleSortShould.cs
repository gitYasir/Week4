using BubbleSortApp;

namespace BubbleSortTests {
    public class BubbleSortShould {

        [TestCase( new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 } )]
        [TestCase( new int[] { -2, -3, -1, -7, -4, -9 }, new int[] { -9, -7, -4, -3, -2, -1 } )]
        [TestCase( new int[] { 7, 2, 3, 1, 6, 5, 8, 9 }, new int[] { 1, 2, 3, 5, 6, 7, 8, 9 } )]
        [TestCase( new int[] { 2, 3, 1, 8, 0, 3 }, new int[] { 0, 1, 2, 3, 3, 8 } )]
        [TestCase( new int[] { 2, 3, 1, 8, 0, -3 }, new int[] { -3, 0, 1, 2, 3, 8 } )]
        public void GivenArrayOfInts_BubbleSort_ReturnsOrderedArrayOfInts( int[] actual, int[] expected ) {
            Assert.That( Program.BubbleSort( actual ), Is.EqualTo( expected ) );
        }
    }
}