namespace RTE_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textCommandBox = new System.Windows.Forms.TextBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetFOV = new System.Windows.Forms.Button();
            this.buttonNoClip = new System.Windows.Forms.Button();
            this.textMapEntry = new System.Windows.Forms.TextBox();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.textCBUFEntry = new System.Windows.Forms.TextBox();
            this.richTextGameList = new System.Windows.Forms.RichTextBox();
            this.buttonList = new System.Windows.Forms.Button();
            this.groupCommands = new System.Windows.Forms.GroupBox();
            this.buttonGodmode = new System.Windows.Forms.Button();
            this.buttonUFO = new System.Windows.Forms.Button();
            this.checkShowWeapon = new System.Windows.Forms.CheckBox();
            this.groupLauch = new System.Windows.Forms.GroupBox();
            this.groupEntry = new System.Windows.Forms.GroupBox();
            this.checkShowHUD = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSpeedTenThousand = new System.Windows.Forms.Button();
            this.buttonSpeed1000 = new System.Windows.Forms.Button();
            this.buttonSpeed50 = new System.Windows.Forms.Button();
            this.buttonSpeedDefault = new System.Windows.Forms.Button();
            this.checkInfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkToggleAI = new System.Windows.Forms.CheckBox();
            this.buttonSoftFreeze = new System.Windows.Forms.Button();
            this.buttonPauseGame = new System.Windows.Forms.Button();
            this.buttonWarning = new System.Windows.Forms.Button();
            this.groupCommands.SuspendLayout();
            this.groupLauch.SuspendLayout();
            this.groupEntry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Silver;
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(11, 21);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(159, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textCommandBox
            // 
            this.textCommandBox.BackColor = System.Drawing.SystemColors.Info;
            this.textCommandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCommandBox.Enabled = false;
            this.textCommandBox.Location = new System.Drawing.Point(11, 19);
            this.textCommandBox.Name = "textCommandBox";
            this.textCommandBox.Size = new System.Drawing.Size(159, 20);
            this.textCommandBox.TabIndex = 2;
            this.textCommandBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.BackColor = System.Drawing.Color.Silver;
            this.buttonSendCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendCommand.Enabled = false;
            this.buttonSendCommand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendCommand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendCommand.Location = new System.Drawing.Point(11, 45);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(159, 23);
            this.buttonSendCommand.TabIndex = 3;
            this.buttonSendCommand.Text = "Send Command";
            this.buttonSendCommand.UseVisualStyleBackColor = false;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(288, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 9;
            // 
            // buttonSetFOV
            // 
            this.buttonSetFOV.BackColor = System.Drawing.Color.Silver;
            this.buttonSetFOV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetFOV.Enabled = false;
            this.buttonSetFOV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetFOV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetFOV.Location = new System.Drawing.Point(6, 21);
            this.buttonSetFOV.Name = "buttonSetFOV";
            this.buttonSetFOV.Size = new System.Drawing.Size(101, 23);
            this.buttonSetFOV.TabIndex = 11;
            this.buttonSetFOV.Text = "90 FOV";
            this.buttonSetFOV.UseVisualStyleBackColor = false;
            this.buttonSetFOV.Click += new System.EventHandler(this.buttonSetFOV_Click);
            // 
            // buttonNoClip
            // 
            this.buttonNoClip.BackColor = System.Drawing.Color.Silver;
            this.buttonNoClip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNoClip.Enabled = false;
            this.buttonNoClip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNoClip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNoClip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonNoClip.Location = new System.Drawing.Point(6, 50);
            this.buttonNoClip.Name = "buttonNoClip";
            this.buttonNoClip.Size = new System.Drawing.Size(101, 23);
            this.buttonNoClip.TabIndex = 12;
            this.buttonNoClip.Text = "NoClip";
            this.buttonNoClip.UseVisualStyleBackColor = false;
            this.buttonNoClip.Click += new System.EventHandler(this.buttonNoClip_Click);
            // 
            // textMapEntry
            // 
            this.textMapEntry.BackColor = System.Drawing.SystemColors.Info;
            this.textMapEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMapEntry.Enabled = false;
            this.textMapEntry.Location = new System.Drawing.Point(11, 74);
            this.textMapEntry.Name = "textMapEntry";
            this.textMapEntry.Size = new System.Drawing.Size(159, 20);
            this.textMapEntry.TabIndex = 13;
            this.textMapEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLoadMap
            // 
            this.buttonLoadMap.BackColor = System.Drawing.Color.Silver;
            this.buttonLoadMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadMap.Enabled = false;
            this.buttonLoadMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoadMap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadMap.Location = new System.Drawing.Point(11, 101);
            this.buttonLoadMap.Name = "buttonLoadMap";
            this.buttonLoadMap.Size = new System.Drawing.Size(159, 23);
            this.buttonLoadMap.TabIndex = 18;
            this.buttonLoadMap.Text = "Load Map Name";
            this.buttonLoadMap.UseVisualStyleBackColor = false;
            this.buttonLoadMap.Click += new System.EventHandler(this.buttonLoadMap_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.BackColor = System.Drawing.Color.Silver;
            this.buttonCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCredits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCredits.Location = new System.Drawing.Point(459, 208);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(78, 23);
            this.buttonCredits.TabIndex = 4;
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.UseVisualStyleBackColor = false;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // textCBUFEntry
            // 
            this.textCBUFEntry.BackColor = System.Drawing.SystemColors.Info;
            this.textCBUFEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCBUFEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCBUFEntry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCBUFEntry.Location = new System.Drawing.Point(37, 50);
            this.textCBUFEntry.MaxLength = 10;
            this.textCBUFEntry.Name = "textCBUFEntry";
            this.textCBUFEntry.Size = new System.Drawing.Size(133, 23);
            this.textCBUFEntry.TabIndex = 19;
            this.textCBUFEntry.Text = "Enter Cbuf";
            this.textCBUFEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextGameList
            // 
            this.richTextGameList.BackColor = System.Drawing.SystemColors.Info;
            this.richTextGameList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextGameList.Location = new System.Drawing.Point(9, 252);
            this.richTextGameList.Name = "richTextGameList";
            this.richTextGameList.ReadOnly = true;
            this.richTextGameList.Size = new System.Drawing.Size(563, 362);
            this.richTextGameList.TabIndex = 20;
            this.richTextGameList.Text = resources.GetString("richTextGameList.Text");
            this.richTextGameList.Visible = false;
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonList.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(11, 50);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(23, 23);
            this.buttonList.TabIndex = 21;
            this.buttonList.Text = "?";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // groupCommands
            // 
            this.groupCommands.Controls.Add(this.buttonGodmode);
            this.groupCommands.Controls.Add(this.buttonUFO);
            this.groupCommands.Controls.Add(this.buttonSetFOV);
            this.groupCommands.Controls.Add(this.buttonNoClip);
            this.groupCommands.Location = new System.Drawing.Point(331, 12);
            this.groupCommands.Name = "groupCommands";
            this.groupCommands.Size = new System.Drawing.Size(113, 138);
            this.groupCommands.TabIndex = 22;
            this.groupCommands.TabStop = false;
            this.groupCommands.Text = "Quick Commands";
            // 
            // buttonGodmode
            // 
            this.buttonGodmode.BackColor = System.Drawing.Color.Silver;
            this.buttonGodmode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGodmode.Enabled = false;
            this.buttonGodmode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGodmode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGodmode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonGodmode.Location = new System.Drawing.Point(6, 108);
            this.buttonGodmode.Name = "buttonGodmode";
            this.buttonGodmode.Size = new System.Drawing.Size(101, 23);
            this.buttonGodmode.TabIndex = 14;
            this.buttonGodmode.Text = "GodMode";
            this.buttonGodmode.UseVisualStyleBackColor = false;
            this.buttonGodmode.Click += new System.EventHandler(this.buttonGodmode_Click);
            // 
            // buttonUFO
            // 
            this.buttonUFO.BackColor = System.Drawing.Color.Silver;
            this.buttonUFO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUFO.Enabled = false;
            this.buttonUFO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUFO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUFO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonUFO.Location = new System.Drawing.Point(6, 79);
            this.buttonUFO.Name = "buttonUFO";
            this.buttonUFO.Size = new System.Drawing.Size(101, 23);
            this.buttonUFO.TabIndex = 13;
            this.buttonUFO.Text = "UFO";
            this.buttonUFO.UseVisualStyleBackColor = false;
            this.buttonUFO.Click += new System.EventHandler(this.buttonUFO_Click);
            // 
            // checkShowWeapon
            // 
            this.checkShowWeapon.AutoSize = true;
            this.checkShowWeapon.Checked = true;
            this.checkShowWeapon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowWeapon.Enabled = false;
            this.checkShowWeapon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowWeapon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkShowWeapon.Location = new System.Drawing.Point(6, 145);
            this.checkShowWeapon.Name = "checkShowWeapon";
            this.checkShowWeapon.Size = new System.Drawing.Size(104, 19);
            this.checkShowWeapon.TabIndex = 19;
            this.checkShowWeapon.Text = "Show Weapon";
            this.checkShowWeapon.UseVisualStyleBackColor = true;
            this.checkShowWeapon.CheckedChanged += new System.EventHandler(this.checkShowWeapon_CheckedChanged);
            // 
            // groupLauch
            // 
            this.groupLauch.Controls.Add(this.buttonConnect);
            this.groupLauch.Controls.Add(this.textCBUFEntry);
            this.groupLauch.Controls.Add(this.buttonList);
            this.groupLauch.Location = new System.Drawing.Point(9, 12);
            this.groupLauch.Name = "groupLauch";
            this.groupLauch.Size = new System.Drawing.Size(179, 83);
            this.groupLauch.TabIndex = 23;
            this.groupLauch.TabStop = false;
            this.groupLauch.Text = "Launch Controls";
            // 
            // groupEntry
            // 
            this.groupEntry.Controls.Add(this.textCommandBox);
            this.groupEntry.Controls.Add(this.buttonSendCommand);
            this.groupEntry.Controls.Add(this.textMapEntry);
            this.groupEntry.Controls.Add(this.buttonLoadMap);
            this.groupEntry.Location = new System.Drawing.Point(9, 100);
            this.groupEntry.Name = "groupEntry";
            this.groupEntry.Size = new System.Drawing.Size(179, 131);
            this.groupEntry.TabIndex = 24;
            this.groupEntry.TabStop = false;
            this.groupEntry.Text = "Entry Section";
            // 
            // checkShowHUD
            // 
            this.checkShowHUD.AutoSize = true;
            this.checkShowHUD.Checked = true;
            this.checkShowHUD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowHUD.Enabled = false;
            this.checkShowHUD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowHUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkShowHUD.Location = new System.Drawing.Point(6, 167);
            this.checkShowHUD.Name = "checkShowHUD";
            this.checkShowHUD.Size = new System.Drawing.Size(85, 19);
            this.checkShowHUD.TabIndex = 20;
            this.checkShowHUD.Text = "Show HUD";
            this.checkShowHUD.UseVisualStyleBackColor = true;
            this.checkShowHUD.CheckedChanged += new System.EventHandler(this.checkShowHUD_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSpeedTenThousand);
            this.groupBox1.Controls.Add(this.buttonSpeed1000);
            this.groupBox1.Controls.Add(this.buttonSpeed50);
            this.groupBox1.Controls.Add(this.buttonSpeedDefault);
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 138);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed Config";
            // 
            // buttonSpeedTenThousand
            // 
            this.buttonSpeedTenThousand.BackColor = System.Drawing.Color.Silver;
            this.buttonSpeedTenThousand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpeedTenThousand.Enabled = false;
            this.buttonSpeedTenThousand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpeedTenThousand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeedTenThousand.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSpeedTenThousand.Location = new System.Drawing.Point(6, 109);
            this.buttonSpeedTenThousand.Name = "buttonSpeedTenThousand";
            this.buttonSpeedTenThousand.Size = new System.Drawing.Size(101, 23);
            this.buttonSpeedTenThousand.TabIndex = 18;
            this.buttonSpeedTenThousand.Text = "10000";
            this.buttonSpeedTenThousand.UseVisualStyleBackColor = false;
            this.buttonSpeedTenThousand.Click += new System.EventHandler(this.buttonSpeedTenThousand_Click);
            // 
            // buttonSpeed1000
            // 
            this.buttonSpeed1000.BackColor = System.Drawing.Color.Silver;
            this.buttonSpeed1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpeed1000.Enabled = false;
            this.buttonSpeed1000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpeed1000.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeed1000.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSpeed1000.Location = new System.Drawing.Point(6, 80);
            this.buttonSpeed1000.Name = "buttonSpeed1000";
            this.buttonSpeed1000.Size = new System.Drawing.Size(101, 23);
            this.buttonSpeed1000.TabIndex = 17;
            this.buttonSpeed1000.Text = "1000";
            this.buttonSpeed1000.UseVisualStyleBackColor = false;
            this.buttonSpeed1000.Click += new System.EventHandler(this.buttonSpeed1000_Click);
            // 
            // buttonSpeed50
            // 
            this.buttonSpeed50.BackColor = System.Drawing.Color.Silver;
            this.buttonSpeed50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpeed50.Enabled = false;
            this.buttonSpeed50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpeed50.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeed50.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSpeed50.Location = new System.Drawing.Point(6, 51);
            this.buttonSpeed50.Name = "buttonSpeed50";
            this.buttonSpeed50.Size = new System.Drawing.Size(101, 23);
            this.buttonSpeed50.TabIndex = 16;
            this.buttonSpeed50.Text = "50";
            this.buttonSpeed50.UseVisualStyleBackColor = false;
            this.buttonSpeed50.Click += new System.EventHandler(this.buttonSpeed50_Click);
            // 
            // buttonSpeedDefault
            // 
            this.buttonSpeedDefault.BackColor = System.Drawing.Color.Silver;
            this.buttonSpeedDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpeedDefault.Enabled = false;
            this.buttonSpeedDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpeedDefault.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeedDefault.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSpeedDefault.Location = new System.Drawing.Point(6, 22);
            this.buttonSpeedDefault.Name = "buttonSpeedDefault";
            this.buttonSpeedDefault.Size = new System.Drawing.Size(101, 23);
            this.buttonSpeedDefault.TabIndex = 15;
            this.buttonSpeedDefault.Text = "Default";
            this.buttonSpeedDefault.UseVisualStyleBackColor = false;
            this.buttonSpeedDefault.Click += new System.EventHandler(this.buttonSpeedDefault_Click);
            // 
            // checkInfiniteAmmo
            // 
            this.checkInfiniteAmmo.AutoSize = true;
            this.checkInfiniteAmmo.Enabled = false;
            this.checkInfiniteAmmo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInfiniteAmmo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkInfiniteAmmo.Location = new System.Drawing.Point(6, 123);
            this.checkInfiniteAmmo.Name = "checkInfiniteAmmo";
            this.checkInfiniteAmmo.Size = new System.Drawing.Size(104, 19);
            this.checkInfiniteAmmo.TabIndex = 21;
            this.checkInfiniteAmmo.Text = "Infinite Ammo";
            this.checkInfiniteAmmo.UseVisualStyleBackColor = true;
            this.checkInfiniteAmmo.CheckedChanged += new System.EventHandler(this.checkInfiniteAmmo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkToggleAI);
            this.groupBox2.Controls.Add(this.checkShowHUD);
            this.groupBox2.Controls.Add(this.checkInfiniteAmmo);
            this.groupBox2.Controls.Add(this.buttonSoftFreeze);
            this.groupBox2.Controls.Add(this.buttonPauseGame);
            this.groupBox2.Controls.Add(this.checkShowWeapon);
            this.groupBox2.Location = new System.Drawing.Point(203, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 219);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Options";
            // 
            // checkToggleAI
            // 
            this.checkToggleAI.AutoSize = true;
            this.checkToggleAI.Checked = true;
            this.checkToggleAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkToggleAI.Enabled = false;
            this.checkToggleAI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToggleAI.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkToggleAI.Location = new System.Drawing.Point(6, 189);
            this.checkToggleAI.Name = "checkToggleAI";
            this.checkToggleAI.Size = new System.Drawing.Size(77, 19);
            this.checkToggleAI.TabIndex = 22;
            this.checkToggleAI.Text = "Toggle AI";
            this.checkToggleAI.UseVisualStyleBackColor = true;
            this.checkToggleAI.CheckedChanged += new System.EventHandler(this.checkToggleAI_CheckedChanged);
            // 
            // buttonSoftFreeze
            // 
            this.buttonSoftFreeze.BackColor = System.Drawing.Color.Silver;
            this.buttonSoftFreeze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoftFreeze.Enabled = false;
            this.buttonSoftFreeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSoftFreeze.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoftFreeze.Location = new System.Drawing.Point(6, 51);
            this.buttonSoftFreeze.Name = "buttonSoftFreeze";
            this.buttonSoftFreeze.Size = new System.Drawing.Size(101, 23);
            this.buttonSoftFreeze.TabIndex = 16;
            this.buttonSoftFreeze.Text = "Soft Freeze";
            this.buttonSoftFreeze.UseVisualStyleBackColor = false;
            this.buttonSoftFreeze.Click += new System.EventHandler(this.buttonSoftFreeze_Click);
            // 
            // buttonPauseGame
            // 
            this.buttonPauseGame.BackColor = System.Drawing.Color.Silver;
            this.buttonPauseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPauseGame.Enabled = false;
            this.buttonPauseGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPauseGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauseGame.Location = new System.Drawing.Point(6, 22);
            this.buttonPauseGame.Name = "buttonPauseGame";
            this.buttonPauseGame.Size = new System.Drawing.Size(101, 23);
            this.buttonPauseGame.TabIndex = 15;
            this.buttonPauseGame.Text = "Pause";
            this.buttonPauseGame.UseVisualStyleBackColor = false;
            this.buttonPauseGame.Click += new System.EventHandler(this.buttonPauseGame_Click);
            // 
            // buttonWarning
            // 
            this.buttonWarning.BackColor = System.Drawing.Color.Salmon;
            this.buttonWarning.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWarning.Location = new System.Drawing.Point(543, 208);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Size = new System.Drawing.Size(23, 23);
            this.buttonWarning.TabIndex = 22;
            this.buttonWarning.Text = "!";
            this.buttonWarning.UseVisualStyleBackColor = false;
            this.buttonWarning.Click += new System.EventHandler(this.buttonWarning_Click);
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(580, 238);
            this.Controls.Add(this.buttonWarning);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupEntry);
            this.Controls.Add(this.groupLauch);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.richTextGameList);
            this.Controls.Add(this.groupCommands);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alpha Commander v1.05";
            this.groupCommands.ResumeLayout(false);
            this.groupLauch.ResumeLayout(false);
            this.groupLauch.PerformLayout();
            this.groupEntry.ResumeLayout(false);
            this.groupEntry.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textCommandBox;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetFOV;
        private System.Windows.Forms.Button buttonNoClip;
        private System.Windows.Forms.TextBox textMapEntry;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.TextBox textCBUFEntry;
        private System.Windows.Forms.RichTextBox richTextGameList;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.GroupBox groupCommands;
        private System.Windows.Forms.GroupBox groupLauch;
        private System.Windows.Forms.GroupBox groupEntry;
        private System.Windows.Forms.CheckBox checkShowWeapon;
        private System.Windows.Forms.Button buttonUFO;
        private System.Windows.Forms.Button buttonGodmode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSpeedDefault;
        private System.Windows.Forms.Button buttonSpeedTenThousand;
        private System.Windows.Forms.Button buttonSpeed1000;
        private System.Windows.Forms.Button buttonSpeed50;
        private System.Windows.Forms.CheckBox checkShowHUD;
        private System.Windows.Forms.CheckBox checkInfiniteAmmo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSoftFreeze;
        private System.Windows.Forms.Button buttonPauseGame;
        private System.Windows.Forms.CheckBox checkToggleAI;
        private System.Windows.Forms.Button buttonWarning;
    }
}

