using System;
using System.Collections.Generic;
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

namespace RTE_Tool
{
    public partial class Form1 : Form
    {
        private IXboxConsole Xbox360 = null;

        public static class Global
        {
            public static int nCheck = 1;
            public static string nVersion = "x002";
            public static string nTitle = "Nightly Build " + nVersion;
            /// /// /// /// /// /// /// /// /// /// /// /// /// /// ///
            public static int helpButtonVisible = 0;
            public static int photoButtonPressed = 0;
            public static int weaponShown = 1;
            //public static int detected_Greenlight = 0;
            //public static int isDebug = 0;
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

        
        //string[] GreenlightList = { "0x822ff6e8", "822ff6e8 ", "f5y" };
        //822ff6e8 - DefaultMpPatch.xex

        //time to party
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (Xbox360.Connect(out Xbox360))
            {
                Nightly.Caller();
                Xbox360.XNotify("Tool Connected!");
                textCommandBox.Enabled = true;
                textMapEntry.Enabled = true;
                
                buttonSendCommand.Enabled = true;
                buttonLoadMap.Enabled = true;
                buttonSetFOV.Enabled = true;
                buttonNoClipGod.Enabled = true;

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
                + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Version: 25.02.03.01.02", "Credits");
        }
        ////////////////////////////////////////////////////////
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
