using System;
using System.Diagnostics;
namespace OOP_Assignment_2
{
    public class Tests
    {
        public static void RunTests()
        {
            Testsevens();
            TestThreeOrMore();
        }


        private static void Testsevens()
        {
            Console.WriteLine("Testing sevens out...");
            Sevens_Out testgame = new Sevens_Out();
            int turnTotal = testgame.StartSevensOut();
            Debug.Assert(turnTotal != 7, "Sevens out test failed");

            Console.WriteLine("Sevens out test passed");
        }

        private static void TestThreeOrMore()
        {
            Console.WriteLine("Testing Three or more...");
            Three_or_more test3ormore = new Three_or_more();
            test3ormore.StartThreeOrMore();
            Debug.Assert(test3ormore.player1Points >= 20 || test3ormore.player2Points >= 20, "Three or more test failed");
            Console.WriteLine("Three or more test passed");
        }
    }
}