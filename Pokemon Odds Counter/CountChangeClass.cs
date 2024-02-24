using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Odds_Counter
{
    internal class CountChangeClass
    {

        public static void ChangeCount(int indexNumber, int IncorDec)
        {
            /* 0 increase
             * 1 decrease
             */

            if (IncorDec == 0)
            {
                CounterClass.CounterList[indexNumber].CountNumber++;
                PForm.CountListBox.Items[indexNumber] = CounterClass.CounterList[indexNumber].CountNumber;
            }

            if (IncorDec == 1)
            {
                CounterClass.CounterList[indexNumber].CountNumber--;
                PForm.CountListBox.Items[indexNumber] = CounterClass.CounterList[indexNumber].CountNumber;
            }
        }
    }
}
