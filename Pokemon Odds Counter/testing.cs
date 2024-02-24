using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK.Libraries.HotkeyListenerNS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Pokemon_Odds_Counter
{
    public partial class testing : Form
    {
        public static int CreateorEdit;

        public testing(int list)
        {
            /* 0 create new keybind
             * 1 edit old keybind
             * 
             */
            CreateorEdit = list;

            InitializeComponent();
            SelectedSaveFileLocation.Text = null;
        }
        public static string NameSelected;

        public static int OddsIndex;
        public static int CalcIndex;

        public static string saveFileLocation;

        internal static HotkeySelector hks = new HotkeySelector();

        internal static Hotkey IncreaseBind;
        internal static Hotkey DecreaseBind;

        internal static Hotkey IBIdentifier;
        internal static Hotkey DBIdentifier;

        private void testing_Load(object sender, EventArgs e)
        {
            if (CreateorEdit == 0)
            {
                Keybinds.hkl.RemoveAll();
                try
                {
                    switch (PForm.CountListBox.SelectedIndex)
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
                        default:
                            IBIdentifier = Keybinds.DefaultIncreaseCount;
                            DBIdentifier = Keybinds.DefaultDecreaseCount;
                            break;

                    }
                    hks.Enable(IncreaseCountBBox, IBIdentifier);
                    hks.Enable(DecreaseCountBBox, DBIdentifier);


                    CounterClass.CounterList[PForm.CountListBox.SelectedIndex].OddsSelected = Keybinds.DefaultOddsSelected;
                    CounterClass.CounterList[PForm.CountListBox.SelectedIndex].CalculationOption = Keybinds.DefaultCalcOptions;
                    CalculationComboBox.SelectedIndex = Keybinds.DefaultCalcOptions;
                    OddsComboBox.SelectedIndex = Keybinds.DefaultOddsSelected;
                }
                catch
                {

                }
            }
            else if (CreateorEdit == 1)
            {
                int IIndex = PForm.CountListBox.SelectedIndex;
                int DIndex = PForm.CountListBox.SelectedIndex;

                switch (PForm.CountListBox.SelectedIndex)
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
                    default:
                        IBIdentifier = Keybinds.DefaultIncreaseCount;
                        DBIdentifier = Keybinds.DefaultDecreaseCount;
                        break;

                }

                try
                {

                    IncreaseBind = CounterClass.CounterList[PForm.CountListBox.SelectedIndex].KeybindIncrease;
                    DecreaseBind = CounterClass.CounterList[PForm.CountListBox.SelectedIndex].KeybindDecrease;
                    NameBox.Text = CounterClass.CounterList[PForm.NameListBox.SelectedIndex].SetName;
                    OddsComboBox.SelectedIndex = CounterClass.CounterList[PForm.NameListBox.SelectedIndex].OddsSelected;
                    CalculationComboBox.SelectedIndex = CounterClass.CounterList[PForm.NameListBox.SelectedIndex].CalculationOption;
                    saveFileLocation = CounterClass.CounterList[PForm.CountListBox.SelectedIndex].SaveFileLocation;

                    SelectedSaveFileLocation.Text = saveFileLocation;

                    NameSelected = NameBox.Text;

                    hks.Enable(IncreaseCountBBox, IncreaseBind);
                    hks.Enable(DecreaseCountBBox, DecreaseBind);
                }
                catch
                { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SelectedSaveFileLocation.Text = dialog.FileName;
                saveFileLocation = dialog.FileName;
            }

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameSelected = NameBox.Text;
        }

        private void testing_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IncreaseBind = HotkeyListener.Convert(IncreaseCountBBox.Text);
                DecreaseBind = HotkeyListener.Convert(DecreaseCountBBox.Text);

                // Saving keybinds
                CounterClass.CounterList[PForm.CountListBox.SelectedIndex].KeybindIncrease = IncreaseBind;
                CounterClass.CounterList[PForm.CountListBox.SelectedIndex].KeybindDecrease = DecreaseBind;
                CounterClass.CounterList[PForm.NameListBox.SelectedIndex].SetName = NameSelected;

                CounterClass.CounterList[PForm.NameListBox.SelectedIndex].OddsSelected = OddsIndex;
                CounterClass.CounterList[PForm.NameListBox.SelectedIndex].CalculationOption = CalcIndex;

                CounterClass.CounterList[PForm.NameListBox.SelectedIndex].SaveFileLocation = saveFileLocation;

                switch (PForm.CountListBox.SelectedIndex)
                {
                    case 0:
                        Keybinds.hkl.Update(ref Keybinds.Increase01, HotkeyListener.Convert(IncreaseCountBBox.Text));
                        Keybinds.hkl.Update(ref Keybinds.Decrease01, HotkeyListener.Convert(DecreaseCountBBox.Text));

                        Keybinds.hkl.Add(Keybinds.Increase01);
                        Keybinds.hkl.Add(Keybinds.Increase01);
                        break;

                    case 1:
                        Keybinds.hkl.Update(ref Keybinds.Increase02, HotkeyListener.Convert(IncreaseCountBBox.Text));
                        Keybinds.hkl.Update(ref Keybinds.Decrease02, HotkeyListener.Convert(DecreaseCountBBox.Text));

                        Keybinds.hkl.Add(Keybinds.Increase02);
                        Keybinds.hkl.Add(Keybinds.Increase02);
                        break;
                    case 2:
                        Keybinds.hkl.Update(ref Keybinds.Increase03, HotkeyListener.Convert(IncreaseCountBBox.Text));
                        Keybinds.hkl.Update(ref Keybinds.Decrease03, HotkeyListener.Convert(DecreaseCountBBox.Text));

                        Keybinds.hkl.Add(Keybinds.Increase03);
                        Keybinds.hkl.Add(Keybinds.Increase03);
                        break;

                    case 3:
                        Keybinds.hkl.Update(ref Keybinds.Increase04, HotkeyListener.Convert(IncreaseCountBBox.Text));
                        Keybinds.hkl.Update(ref Keybinds.Decrease04, HotkeyListener.Convert(DecreaseCountBBox.Text));

                        Keybinds.hkl.Add(Keybinds.Increase04);
                        Keybinds.hkl.Add(Keybinds.Increase04);
                        break;
                }

                PForm.UpdateTextFromSettings();
                JsonSaveFile.SaveFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void OddsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OddsIndex = OddsComboBox.SelectedIndex;
            OddsComboBox.SelectedIndex = OddsIndex;
            CounterClass.CounterList[PForm.NameListBox.SelectedIndex].OddsSelected = OddsIndex;
        }

        private void CalculationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcIndex = CalculationComboBox.SelectedIndex;
            CalculationComboBox.SelectedIndex = CalcIndex;
            CounterClass.CounterList[PForm.NameListBox.SelectedIndex].CalculationOption = CalcIndex;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IncreaseCountBBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void SelectedSaveFileLocation_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
