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
            var first = A.GroupBy(x => x).FirstOrDefault(x => x.Count() == 1);
            if (first != null)
            {
                return first.Key;
            }

            return -1;
        }
    }
}
