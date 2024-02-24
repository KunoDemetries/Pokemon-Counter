using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Data;
using System.Text;
using System.Threading;
using WK.Libraries.HotkeyListenerNS;
using static System.Windows.Forms.DataFormats;
using static System.Net.Mime.MediaTypeNames;
using Pokemon_Odds_Calc_;
using System.Timers;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;

namespace Pokemon_Odds_Counter
{
    public partial class PForm : Form
    {
        public PForm()
        {
            InitializeComponent();
            Keybinds.hkl.HotkeyPressed += Hkl_HotkeyPressed;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CounterClass.CounterList.Count < 4)
            {
                CounterClass counterClass = new CounterClass();

                counterClass.CountNumber = 0;
                counterClass.Odds = 0f;

                NameListBox.Items.Add(counterClass);
                OddsListBox.Items.Add(counterClass);
                CountListBox.Items.Add(counterClass);

                int curIndex = NameListBox.Items.IndexOf(counterClass);
                CountListBox.SelectedIndex = curIndex;
                CountListBox.Items[curIndex] = "0";
                NameListBox.Items[curIndex] = "---";
                OddsListBox.Items[curIndex] = "0";

                CounterClass.CounterList.Add(counterClass);

                testing testingForm = new testing(0);
                testingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Currently only four counters is supported!");
            }

        }

        public static void UpdateTextFromSettings()
        {
            try
            {
                PForm.NameListBox.Items[NameListBox.SelectedIndex] = CounterClass.CounterList[NameListBox.SelectedIndex].SetName;
            }
            catch
            {

            }
        }

        public static void UpdateTextFromCountChange(int index)
        {
            PForm.CountListBox.Items[index] = CounterClass.CounterList[index].CountNumber.ToString();
            PForm.OddsListBox.Items[index] = CounterClass.CounterList[index].Odds.ToString();
        }

        private void NameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountListBox.SelectedIndex = NameListBox.SelectedIndex;
            OddsListBox.SelectedIndex = NameListBox.SelectedIndex;
        }

        private void CountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameListBox.SelectedIndex = CountListBox.SelectedIndex;
            OddsListBox.SelectedIndex = CountListBox.SelectedIndex;
        }

        private void OddsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameListBox.SelectedIndex = OddsListBox.SelectedIndex;
            CountListBox.SelectedIndex = OddsListBox.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonSaveFile.LoadFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JsonSaveFile.SaveFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OddsListBox.SelectedIndex.ToString() != "-1")
            {
                testing testingForm = new testing(1);
                testingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No counter selected");
            }
        }

        public static void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            int CalcIndex;
            int OddsIndex;
            int CalcUsedIndex;

            int CountIndex;

            if (e.Hotkey == Keybinds.Increase01)
            {
                CountIndex = 0;
                OddsIndex = CounterClass.CounterList[0].OddsSelected;
                CalcIndex = CounterClass.CounterList[0].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 0);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }
            }
            if (e.Hotkey == Keybinds.Decrease01)
            {
                CountIndex = 0;
                OddsIndex = CounterClass.CounterList[0].OddsSelected;
                CalcIndex = CounterClass.CounterList[0].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 1);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }

            }

            if (e.Hotkey == Keybinds.Increase02)
            {
                CountIndex = 1;
                OddsIndex = CounterClass.CounterList[1].OddsSelected;
                CalcIndex = CounterClass.CounterList[1].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 0);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }


            }
            if (e.Hotkey == Keybinds.Decrease02)
            {
                CountIndex = 1;
                OddsIndex = CounterClass.CounterList[1].OddsSelected;
                CalcIndex = CounterClass.CounterList[1].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 1);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }



            }

            if (e.Hotkey == Keybinds.Increase03)
            {
                CountIndex = 2;
                OddsIndex = CounterClass.CounterList[2].OddsSelected;
                CalcIndex = CounterClass.CounterList[2].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 0);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }


            }
            if (e.Hotkey == Keybinds.Decrease03)
            {
                CountIndex = 2;
                OddsIndex = CounterClass.CounterList[2].OddsSelected;
                CalcIndex = CounterClass.CounterList[2].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 1);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }


            }

            if (e.Hotkey == Keybinds.Increase04)
            {
                CountIndex = 3;
                OddsIndex = CounterClass.CounterList[3].OddsSelected;
                CalcIndex = CounterClass.CounterList[3].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 0);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }


            }
            if (e.Hotkey == Keybinds.Decrease04)
            {
                CountIndex = 3;
                OddsIndex = CounterClass.CounterList[3].OddsSelected;
                CalcIndex = CounterClass.CounterList[3].CalculationOption;

                CountChangeClass.ChangeCount(CountIndex, 1);
                CalculationClass.Cal(CountIndex, CalcIndex, OddsIndex);

                try
                {
                    UserSaveFileOutput.OddsOutput(CountIndex);
                    UserSaveFileOutput.CounOutput(CountIndex);
                }
                catch
                {

                }


            }
        }

        private void PForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            JsonSaveFile.SaveFile();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                var timingMessage = MessageBox.Show(
                    "Are you sure you would like to delete the currently selected counter" + ":" + CounterClass.CounterList[OddsListBox.SelectedIndex].SetName + "?",
                    "Delete Counter",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );

                if (timingMessage == DialogResult.Yes)
                {
                    int index = OddsListBox.SelectedIndex;
                    UserSaveFileOutput.DeleteOutputs(index);
                    CounterClass.CounterList.Remove(CounterClass.CounterList[index]);
                    OddsListBox.Items.RemoveAt(index);
                    CountListBox.Items.RemoveAt(index);
                    NameListBox.Items.RemoveAt(index);

                    Hotkey IBIdentifier = new Hotkey();
                    Hotkey DBIdentifier = new Hotkey();

                    switch (index)
                    {
                        case 0:
                            IBIdentifier = Keybinds.Increase01;
                            DBIdentifier = Keybinds.Decrease01;
                            break;
                        case 1:
                            IBIdentifier = Keybinds.Increase02;
                            DBIdentifier = Keybinds.Decrease02;
                            break;
                        case 2:
                            IBIdentifier = Keybinds.Increase03;
                            DBIdentifier = Keybinds.Decrease03;
                            break;
                        case 3:
                            IBIdentifier = Keybinds.Increase04;
                            DBIdentifier = Keybinds.Decrease04;
                            break;
                    }
                    Keybinds.hkl.Remove(IBIdentifier);
                    Keybinds.hkl.Remove(DBIdentifier);
                }
                JsonSaveFile.SaveFile();
            }
            catch
            {
                MessageBox.Show("Please select a counter to delete!");
            }

        }
    }
}
