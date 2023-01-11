using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises
{
    public class ParityDegree
    {
        public int solution(int N)
        {
            var val = N & (~(N - 1));
            return (int)Math.Log(val, 2);
        }
    }
}
