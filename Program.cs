using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodilityExercises
{
    class Program
    {
        static void Main()
        {
            //var maxCounters = new MaxCounters();
            //maxCounters.solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });

            //var smallestSet1 = new int[] { 1, 3, 6, 4, 1, 2 };
            //var smallestSet2 = new int[] { 1, 2, 3 };
            //var smallestSet3 = new int[] { 1 * -1, 3 * -1 };
            //var smallestSet4 = new int[] { 1 * -1, 0,1, 3 };
            //var smallestInt = new MissingInteger();

            //var result1 = smallestInt.solution(smallestSet1);
            //var result2 = smallestInt.solution(smallestSet2);
            //var result3 = smallestInt.solution(smallestSet3);
            //var result4 = smallestInt.solution(smallestSet4);

            
            var parkingBill = new ParkingBill();
            parkingBill.solution("10:00", "13:21");
        }
    }
}