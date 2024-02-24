using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WK.Libraries.HotkeyListenerNS;

namespace Pokemon_Odds_Counter
{
    public class JsonSaveFile
    {
        // Config file location group
        private static string ConfigFileSaveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        private static string ConfigFileSave = Path.Combine(ConfigFileSaveLocation + "/Pokemon Odds Calc");
        private static string ConfigFile = "/config.json";

        // Counter / Odds files output
        public static string SelectedSaveFileLocation;
        private static string SelectedOddsLocation = SelectedSaveFileLocation + "/" + "Odds.txt";
        private static string CurrentCountLocation = SelectedSaveFileLocation + "/" + "Count.txt";
        public static string[] FileRead;

        public static JsonElement root;
        

        public static void SaveFile()
        {
            string json = JsonConvert.SerializeObject(CounterClass.CounterList, Formatting.Indented);


            if (System.IO.File.Exists(ConfigFileSave + ConfigFile) == true)
            {
                if (System.IO.File.ReadAllBytes(ConfigFileSave + ConfigFile) != null)
                {
                    System.IO.File.WriteAllText(ConfigFileSave + ConfigFile, json);
                }
            }
            try
            {
                System.IO.File.WriteAllText(ConfigFileSave + ConfigFile, json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public static void LoadFile() 
        {
            // var users = root.EnumerateArray();
            Keybinds.hkl.RemoveAll();
            try
            {
                // loading the save file
                string json = System.IO.File.ReadAllText(ConfigFileSave + ConfigFile);
                CounterClass.CounterList = JsonConvert.DeserializeObject<List<CounterClass>>(json);


                int count = 0;
                
                // goes through all of the counterClass' in Counterclass and adding each of them to the different ListBoxes, then changing the name to the last set Name, Odds, CountNumber
                foreach (CounterClass counterClass in CounterClass.CounterList) {

                    PForm.CountListBox.Items.Add(CounterClass.CounterList);
                    PForm.OddsListBox.Items.Add(CounterClass.CounterList);
                    PForm.NameListBox.Items.Add(CounterClass.CounterList);

                    
                    
                    PForm.NameListBox.Items[count] = CounterClass.CounterList[count].SetName;
                    PForm.OddsListBox.Items[count] = CounterClass.CounterList[count].Odds;
                    PForm.CountListBox.Items[count] = CounterClass.CounterList[count].CountNumber;

                    switch (count)
                    {
                        case 0:
                            Keybinds.hkl.Update(ref Keybinds.Increase01, CounterClass.CounterList[count].KeybindIncrease);
                            Keybinds.hkl.Update(ref Keybinds.Decrease01, CounterClass.CounterList[count].KeybindDecrease);
                            Keybinds.hkl.Add(Keybinds.Increase01);
                            Keybinds.hkl.Add(Keybinds.Decrease01);
                            break;
                        case 1:
                            Keybinds.hkl.Update(ref Keybinds.Increase02, CounterClass.CounterList[count].KeybindIncrease);
                            Keybinds.hkl.Update(ref Keybinds.Decrease02, CounterClass.CounterList[count].KeybindDecrease);
                            Keybinds.hkl.Add(Keybinds.Increase02);
                            Keybinds.hkl.Add(Keybinds.Decrease02);
                            break;
                        case 2:
                            Keybinds.hkl.Update(ref Keybinds.Increase03, CounterClass.CounterList[count].KeybindIncrease);
                            Keybinds.hkl.Update(ref Keybinds.Decrease03, CounterClass.CounterList[count].KeybindDecrease);
                            Keybinds.hkl.Add(Keybinds.Increase03);
                            Keybinds.hkl.Add(Keybinds.Decrease03);
                            break;
                        case 3:
                            Keybinds.hkl.Update(ref Keybinds.Increase04, CounterClass.CounterList[count].KeybindIncrease);
                            Keybinds.hkl.Update(ref Keybinds.Decrease04, CounterClass.CounterList[count].KeybindDecrease);
                            Keybinds.hkl.Add(Keybinds.Increase04);
                            Keybinds.hkl.Add(Keybinds.Decrease04);
                            break;

                    }
                    Keybinds.hkl.Resume();
                    count++;
                }

            }
            catch (Exception e) 
            { 
                Console.WriteLine(e);
            }


        }
    }
}
