using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Libraries.HotkeyListenerNS;

namespace Pokemon_Odds_Counter
{
    public class Keybinds
    {
        public static HotkeyListener hkl = new HotkeyListener();

        public static Hotkey DefaultIncreaseCount = new Hotkey(Keys.Add);
        public static Hotkey DefaultDecreaseCount = new Hotkey(Keys.Subtract);
        public static int DefaultOddsSelected = 0;
        public static int DefaultCalcOptions = 0;

        //Increase grouping
        public static Hotkey Increase01 = new Hotkey(Keys.NumPad2);
        public static Hotkey Increase02 = new Hotkey(Keys.NumPad5);
        public static Hotkey Increase03 = new Hotkey(Keys.NumPad8);
        public static Hotkey Increase04 = new Hotkey(Keys.Divide);

        //Decrease grouping
        public static Hotkey Decrease01 = new Hotkey(Keys.NumPad3);
        public static Hotkey Decrease02 = new Hotkey(Keys.NumPad6);
        public static Hotkey Decrease03 = new Hotkey(Keys.NumPad9);
        public static Hotkey Decrease04 = new Hotkey(Keys.Multiply);

        public Keybinds()
        {
        }
    }
}
