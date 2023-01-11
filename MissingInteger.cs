using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            var max = 0;
            var list = new HashSet<int>(A.Length);
            foreach (var item in A)
            {
                if (item > 0)
                {
                    list.Add(item);
                    if (item > max)
                    {
                        max = item;
                    }
                }
            }

            if (max == 0)
            {
                return 1;
            }

            for (int i = 1; i <= max + 1; i++)
            {
                //contains's complexity o(1) in hashset!
                if(!list.Contains(i))
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
