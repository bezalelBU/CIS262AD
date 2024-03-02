using GenerateQR;

// Katlyn Quinn
// MEID KAT2342618
// CIS262AD 10549
// Lesson 4

namespace Lesson4_KAT2342618
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Please type the address: " );
            GenQR newQR = new GenQR();
            string text = Console.ReadLine();
            newQR.MakeNewQR( text );

        }
    }
}
