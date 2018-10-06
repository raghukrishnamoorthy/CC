using System;

namespace CC
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Generate Balanced Parentheses
            // var myParens = ParensOptimized.generateParens(2);
            // foreach (var item in myParens)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Count number of steps
                var noOfSteps = CountSteps.CountWays(3);
                Console.WriteLine(noOfSteps);
            #endregion
        }
    }
}
