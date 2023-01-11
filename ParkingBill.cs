using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises
{
    public class ParkingBill
    {
        private const int _enteranceFee = 2;
        private const int _firstHourCost = 3;
        private const int _hourCost = 4;

        public int solution(string E, string L)
        {
            // Implement your solution here
            var totalSpend = _enteranceFee;

            if (TimeSpan.TryParse(E, out var enterTime) &&
                TimeSpan.TryParse(L, out var leaveTime))
            {
                var time = leaveTime - enterTime;

                var hours = time.Hours;
                var minutes = time.Minutes;

                if (minutes > 0)
                {
                    totalSpend += _firstHourCost;
                    totalSpend += hours * _hourCost;
                }
                else
                {
                    if (hours == 1)
                    {
                        totalSpend += _firstHourCost;
                    }
                    else
                    {
                        totalSpend += _firstHourCost;
                        totalSpend += (hours - 1) * _hourCost;
                    }
                }

                return totalSpend;
            }

            return totalSpend;
        }
    }
}
