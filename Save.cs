﻿using System;
using System.IO;
namespace Sudoku_Editor
{
    public partial class Save
    {
        public static void Zen_of_Sudoku(string path)
        {
            BinaryWriter bw = new BinaryWriter(File.Create(path));
            bw.Write(2);
            bw.Write((long)Form1.A1.Value);
            bw.Write(0);
            bw.Write(Convert.ToInt64(Form1.A1Check.Enabled));
            bw.Write((long)Form1.A2.Value);
            bw.Write(1);
            bw.Write(Convert.ToInt64(Form1.A2Check.Enabled));
            bw.Write((long)Form1.A3.Value);
            bw.Write(2);
            bw.Write(Convert.ToInt64(Form1.A3Check.Enabled));
            bw.Write((long)Form1.A4.Value);
            bw.Write(3);
            bw.Write(Convert.ToInt64(Form1.A4Check.Enabled));
            bw.Write((long)Form1.A5.Value);
            bw.Write(4);
            bw.Write(Convert.ToInt64(Form1.A5Check.Enabled));
            bw.Write((long)Form1.A6.Value);
            bw.Write(5);
            bw.Write(Convert.ToInt64(Form1.A6Check.Enabled));
            bw.Write((long)Form1.A7.Value);
            bw.Write(6);
            bw.Write(Convert.ToInt64(Form1.A7Check.Enabled));
            bw.Write((long)Form1.A8.Value);
            bw.Write(7);
            bw.Write(Convert.ToInt64(Form1.A8Check.Enabled));
            bw.Write((long)Form1.A9.Value);
            bw.Write(8);
            bw.Write(Convert.ToInt64(Form1.B9Check.Enabled));
            bw.Write((long)Form1.B1.Value);
            bw.Write(9);
            bw.Write(Convert.ToInt64(Form1.B1Check.Enabled));
            bw.Write((long)Form1.B2.Value);
            bw.Write(10);
            bw.Write(Convert.ToInt64(Form1.B2Check.Enabled));
            bw.Write((long)Form1.B3.Value);
            bw.Write(11);
            bw.Write(Convert.ToInt64(Form1.B3Check.Enabled));
            bw.Write((long)Form1.B4.Value);
            bw.Write(12);
            bw.Write(Convert.ToInt64(Form1.B4Check.Enabled));
            bw.Write((long)Form1.B5.Value);
            bw.Write(13);
            bw.Write(Convert.ToInt64(Form1.B5Check.Enabled));
            bw.Write((long)Form1.B6.Value);
            bw.Write(14);
            bw.Write(Convert.ToInt64(Form1.B6Check.Enabled));
            bw.Write((long)Form1.B7.Value);
            bw.Write(15);
            bw.Write(Convert.ToInt64(Form1.B7Check.Enabled));
            bw.Write((long)Form1.B8.Value);
            bw.Write(16);
            bw.Write(Convert.ToInt64(Form1.B8Check.Enabled));
            bw.Write((long)Form1.B9.Value);
            bw.Write(17);
            bw.Write(Convert.ToInt64(Form1.B9Check.Enabled));
            bw.Write((long)Form1.C1.Value);
            bw.Write(18);
            bw.Write(Convert.ToInt64(Form1.C1Check.Enabled));
            bw.Write((long)Form1.C2.Value);
            bw.Write(19);
            bw.Write(Convert.ToInt64(Form1.C2Check.Enabled));
            bw.Write((long)Form1.C3.Value);
            bw.Write(20);
            bw.Write(Convert.ToInt64(Form1.C3Check.Enabled));
            bw.Write((long)Form1.C4.Value);
            bw.Write(21);
            bw.Write(Convert.ToInt64(Form1.C4Check.Enabled));
            bw.Write((long)Form1.C5.Value);
            bw.Write(22);
            bw.Write(Convert.ToInt64(Form1.C5Check.Enabled));
            bw.Write((long)Form1.C6.Value);
            bw.Write(23);
            bw.Write(Convert.ToInt64(Form1.C6Check.Enabled));
            bw.Write((long)Form1.C7.Value);
            bw.Write(24);
            bw.Write(Convert.ToInt64(Form1.C7Check.Enabled));
            bw.Write((long)Form1.C8.Value);
            bw.Write(25);
            bw.Write(Convert.ToInt64(Form1.C8Check.Enabled));
            bw.Write((long)Form1.C9.Value);
            bw.Write(26);
            bw.Write(Convert.ToInt64(Form1.C9Check.Enabled));
            bw.Write((long)Form1.D1.Value);
            bw.Write(27);
            bw.Write(Convert.ToInt64(Form1.D1Check.Enabled));
            bw.Write((long)Form1.D2.Value);
            bw.Write(28);
            bw.Write(Convert.ToInt64(Form1.D2Check.Enabled));
            bw.Write((long)Form1.D3.Value);
            bw.Write(29);
            bw.Write(Convert.ToInt64(Form1.D3Check.Enabled));
            bw.Write((long)Form1.D4.Value);
            bw.Write(30);
            bw.Write(Convert.ToInt64(Form1.D4Check.Enabled));
            bw.Write((long)Form1.D5.Value);
            bw.Write(31);
            bw.Write(Convert.ToInt64(Form1.D5Check.Enabled));
            bw.Write((long)Form1.D6.Value);
            bw.Write(32);
            bw.Write(Convert.ToInt64(Form1.D6Check.Enabled));
            bw.Write((long)Form1.D7.Value);
            bw.Write(33);
            bw.Write(Convert.ToInt64(Form1.D7Check.Enabled));
            bw.Write((long)Form1.D8.Value);
            bw.Write(34);
            bw.Write(Convert.ToInt64(Form1.D8Check.Enabled));
            bw.Write((long)Form1.D9.Value);
            bw.Write(35);
            bw.Write(Convert.ToInt64(Form1.D9Check.Enabled));
            bw.Write((long)Form1.E1.Value);
            bw.Write(36);
            bw.Write(Convert.ToInt64(Form1.E1Check.Enabled));
            bw.Write((long)Form1.E2.Value);
            bw.Write(37);
            bw.Write(Convert.ToInt64(Form1.E2Check.Enabled));
            bw.Write((long)Form1.E3.Value);
            bw.Write(38);
            bw.Write(Convert.ToInt64(Form1.E3Check.Enabled));
            bw.Write((long)Form1.E4.Value);
            bw.Write(39);
            bw.Write(Convert.ToInt64(Form1.E4Check.Enabled));
            bw.Write((long)Form1.E5.Value);
            bw.Write(40);
            bw.Write(Convert.ToInt64(Form1.E5Check.Enabled));
            bw.Write((long)Form1.E6.Value);
            bw.Write(41);
            bw.Write(Convert.ToInt64(Form1.E6Check.Enabled));
            bw.Write((long)Form1.E7.Value);
            bw.Write(42);
            bw.Write(Convert.ToInt64(Form1.E7Check.Enabled));
            bw.Write((long)Form1.E8.Value);
            bw.Write(43);
            bw.Write(Convert.ToInt64(Form1.E8Check.Enabled));
            bw.Write((long)Form1.E9.Value);
            bw.Write(44);
            bw.Write(Convert.ToInt64(Form1.F9Check.Enabled));
            bw.Write((long)Form1.F1.Value);
            bw.Write(45);
            bw.Write(Convert.ToInt64(Form1.F1Check.Enabled));
            bw.Write((long)Form1.F2.Value);
            bw.Write(46);
            bw.Write(Convert.ToInt64(Form1.F2Check.Enabled));
            bw.Write((long)Form1.F3.Value);
            bw.Write(47);
            bw.Write(Convert.ToInt64(Form1.F3Check.Enabled));
            bw.Write((long)Form1.F4.Value);
            bw.Write(48);
            bw.Write(Convert.ToInt64(Form1.F4Check.Enabled));
            bw.Write((long)Form1.F5.Value);
            bw.Write(49);
            bw.Write(Convert.ToInt64(Form1.F5Check.Enabled));
            bw.Write((long)Form1.F6.Value);
            bw.Write(50);
            bw.Write(Convert.ToInt64(Form1.F6Check.Enabled));
            bw.Write((long)Form1.F7.Value);
            bw.Write(51);
            bw.Write(Convert.ToInt64(Form1.F7Check.Enabled));
            bw.Write((long)Form1.F8.Value);
            bw.Write(52);
            bw.Write(Convert.ToInt64(Form1.F8Check.Enabled));
            bw.Write((long)Form1.F9.Value);
            bw.Write(53);
            bw.Write(Convert.ToInt64(Form1.F9Check.Enabled));
            bw.Write((long)Form1.G1.Value);
            bw.Write(54);
            bw.Write(Convert.ToInt64(Form1.G1Check.Enabled));
            bw.Write((long)Form1.G2.Value);
            bw.Write(55);
            bw.Write(Convert.ToInt64(Form1.G2Check.Enabled));
            bw.Write((long)Form1.G3.Value);
            bw.Write(56);
            bw.Write(Convert.ToInt64(Form1.G3Check.Enabled));
            bw.Write((long)Form1.G4.Value);
            bw.Write(57);
            bw.Write(Convert.ToInt64(Form1.G4Check.Enabled));
            bw.Write((long)Form1.G5.Value);
            bw.Write(58);
            bw.Write(Convert.ToInt64(Form1.G5Check.Enabled));
            bw.Write((long)Form1.G6.Value);
            bw.Write(59);
            bw.Write(Convert.ToInt64(Form1.G6Check.Enabled));
            bw.Write((long)Form1.G7.Value);
            bw.Write(60);
            bw.Write(Convert.ToInt64(Form1.G7Check.Enabled));
            bw.Write((long)Form1.G8.Value);
            bw.Write(61);
            bw.Write(Convert.ToInt64(Form1.G8Check.Enabled));
            bw.Write((long)Form1.G9.Value);
            bw.Write(62);
            bw.Write(Convert.ToInt64(Form1.G9Check.Enabled));
            bw.Write((long)Form1.H1.Value);
            bw.Write(63);
            bw.Write(Convert.ToInt64(Form1.H1Check.Enabled));
            bw.Write((long)Form1.H2.Value);
            bw.Write(64);
            bw.Write(Convert.ToInt64(Form1.H2Check.Enabled));
            bw.Write((long)Form1.H3.Value);
            bw.Write(65);
            bw.Write(Convert.ToInt64(Form1.H3Check.Enabled));
            bw.Write((long)Form1.H4.Value);
            bw.Write(66);
            bw.Write(Convert.ToInt64(Form1.H4Check.Enabled));
            bw.Write((long)Form1.H5.Value);
            bw.Write(67);
            bw.Write(Convert.ToInt64(Form1.H5Check.Enabled));
            bw.Write((long)Form1.H6.Value);
            bw.Write(68);
            bw.Write(Convert.ToInt64(Form1.H6Check.Enabled));
            bw.Write((long)Form1.H7.Value);
            bw.Write(69);
            bw.Write(Convert.ToInt64(Form1.H7Check.Enabled));
            bw.Write((long)Form1.H8.Value);
            bw.Write(70);
            bw.Write(Convert.ToInt64(Form1.H8Check.Enabled));
            bw.Write((long)Form1.H9.Value);
            bw.Write(71);
            bw.Write(Convert.ToInt64(Form1.H9Check.Enabled));
            bw.Write((long)Form1.I1.Value);
            bw.Write(72);
            bw.Write(Convert.ToInt64(Form1.I1Check.Enabled));
            bw.Write((long)Form1.I2.Value);
            bw.Write(73);
            bw.Write(Convert.ToInt64(Form1.I2Check.Enabled));
            bw.Write((long)Form1.I3.Value);
            bw.Write(74);
            bw.Write(Convert.ToInt64(Form1.I3Check.Enabled));
            bw.Write((long)Form1.I4.Value);
            bw.Write(75);
            bw.Write(Convert.ToInt64(Form1.I4Check.Enabled));
            bw.Write((long)Form1.I5.Value);
            bw.Write(76);
            bw.Write(Convert.ToInt64(Form1.I5Check.Enabled));
            bw.Write((long)Form1.I6.Value);
            bw.Write(77);
            bw.Write(Convert.ToInt64(Form1.I6Check.Enabled));
            bw.Write((long)Form1.I7.Value);
            bw.Write(78);
            bw.Write(Convert.ToInt64(Form1.I7Check.Enabled));
            bw.Write((long)Form1.I8.Value);
            bw.Write(79);
            bw.Write(Convert.ToInt64(Form1.I8Check.Enabled));
            bw.Write((long)Form1.I9.Value);
            bw.Write(80);
            bw.Write(Convert.ToInt64(Form1.I9Check.Enabled));
            bw.Close();
        }

        public void Super_Turbo_Sudoku()
        { }
    }
}