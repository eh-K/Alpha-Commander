using System;
using System.Drawing;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;


//596,277

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
            public static int showWeapon = 1;
            public static int showHUD = 1;
            public static int infiniteAmmo = 0;
            public static int toggleAI = 1;
            public static int clientFroze = 0;
            public static int initialized = 0;

            //List of every current public build
            //Ground work for possibly adding a drop-down. Idk

            public static int build_NX1_Dec1811 = 0;
            
            public static int build_MW1_Mar2307 = 0;
            public static int build_MW1_Apr1107 = 0;
            public static int build_MW1_May0407 = 0;
            public static int build_MW1_Jun1107 = 0;
            public static int build_MW1_Jul2507 = 0;
            public static int build_MW1_Sep0707 = 0;
            public static int build_MW1_WrCrash = 0;

            public static int build_WAW_Mar2007 = 0;
            public static int build_WAW_Mar2707 = 0;
            public static int build_WAW_May1107 = 0;
            public static int build_WAW_Sep2508 = 0;
            public static int build_WAW_Sep2708 = 0;
            public static int build_WAW_Oct1608 = 0;

            public static int build_MW2_Jul1309 = 0;
            public static int build_MW2_Jul0910 = 0;

            public static int build_BO1_Sep0410 = 0;
            public static int build_BO1_Sep0610 = 0;
            public static int build_BO1_Sep2610 = 0;
            //Feb0211 Demo
            public static int build_BO1_Feb0211 = 0;

            public static int build_MW3_Sep1911 = 0;
            public static int build_MW3_Oct1111 = 0;

            public static int build_BO2_Nov1511 = 0;
            public static int build_BO2_Jul2012 = 0;
            public static int build_BO2_Jul2312 = 0;
            public static int build_BO2_Aug2112 = 0;
            public static int build_BO2_Oct0212 = 0;
            public static int build_BO2_Oct1812 = 0;
            public static int build_BO2_Feb2613 = 0;
            public static int build_BO2_Jun1113 = 0;
            public static int build_BO2_Aug1013 = 0;
            public static int build_BO2_Sep0513 = 0;

            public static int build_Gho_May0913 = 0;
            public static int build_Gho_May2113 = 0;
            public static int build_Gho_Jul1913 = 0;
            public static int build_Gho_Aug2913 = 0;
            public static int build_Gho_Sep0213 = 0;
            public static int build_Gho_Sep0913 = 0;
            public static int build_Gho_Sep2313 = 0;
            //Mar0714 Demo
            public static int build_Gho_Mar0714 = 0;

            public static int build__AW_May0313 = 0;
            public static int build__AW_Sep0414 = 0;
            public static int build__AW_Sep1614 = 0;
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
                buttonNoClip.Enabled = true;
                buttonGodmode.Enabled = true;
                buttonUFO.Enabled = true;
                buttonSpeedDefault.Enabled = true;
                buttonSpeed50.Enabled = true;
                buttonSpeed1000.Enabled = true;
                buttonSpeedTenThousand.Enabled = true;
                buttonPauseGame.Enabled = true;
                buttonLeaveSession.Enabled = true;
                //
                checkShowWeapon.Enabled = true;
                checkShowHUD.Enabled = true;
                checkInfiniteAmmo.Enabled = true;
                checkToggleAI.Enabled = true;
                checkFreezeClient.Enabled = true;
                //
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
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tool by JammingCat21"
                + Environment.NewLine + Environment.NewLine + Environment.NewLine 
                + "Special Thanks:" 
                + Environment.NewLine + Environment.NewLine 
                + "Heaventh" 
                + Environment.NewLine 
                + "Baked Muted" 
                + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine 
                + "Version: 1.06" 
                + Environment.NewLine + Environment.NewLine
                + "https://github.com/bandito52/Alpha-Commander"
                , 
                "Credits");
            
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
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonNoClip_Click(object sender, EventArgs e)
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
                //Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "god");
                //textCommandBox.Clear();
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonUFO_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "ufo");
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonGodmode_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "god");
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
            }

        }
        ////////////////////////////////////////////////////////
        private void buttonSpeedDefault_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_speed 190");
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonSpeed50_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_speed 50");
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonSpeed1000_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_speed 1000");
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonSpeedTenThousand_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_speed 10000");
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonList_Click(object sender, EventArgs e)
        {
            if (Global.helpButtonVisible == 0)
            {
                richTextGameList.Visible = true;
                Global.helpButtonVisible = 1;
                this.Height = (663);
                buttonList.BackColor = Color.Violet;
            }

            else
            {
                richTextGameList.Visible = false;
                Global.helpButtonVisible = 0;
                this.Height = (277);
                buttonList.BackColor = Color.PaleTurquoise;
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonPauseGame_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "pause");
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonLeaveSession_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "disconnect");
            }
        }
        ////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////
        ////                                                ////
        ////                  Check Boxes                   ////
        ////                                                ////
        ////////////////////////////////////////////////////////


        private void checkShowWeapon_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.showWeapon == 1)
            {
                Global.showWeapon = 0;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_drawGun 0");
            }

            else
            {
                Global.showWeapon = 1;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_drawGun 1");
            }
        }
        ////////////////////////////////////////////////////////
        private void checkShowHUD_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.showHUD == 1)
            {
                Global.showHUD = 0;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_draw2D 0");
            }

            else
            {
                Global.showHUD = 1;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_draw2D 1");
            }
        }
        ////////////////////////////////////////////////////////
        private void checkInfiniteAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.infiniteAmmo == 1)
            {
                Global.infiniteAmmo = 0;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "player_sustainAmmo 0");
            }

            else
            {
                Global.infiniteAmmo = 1;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "player_sustainAmmo 1");
            }
        }
        ////////////////////////////////////////////////////////
        private void checkToggleAI_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.toggleAI == 1)
            {
                Global.toggleAI = 0;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_ai 0");
            }

            else
            {
                Global.toggleAI = 1;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_ai 1");
            }
        }

        private void buttonWarning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am not liable for any data loss, corruption, or hardware issues that may occur."
                + Environment.NewLine + Environment.NewLine
                + "This tool is simply a command runner."
                + Environment.NewLine + Environment.NewLine
                + "Use commands responsibly."
                + Environment.NewLine + Environment.NewLine
                ,
                "Disclaimer");

        }

        private void checkFreezeClient_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.clientFroze == 1)
            {
                Global.clientFroze = 0;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cl_paused 0");
            }

            else
            {
                Global.clientFroze = 1;
                string tempCBUF = textCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cl_paused 1");
            }
        }

        private void textCBUFEntry_Enter(object sender, EventArgs e)
        {
            if (Global.initialized == 0)
            {
                textCBUFEntry.Clear();
                Global.initialized = 1;
            }

            //Xbox360.XboxAutomation.DisconnectController(0, XBOX_USER);
        }
    }
}
