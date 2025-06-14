using System;
using System.Drawing;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;

//  Alpha Commander Source
//  1.07 - June 14, 2025

//724,277

namespace RTE_Tool
{
    public partial class Form1 : Form
    {
        private IXboxConsole Xbox360 = null;

        public static class Global
        {
            //
            //June 9 2025 - 1.07b
            //Nightly builds are deprecated. Releases will be pushed out once a week instead.
            //
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
            public static int thirdPerson = 0;
        }

        public Form1()
        {
            InitializeComponent();
            Nightly.Caller();



            int monthNumber = DateTime.Now.Month;

            if (monthNumber == 10)
            {
                //bland purple
                this.BackColor = Color.FromArgb(120, 110, 160);
                //halloween orange
                buttonConnect.BackColor = Color.FromArgb(218, 159, 7);
                buttonSendCommand.BackColor = Color.FromArgb(218, 159, 7);
                buttonLoadMap.BackColor = Color.FromArgb(218, 159, 7);
                buttonPauseGame.BackColor = Color.FromArgb(218, 159, 7);
                buttonLeaveSession.BackColor = Color.FromArgb(218, 159, 7);
                buttonSetFOV.BackColor = Color.FromArgb(218, 159, 7);
                buttonNoClip.BackColor = Color.FromArgb(218, 159, 7);
                buttonUFO.BackColor = Color.FromArgb(218, 159, 7);
                buttonGodmode.BackColor = Color.FromArgb(218, 159, 7);
                buttonSpeedDefault.BackColor = Color.FromArgb(218, 159, 7);
                buttonJumpDefault.BackColor = Color.FromArgb(218, 159, 7);
                buttonCredits.BackColor = Color.FromArgb(218, 159, 7);
            }


        }

