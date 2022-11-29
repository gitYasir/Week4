namespace TwoArraysApp {
    public class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public static int[] CombineAndSort( int[] arr1, int[] arr2 ) {
            if ( arr2 == null || arr1 == null ) {
                throw new ArgumentNullException();
            }
            if ( arr2.Length == 0 && arr1.Length == 0 ) {
                return arr1;
            }

            var arr0 = new int[ arr1.Length + arr2.Length ];
            arr1.CopyTo( arr0, 0 );
            arr2.CopyTo( arr0, arr1.Length );

            int runs = arr0.Length;
            while ( runs > 1 ) {
                for ( int j = 1; j < arr0.Length; j++ ) {
                    int temp = 0;
                    if ( arr0[ j - 1 ] > arr0[ j ] ) {
                        temp = arr0[ j - 1 ];
                        arr0[ j - 1 ] = arr0[ j ];
                        arr0[ j ] = temp;
                    }
                }
                runs--;
            }

            return arr0;
        }

    }
}