namespace Recursion {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( $"SumLoop of 5: {SumLoop( 5 )}" );
            Console.WriteLine( $"SumRecursion of 5: {SumRecursion( 5 )}" );
        }

        public static int SumLoop( int n ) {

            int sum = 0;
            for ( int i = 0; i <= n; i++ ) {

                sum += i;

            }
            return sum;
        }

        public static int SumRecursion( int n ) {
            int sum = n;
            if ( n > 0 ) {
                sum += SumRecursion( n - 1 );
            }
            return sum;
        }

    }
}