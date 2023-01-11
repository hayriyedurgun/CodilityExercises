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
            var maxCounters = new MaxCounters();
            maxCounters.solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
        }
    }
}