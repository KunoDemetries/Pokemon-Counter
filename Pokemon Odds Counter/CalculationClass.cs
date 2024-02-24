using Pokemon_Odds_Counter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Odds_Calc_
{
    internal class CalculationClass
    {
        public static float OddsRatio;
        public static string CalcUsed;
        public static string OddsUsed;

        public static int CalcUsedIndex;
        public static int CountIndex;
        public static int OddsIndex;

        public CalculationClass()
        {

        }

        public static void Cal(int CountIndex, int CalcUsedIndex, int OddsIndex)
        {
            switch (CounterClass.CounterList[CountIndex].OddsSelected)
            {
                //Full odds gen 1 - Black 1
                case 2:
                    OddsUsed = "8191.8192";
                    break;
                //base shiny odds
                case 6:
                    OddsUsed = "4095.4096";
                    break;
                // NSC, NSP, outbreak 60+
                case 7:
                    OddsUsed = "1364.1365";
                    break;
                // NSC, Sp3, Outbreak 60+
                case 8:
                    OddsUsed = "682.683";
                    break;
                // Shiny Charm Wild Encounter
                case 9:
                    OddsUsed = "1364.1365";
                    break;
                // SC, SP3
                case 10:
                    OddsUsed = "682.683";
                    break;
                // SC, NSP, outbreak 60+
                case 11:
                    OddsUsed = "818.819";
                    break;
                // SC, SP3, Outbreak 60+
                case 12:
                    OddsUsed = "511.512";
                    break;
                // Shiny Charm (eggs)
                case 13:
                    OddsUsed = "2047.2048";
                    break;
                // NSC, Masuda Method
                case 14:
                    OddsUsed = "682.683";
                    break;
                // Sc, Masuda Method
                case 15:
                    OddsUsed = "511.512";
                    break;
                // Tera Raid Encounters
                case 16:
                    OddsUsed = "4102.4103";
                    break;
            }


            string[] ISplit = OddsUsed.Split(new char[] { '.' });

            switch (CalcUsedIndex)
            {
                case 0:
                    OddsRatio = ((float)1 - (((float)(Math.Pow((float.Parse(ISplit[0])) / (float.Parse(ISplit[1])), ((float)CounterClass.CounterList[CountIndex].CountNumber)))))) * 100f;
                    break;
                case 1:
                    OddsRatio = 100f - (((float)1 - (((float)(Math.Pow((float.Parse(ISplit[0])) / (float.Parse(ISplit[1])), ((float)CounterClass.CounterList[CountIndex].CountNumber)))))) * 100f);
                    break;
            }

            CounterClass.CounterList[CountIndex].Odds = OddsRatio;
            PForm.OddsListBox.Items[CountIndex] = OddsRatio.ToString("0.00");
        }

    }
}
