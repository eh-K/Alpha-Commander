using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;


//337,277

namespace RTE_Tool
{
    public partial class Form1 : Form
    {
        private IXboxConsole Xbox360 = null;

        public static class Global
        {
            public static int nCheck = 0;
            public static string nVersion = "x003";
            public static string nTitle = "Nightly Build " + nVersion;
            /// /// /// /// /// /// /// /// /// /// /// /// /// /// ///
            public static int helpButtonVisible = 0;
            public static int photoButtonPressed = 0;
            public static int weaponShown = 1;

            //List of every current public build

            public static int build_NX1-Dec1811 = 0;
            
            public static int build_MW1-Mar2307 = 0;
            public static int build_MW1-Apr1107 = 0;
            public static int build_MW1-May0407 = 0;
            public static int build_MW1-Jun1107 = 0;
            public static int build_MW1-Jul2507 = 0;
            public static int build_MW1-Sep0707 = 0;
            public static int build_MW1-WrCrash = 0;

            public static int build_WAW-Mar2007 = 0;
            public static int build_WAW-Mar2707 = 0;
            public static int build_WAW-May1107 = 0;
            public static int build_WAW-Sep2508 = 0;
            public static int build_WAW-Sep2708 = 0;
            public static int build_WAW-Oct1608 = 0;

            public static int build_MW2-Jul1309 = 0;
            public static int build_MW2-Jul0910 = 0;

            public static int build_BO1-Sep0410 = 0;
            public static int build_BO1-Sep0610 = 0;
            public static int build_BO1-Sep2610 = 0;
            //Feb0211 Demo
            public static int build_BO1-Feb0211 = 0;

            public static int build_MW3-Sep1911 = 0;
            public static int build_MW3-Oct1111 = 0;

            public static int build_BO2-Nov1511 = 0;
            public static int build_BO2-Jul2012 = 0;
            public static int build_BO2-Jul2312 = 0;
            public static int build_BO2-Aug2112 = 0;
            public static int build_BO2-Oct0212 = 0;
            public static int build_BO2-Oct1812 = 0;
            public static int build_BO2-Feb2613 = 0;
            public static int build_BO2-Jun1113 = 0;
            public static int build_BO2-Aug1013 = 0;
            public static int build_BO2-Sep0513 = 0;

            public static int build_Gho-May0913 = 0;
            public static int build_Gho-May2113 = 0;
            public static int build_Gho-Jul1913 = 0;
            public static int build_Gho-Aug2913 = 0;
            public static int build_Gho-Sep0213 = 0;
            public static int build_Gho-Sep0913 = 0;
            public static int build_Gho-Sep2313 = 0;
            //Mar0714 Demo
            public static int build_Gho-Mar0714 = 0;

            public static int build__AW-May0313 = 0;
            public static int build__AW-Sep0414 = 0;
            public static int build__AW-Sep1614 = 0;
        }

        public Form1()
        {
            InitializeComponent();
            Nightly.Caller();
        }

        public class Nightly
        {
            public static void Caller()
            {
                if (Global.nCheck == 1)
                {
                    MessageBox.Show("This is a nightly build. Issues may arise." + Environment.NewLine + Environment.NewLine + "If an issue is found, state the nightly version.", Global.nTitle);
                }
            }
        }

        //time to party
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (Xbox360.Connect(out Xbox360))
            {
                Nightly.Caller();
                Xbox360.XNotify("Tool Connected!");
                textCommandBox.Enabled = true;
                textMapEntry.Enabled = true;
                //
                buttonSendCommand.Enabled = true;
                buttonLoadMap.Enabled = true;
                buttonSetFOV.Enabled = true;
                buttonNoClipGod.Enabled = true;
                //
                checkShowWeapon.Enabled = true;
                groupLauch.Text = "Launch Controls - Connected!";
            }
            else
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }
        }
        ////////////////////////////////////////////////////////
        ////                                                ////
        ////                    Buttons                     ////
        ////                                                ////
        ////////////////////////////////////////////////////////
        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null) 
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, textCommandBox.Text);
                textCommandBox.Clear();
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tool made by JammingCat21"
                + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Special Thanks:" + Environment.NewLine + Environment.NewLine + "Heaventh" + Environment.NewLine + "Baked Muted" 
                + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Version: 25.02.03.01.03", "Credits");
            
        }
        ////////////////////////////////////////////////////////
        private void buttonSetFOV_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_fov 90");
                textCommandBox.Clear();
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonNoClipGod_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "noclip");
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "god");
                textCommandBox.Clear();
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonLoadMap_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string completeMapName = ("map " + textMapEntry.Text);
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, completeMapName);
                textCommandBox.Clear();
            }

        }
        ////////////////////////////////////////////////////////
        private void buttonList_Click(object sender, EventArgs e)
        {
            if (Global.helpButtonVisible == 0)
            {
                richTextGameList.Visible = true;
                Global.helpButtonVisible = 1;
                this.Width = (727);
                buttonList.BackColor = Color.Violet;
            }

            else
            {
                richTextGameList.Visible = false;
                Global.helpButtonVisible = 0;
                this.Width = (337);
                buttonList.BackColor = Color.PaleTurquoise;
            }
        }
        ////////////////////////////////////////////////////////
        ////                                                ////
        ////                  Check Boxes                   ////
        ////                                                ////
        ////////////////////////////////////////////////////////
        private void checkShowWeapon_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.weaponShown == 1)
            {
                Global.weaponShown = 0;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_drawGun 0");
            }

            else
            {
                Global.weaponShown = 1;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_drawGun 1");
            }
        }
    }
}