using TwoArraysApp;
namespace TwoArraysTests {
    public class CombineAndSortShould {

        [TestCase( new int[] { -2, -3, -1, -7, -4, -9 }, new int[] { 2, 3, 0, 1 }, new int[] { -9, -7, -4, -3, -2, -1, 0, 1, 2, 3 } )]
        public void GivenTwoSortedIntArrays_CombineAndSort_ReturnsCorrectArray( int[] arr1, int[] arr2, int[] expected ) {
            Assert.That( Program.CombineAndSort( arr1, arr2 ), Is.EqualTo( expected ) );
        }
        [TestCase( new int[] { }, new int[] { }, new int[] { } )]
        public void GivenTwoEmptyArrays_CombineAndSort_ReturnsCorrectArray( int[] arr1, int[] arr2, int[] expected ) {
            Assert.That( Program.CombineAndSort( arr1, arr2 ), Is.EqualTo( expected ) );
        }
        [TestCase( new int[] { -2, -3, -1, 0, -7, -4, -9 }, new int[] { }, new int[] { -9, -7, -4, -3, -2, -1, 0 } )]
        public void GivenOneEmptyArrayAndOneIntArray_CombineAndSort_ReturnsCorrectArray( int[] arr1, int[] arr2, int[] expected ) {
            Assert.That( Program.CombineAndSort( arr1, arr2 ), Is.EqualTo( expected ) );
        }
        [TestCase( new int[] { 1, 4, 3, 5, 2 }, null )]
        public void GivenOneOrTwoNulls_CombineAndSort_ThrowsException( int[] arr1, int[] arr2 ) {
            Assert.Throws<ArgumentNullException>( () => Program.CombineAndSort( arr1, arr2 ) );
        }
    }
}