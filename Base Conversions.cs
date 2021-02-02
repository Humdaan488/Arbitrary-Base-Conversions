using System;
using static System.Console;

namespace Bme121
{
    static class Program
    {
        static void Main( )
        {
            Write ( "Please Enter a number: ");
            int number = int.Parse ( ReadLine());
            int numTwo = number; 
            
            Write ( "Please Enter a base: ");
            int numberBase = int.Parse ( ReadLine ( ));
            int counter = 0;
            
            if ( number < 0  || numberBase < 2)
            {
                WriteLine ( "Invalid entry!" );
                return;
            }
            
            // Create a loop to determine the length of array
            for ( int index = number ; index > 0 ; index /= numberBase)
            {
                counter ++;
            }
            
            int [ ] result = new int [counter];
            
            // loop to generate and store the digits
            for ( int index =  0 ; index < result.Length ; index ++)
            {
                result [index] = number % numberBase;
                number /= numberBase; 
            }
            
            Write ( numTwo + " in base " + numberBase + " is " );
            
            // trying to go in the reverse order of indices
            for ( int index = counter - 1; index >= 0; index -- )
            {
                Write ( result [index] );
                if ( numberBase > 9)
                {
                    if ( index != 0 )
                    {
                        Write ( ",");
                    }
                }
            }
        } 
    }
}
