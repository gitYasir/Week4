namespace BubbleSortApp {
    public class Program {

        public static int[] BubbleSort( int[] arr ) {
            int runs = arr.Length;
            while ( runs > 1 ) {
                for ( int j = 1; j < arr.Length; j++ ) {
                    int temp = 0;
                    if ( arr[ j - 1 ] > arr[ j ] ) {
                        temp = arr[ j - 1 ];
                        arr[ j - 1 ] = arr[ j ];
                        arr[ j ] = temp;
                    }
                }
                runs--;
            }
            return arr;
        }
    }
}