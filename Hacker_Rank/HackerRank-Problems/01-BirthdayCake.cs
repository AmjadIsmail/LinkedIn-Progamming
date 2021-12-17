using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problems
{
    public class BirthdayCake_Result
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int Count = 0;
            int[] ArrCancel = candles.ToArray();
            int maxValue = ArrCancel.Max();
            for (int j = 0; j < ArrCancel.Length; j++)
            {
                if (ArrCancel[j] == maxValue) { Count++; }
            }
            return Count;

        }
    }

    public class BirthdayCake_Solution
    {
        public static void Input(List<int> candles) 
        {
           // int[] arr = new int[] { 1, 2, 3, };
            BirthdayCake_Result.birthdayCakeCandles(candles);
        }
    }


}
