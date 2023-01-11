using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises
{
    public class MaxCounters
    {
        private int[] _counterArray;

        public int[] solution(int N, int[] A)
        {
            _counterArray = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < N)
                {
                    Increment(A[i]);
                }
                else
                {
                    SetMax();
                }
            }

            return _counterArray;
        }

        private void Increment(int index)
        {
            _counterArray[index - 1]++;
        }

        private void SetMax()
        {
            var max = _counterArray.Max();
            for (int i = 0; i < _counterArray.Length; i++)
            {
                _counterArray[i] = max;
            }
        }
    }
}
