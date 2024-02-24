using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WK.Libraries.HotkeyListenerNS;
using System.Reflection;
using Pokemon_Odds_Calc_;

namespace Pokemon_Odds_Counter
{
    internal class UserSaveFileOutput
    {
        public static void SaveFile()
        {

        }
        public static void CounOutput(int index)
        {

            string savefile = CounterClass.CounterList[index].SaveFileLocation;
            string Sindex = CounterClass.CounterList[index].SetName;
            string SCurrentCount = CounterClass.CounterList[index].CountNumber.ToString();

            if (System.IO.File.Exists(savefile + ("/" + Sindex + "Count" + ".txt")) == true)
            {
                System.IO.File.WriteAllText(savefile + ("/" + Sindex + "Count" + ".txt"), SCurrentCount);

            }
            else
            {
                try
                {
                    System.IO.File.WriteAllText(savefile + ("/" + Sindex + "Count" + ".txt"), SCurrentCount);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }

        public static void OddsOutput(int index)
        {

            string savefile = CounterClass.CounterList[index].SaveFileLocation;
            string Sindex = CounterClass.CounterList[index].SetName;
            string SOddsCount = CounterClass.CounterList[index].CountNumber.ToString();
            float Odds = CounterClass.CounterList[index].Odds;

            if (System.IO.File.Exists(savefile + ("/" + Sindex + "Odds" + ".txt")) == true)
            {
                System.IO.File.WriteAllText(savefile + ("/" + Sindex + "Odds" + ".txt"), Odds.ToString("0.00"));
            }
            else
            {
                try
                {
                    System.IO.File.WriteAllText(savefile + ("/" + Sindex + "Odds" + ".txt"), Odds.ToString("0.00"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static void DeleteOutputs(int index)
        {
            string savefile = CounterClass.CounterList[index].SaveFileLocation;
            string Sindex = CounterClass.CounterList[index].SetName;

            if (System.IO.File.Exists(savefile + ("/" + Sindex + "Odds" + ".txt")) == true)
            {
                System.IO.File.Delete(savefile + ("/" + Sindex + "Odds" + ".txt"));
            }

            if (System.IO.File.Exists(savefile + ("/" + Sindex + "Count" + ".txt")) == true)
            {
                System.IO.File.Delete(savefile + ("/" + Sindex + "Count" + ".txt"));
            }
        }
    }
}
