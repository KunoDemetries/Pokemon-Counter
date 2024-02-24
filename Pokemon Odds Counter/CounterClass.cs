using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WK.Libraries.HotkeyListenerNS;

namespace Pokemon_Odds_Counter
{
    

    public class CounterClasses
    {

    }

    public class CounterClass
    {
        public static List<CounterClass> CounterList = new List<CounterClass>();

        private string name;
        private int count;
        private Hotkey KIncrease;
        private Hotkey KDecrease;
        private int oddsselected;
        private int calcselected;
        private float odds;
        private string savefile;

        private string _counternumber;
        public string SetName
        {
            get { return name; }
            set { name = value; }
        }
        public int CountNumber
        {
            get { return count; }
            set { count = value; }
        }

        public Hotkey KeybindIncrease
        {
            get { return KIncrease; }
            set { KIncrease = value; }
        }
        public Hotkey KeybindDecrease
        {
            get { return KDecrease; }
            set { KDecrease = value; }
        }
        public int OddsSelected
        {
            get { return oddsselected; }
            set { oddsselected = value; }
        }
        public int CalculationOption
        {
            get { return calcselected; }
            set { calcselected = value; }
        }

        public float Odds
        {
            get { return odds; }
            set { odds = value; }
        }  

        public string SaveFileLocation
        {
            get { return savefile; }
            set { savefile = value; }
        }
    }
}