        //
        //June 9 2025 - 1.07b
        //Nightly builds are deprecated. Releases will be pushed out once a week instead.
        //
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
                Xbox360.XNotify("Alpha Commander Connected!");
                textBoxCommands.Enabled = true;
                textBoxMapName.Enabled = true;
                textBoxMovementSpeed.Enabled = true;
                textBoxJumpHeight.Enabled = true;
                //
                buttonSendCommand.Enabled = true;
                buttonLoadMap.Enabled = true;
                buttonSetFOV.Enabled = true;
                buttonNoClip.Enabled = true;
                buttonGodmode.Enabled = true;
                buttonUFO.Enabled = true;
                buttonSpeedDefault.Enabled = true;
                buttonPauseGame.Enabled = true;
                buttonLeaveSession.Enabled = true;
                buttonJumpDefault.Enabled = true;
                //
                checkShowWeapon.Enabled = true;
                checkShowHUD.Enabled = true;
                checkInfiniteAmmo.Enabled = true;
                checkToggleAI.Enabled = true;
                checkFreezeClient.Enabled = true;
                checkThirdPerson.Enabled = true;
                //
                groupLaunch.Text = "Launch Controls - Connected!";
                buttonConnect.BackColor = Color.LightGreen;
            }
            else
            {
                buttonConnect.BackColor = Color.Salmon;
                MessageBox.Show("Tool is not connected."
                + Environment.NewLine + Environment.NewLine
                + "Is Xbox Neighborhood setup?"
                + Environment.NewLine + Environment.NewLine
                + "Is your RGH the Default Console?"
                , "Tool Alert");
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
                string tempCBUF = textBoxCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, textBoxCommands.Text);
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
                + "Version: 1.07" 
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
                string tempCBUF = textBoxCBUFEntry.Text;

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
                string tempCBUF = textBoxCBUFEntry.Text;

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
                string tempCBUF = textBoxCBUFEntry.Text;

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
                string tempCBUF = textBoxCBUFEntry.Text;

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
                string completeMapName = ("map " + textBoxMapName.Text);
                string tempCBUF = textBoxCBUFEntry.Text;

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
                string tempCBUF = textBoxCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_speed 190");
            }
        }
        ////////////////////////////////////////////////////////
        private void buttonJumpDefault_Click(object sender, EventArgs e)
        {
            if (Xbox360 == null)
            {
                MessageBox.Show("Tool is not connected.", "Tool Alert");
                return;
            }

            else
            {
                string tempCBUF = textBoxCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "jump_height 39");
            }
        }
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
                string tempCBUF = textBoxCBUFEntry.Text;

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
                string tempCBUF = textBoxCBUFEntry.Text;

                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "disconnect");
            }
        }
        ////////////////////////////////////////////////////////
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
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_drawGun 0");
            }

            else
            {
                Global.showWeapon = 1;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_drawGun 1");
            }
        }
        ////////////////////////////////////////////////////////
        private void checkShowHUD_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.showHUD == 1)
            {
                Global.showHUD = 0;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_draw2D 0");
            }

            else
            {
                Global.showHUD = 1;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_draw2D 1");
            }
        }
        ////////////////////////////////////////////////////////
        private void checkInfiniteAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.infiniteAmmo == 1)
            {
                Global.infiniteAmmo = 0;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "player_sustainAmmo 0");
            }

            else
            {
                Global.infiniteAmmo = 1;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "player_sustainAmmo 1");
            }
        }
        ////////////////////////////////////////////////////////
        private void checkToggleAI_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.toggleAI == 1)
            {
                Global.toggleAI = 0;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_ai 0");
            }

            else
            {
                Global.toggleAI = 1;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_ai 1");
            }
        }
        private void checkFreezeClient_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.clientFroze == 1)
            {
                Global.clientFroze = 0;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cl_paused 0");
            }

            else
            {
                Global.clientFroze = 1;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cl_paused 1");
            }
        }
        private void checkThirdPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (Global.thirdPerson == 1)
            {
                Global.thirdPerson = 0;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_thirdperson 0");
            }

            else
            {
                Global.thirdPerson = 1;
                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "cg_thirdperson 1");
            }
        }


        ////////////////////////////////////////////////////////
        ////                                                ////
        ////                      Events                    ////
        ////                                                ////
        ////////////////////////////////////////////////////////


        //CBUF box clears when user clicks into it.
        private void textBoxCBUFEntry_Enter(object sender, EventArgs e)
        {
            if (Global.initialized == 0)
            {
                textBoxCBUFEntry.Clear();
                Global.initialized = 1;
            }
            
        }

        private void textBoxCBUFEntry_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxCBUFEntry.SelectAll();
        }


        //Imitates a button click if you click ENTER while in the textbox.
        private void textBoxCommands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                buttonSendCommand_Click(this, new EventArgs());
                textBoxCommands.BackColor = Color.LightGreen;
            }
        }
        private void textBoxCommands_Leave(object sender, EventArgs e)
        {
            textBoxCommands.BackColor = Color.LightYellow;
        }


        //Imitates a button click if you click ENTER while in the textbox.
        private void textBoxMapName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                buttonLoadMap_Click(this, new EventArgs());
                textBoxMapName.BackColor = Color.LightGreen;
                //MessageBox.Show("Success received", "DEBUG");
            }
        }
        private void textBoxMapName_Leave(object sender, EventArgs e)
        {
            textBoxMapName.BackColor = Color.LightYellow;
        }


        private void textBoxMovementSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "g_speed " + textBoxMovementSpeed.Text);

                textBoxMovementSpeed.BackColor = Color.LightGreen;
            }
        }
        private void textBoxMovementSpeed_Leave(object sender, EventArgs e)
        {
            textBoxMovementSpeed.BackColor = Color.LightYellow;
        }



        private void textBoxJumpHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string tempCBUF = textBoxCBUFEntry.Text;
                Xbox360.CallVoid(uint.Parse(tempCBUF.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber), 0, "jump_height " + textBoxJumpHeight.Text);

                textBoxJumpHeight.BackColor = Color.LightGreen;
            }
        }

        private void textBoxCBUFEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                MessageBox.Show
                    (
                    "No need to press ENTER."
                    + Environment.NewLine + Environment.NewLine
                    +"Simply paste and continue!"
                    ,"Tool Alert");
            }
        }

        private void textBoxJumpHeight_Leave(object sender, EventArgs e)
        {
            textBoxJumpHeight.BackColor = Color.LightYellow;
        }

        private void textBoxCommands_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxCommands.SelectAll();
        }

        private void textBoxMapName_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxMapName.SelectAll();
        }

        private void textBoxMovementSpeed_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxMovementSpeed.SelectAll();
        }

        private void textBoxJumpHeight_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxJumpHeight.SelectAll();
        }
    }
}

