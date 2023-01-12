using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises
{
    public class FirstUnique
    {
        public int solution(int[] A)
        {
            // Implement your solution here
            foreach (var item in A)
            {
                var count = A.Count(x=> x == item);
                if (count == 1)
                {
                    return item;
                }
            }

            return -1;
        }
    }
}
