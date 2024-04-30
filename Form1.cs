using System;
using System.IO;
using System.Windows.Forms;
using static Sudoku_Editor.Save;

namespace Sudoku_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            A1.Value = 0;
            A1Check.CheckState = CheckState.Checked;
            A2.Value = 0;
            A2Check.CheckState = CheckState.Checked;
            A3.Value = 0;
            A3Check.CheckState = CheckState.Checked;
            A4.Value = 0;
            A4Check.CheckState = CheckState.Checked;
            A5.Value = 0;
            A5Check.CheckState = CheckState.Checked;
            A6.Value = 0;
            A6Check.CheckState = CheckState.Checked;
            A7.Value = 0;
            A7Check.CheckState = CheckState.Checked;
            A8.Value = 0;
            A8Check.CheckState = CheckState.Checked;
            A9.Value = 0;
            A9Check.CheckState = CheckState.Checked;
            B1.Value = 0;
            B1Check.CheckState = CheckState.Checked;
            B2.Value = 0;
            B2Check.CheckState = CheckState.Checked;
            B3.Value = 0;
            B3Check.CheckState = CheckState.Checked;
            B4.Value = 0;
            B4Check.CheckState = CheckState.Checked;
            B5.Value = 0;
            B5Check.CheckState = CheckState.Checked;
            B6.Value = 0;
            B6Check.CheckState = CheckState.Checked;
            B7.Value = 0;
            B7Check.CheckState = CheckState.Checked;
            B8.Value = 0;
            B8Check.CheckState = CheckState.Checked;
            B9.Value = 0;
            B9Check.CheckState = CheckState.Checked;
            C1.Value = 0;
            C1Check.CheckState = CheckState.Checked;
            C2.Value = 0;
            C2Check.CheckState = CheckState.Checked;
            C3.Value = 0;
            C3Check.CheckState = CheckState.Checked;
            C4.Value = 0;
            C4Check.CheckState = CheckState.Checked;
            C5.Value = 0;
            C5Check.CheckState = CheckState.Checked;
            C6.Value = 0;
            C6Check.CheckState = CheckState.Checked;
            C7.Value = 0;
            C7Check.CheckState = CheckState.Checked;
            C8.Value = 0;
            C8Check.CheckState = CheckState.Checked;
            C9.Value = 0;
            C9Check.CheckState = CheckState.Checked;
            D1.Value = 0;
            D1Check.CheckState = CheckState.Checked;
            D2.Value = 0;
            D2Check.CheckState = CheckState.Checked;
            D3.Value = 0;
            D3Check.CheckState = CheckState.Checked;
            D4.Value = 0;
            D4Check.CheckState = CheckState.Checked;
            D5.Value = 0;
            D5Check.CheckState = CheckState.Checked;
            D6.Value = 0;
            D6Check.CheckState = CheckState.Checked;
            D7.Value = 0;
            D7Check.CheckState = CheckState.Checked;
            D8.Value = 0;
            D8Check.CheckState = CheckState.Checked;
            D9.Value = 0;
            D9Check.CheckState = CheckState.Checked;
            E1.Value = 0;
            E1Check.CheckState = CheckState.Checked;
            E2.Value = 0;
            E2Check.CheckState = CheckState.Checked;
            E3.Value = 0;
            E3Check.CheckState = CheckState.Checked;
            E4.Value = 0;
            E4Check.CheckState = CheckState.Checked;
            E5.Value = 0;
            E5Check.CheckState = CheckState.Checked;
            E6.Value = 0;
            E6Check.CheckState = CheckState.Checked;
            E7.Value = 0;
            E7Check.CheckState = CheckState.Checked;
            E8.Value = 0;
            E8Check.CheckState = CheckState.Checked;
            E9.Value = 0;
            E9Check.CheckState = CheckState.Checked;
            F1.Value = 0;
            F1Check.CheckState = CheckState.Checked;
            F2.Value = 0;
            F2Check.CheckState = CheckState.Checked;
            F3.Value = 0;
            F3Check.CheckState = CheckState.Checked;
            F4.Value = 0;
            F4Check.CheckState = CheckState.Checked;
            F5.Value = 0;
            F5Check.CheckState = CheckState.Checked;
            F6.Value = 0;
            F6Check.CheckState = CheckState.Checked;
            F7.Value = 0;
            F7Check.CheckState = CheckState.Checked;
            F8.Value = 0;
            F8Check.CheckState = CheckState.Checked;
            F9.Value = 0;
            F9Check.CheckState = CheckState.Checked;
            G1.Value = 0;
            G1Check.CheckState = CheckState.Checked;
            G2.Value = 0;
            G2Check.CheckState = CheckState.Checked;
            G3.Value = 0;
            G3Check.CheckState = CheckState.Checked;
            G4.Value = 0;
            G4Check.CheckState = CheckState.Checked;
            G5.Value = 0;
            G5Check.CheckState = CheckState.Checked;
            G6.Value = 0;
            G6Check.CheckState = CheckState.Checked;
            G7.Value = 0;
            G7Check.CheckState = CheckState.Checked;
            G8.Value = 0;
            G8Check.CheckState = CheckState.Checked;
            G9.Value = 0;
            G9Check.CheckState = CheckState.Checked;
            H1.Value = 0;
            H1Check.CheckState = CheckState.Checked;
            H2.Value = 0;
            H2Check.CheckState = CheckState.Checked;
            H3.Value = 0;
            H3Check.CheckState = CheckState.Checked;
            H4.Value = 0;
            H4Check.CheckState = CheckState.Checked;
            H5.Value = 0;
            H5Check.CheckState = CheckState.Checked;
            H6.Value = 0;
            H6Check.CheckState = CheckState.Checked;
            H7.Value = 0;
            H7Check.CheckState = CheckState.Checked;
            H8.Value = 0;
            H8Check.CheckState = CheckState.Checked;
            H9.Value = 0;
            H9Check.CheckState = CheckState.Checked;
            I1.Value = 0;
            I1Check.CheckState = CheckState.Checked;
            I2.Value = 0;
            I2Check.CheckState = CheckState.Checked;
            I3.Value = 0;
            I3Check.CheckState = CheckState.Checked;
            I4.Value = 0;
            I4Check.CheckState = CheckState.Checked;
            I5.Value = 0;
            I5Check.CheckState = CheckState.Checked;
            I6.Value = 0;
            I6Check.CheckState = CheckState.Checked;
            I7.Value = 0;
            I7Check.CheckState = CheckState.Checked;
            I8.Value = 0;
            I8Check.CheckState = CheckState.Checked;
            I9.Value = 0;
            I9Check.CheckState = CheckState.Checked;
        }

        private void OpenToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                RestoreDirectory = true,
                Filter = "|*.bin;*.sud|Zen of Sudoku|*.bin|Super Turbo Sudoku|*.sud",
                Title = "Load Sudoku Puzzle...",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = ofd.FileName;

                //Read the contents of the file into a stream
                if (Path.GetExtension(filePath) == ".sud")
                    Open.Super_Turbo_Sudoku(filePath);
                else if (Path.GetExtension(filePath) == ".bin")
                    Open.Zen_of_Sudoku(filePath);
                else throw new Exception("Fuck!");
            }
        }

        private void SaveToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            if (CheckValid() == false)
            {
                string message = "This is not a valid Sudodu puzzle.";
                string title = "Ivalid Puzzle";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = sfd.FileName;

                //Read the contents of the file into a stream
                Save.Zen_of_Sudoku(filePath);
            }
            else throw new Exception("Fuck!");
        }

        private bool CheckValid()
        {
            if (A1.Value + A2.Value + A3.Value + A4.Value + A5.Value + A6.Value + A7.Value + A8.Value + A9.Value != 45)
            { return false; }
            if (B1.Value + B2.Value + B3.Value + B4.Value + B5.Value + B6.Value + B7.Value + B8.Value + B9.Value != 45)
            { return false; }
            if (C1.Value + C2.Value + C3.Value + C4.Value + C5.Value + C6.Value + C7.Value + C8.Value + C9.Value != 45)
            { return false; }
            if (D1.Value + D2.Value + D3.Value + D4.Value + D5.Value + D6.Value + D7.Value + D8.Value + D9.Value != 45)
            { return false; }
            if (E1.Value + E2.Value + E3.Value + E4.Value + E5.Value + E6.Value + E7.Value + E8.Value + E9.Value != 45)
            { return false; }
            if (F1.Value + F2.Value + F3.Value + F4.Value + F5.Value + F6.Value + F7.Value + F8.Value + F9.Value != 45)
            { return false; }
            if (G1.Value + G2.Value + G3.Value + G4.Value + G5.Value + G6.Value + G7.Value + G8.Value + G9.Value != 45)
            { return false; }
            if (H1.Value + H2.Value + H3.Value + H4.Value + H5.Value + H6.Value + H7.Value + H8.Value + H9.Value != 45)
            { return false; }
            if (I1.Value + I2.Value + I3.Value + I4.Value + I5.Value + I6.Value + I7.Value + I8.Value + I9.Value != 45)
            { return false; }
            if (A1.Value + B1.Value + C1.Value + D1.Value + E1.Value + F1.Value + G1.Value + H1.Value + I1.Value != 45)
            { return false; }
            if (A2.Value + B2.Value + C2.Value + D2.Value + E2.Value + F2.Value + G2.Value + H2.Value + I2.Value != 45)
            { return false; }
            if (A3.Value + B3.Value + C3.Value + D3.Value + E3.Value + F3.Value + G3.Value + H3.Value + I3.Value != 45)
            { return false; }
            if (A4.Value + B4.Value + C4.Value + D4.Value + E4.Value + F4.Value + G4.Value + H4.Value + I4.Value != 45)
            { return false; }
            if (A5.Value + B5.Value + C5.Value + D5.Value + E5.Value + F5.Value + G5.Value + H5.Value + I5.Value != 45)
            { return false; }
            if (A6.Value + B6.Value + C6.Value + D6.Value + E6.Value + F6.Value + G6.Value + H6.Value + I6.Value != 45)
            { return false; }
            if (A7.Value + B7.Value + C7.Value + D7.Value + E7.Value + F7.Value + G7.Value + H7.Value + I7.Value != 45)
            { return false; }
            if (A8.Value + B8.Value + C8.Value + D8.Value + E8.Value + F8.Value + G8.Value + H8.Value + I8.Value != 45)
            { return false; }
            if (A9.Value + B9.Value + C9.Value + D9.Value + E9.Value + F9.Value + G9.Value + H9.Value + I9.Value != 45)
            { return false; }
            if (A1.Value + A2.Value + A3.Value + B1.Value + B2.Value + B3.Value + C1.Value + C2.Value + C3.Value != 45)
            { return false; }
            if (A4.Value + A5.Value + A6.Value + B4.Value + B5.Value + B6.Value + C4.Value + C5.Value + C6.Value != 45)
            { return false; }
            if (A7.Value + A8.Value + A9.Value + B7.Value + B8.Value + B9.Value + C7.Value + C8.Value + C9.Value != 45)
            { return false; }
            if (D1.Value + D2.Value + D3.Value + E1.Value + E2.Value + E3.Value + F1.Value + F2.Value + F3.Value != 45)
            { return false; }
            if (D4.Value + D5.Value + D6.Value + E4.Value + E5.Value + E6.Value + F4.Value + F5.Value + F6.Value != 45)
            { return false; }
            if (D7.Value + D8.Value + D9.Value + E7.Value + E8.Value + E9.Value + F7.Value + F8.Value + F9.Value != 45)
            { return false; }
            if (G1.Value + G2.Value + G3.Value + H1.Value + H2.Value + H3.Value + I1.Value + I2.Value + I3.Value != 45)
            { return false; }
            if (G4.Value + G5.Value + G6.Value + H4.Value + H5.Value + H6.Value + I4.Value + I5.Value + I6.Value != 45)
            { return false; }
            if (G7.Value + G8.Value + G9.Value + H7.Value + H8.Value + H9.Value + I7.Value + I8.Value + I9.Value != 45)
            { return false; }
            return true;

        }

        private void messageQueue1_ReceiveCompleted(object sender, System.Messaging.ReceiveCompletedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
