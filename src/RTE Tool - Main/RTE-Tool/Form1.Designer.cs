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
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetFOV = new System.Windows.Forms.Button();
            this.buttonNoClip = new System.Windows.Forms.Button();
            this.textBoxMapName = new System.Windows.Forms.TextBox();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.textBoxCBUFEntry = new System.Windows.Forms.TextBox();
            this.richTextGameList = new System.Windows.Forms.RichTextBox();
            this.buttonList = new System.Windows.Forms.Button();
            this.groupCommands = new System.Windows.Forms.GroupBox();
            this.buttonGodmode = new System.Windows.Forms.Button();
            this.buttonUFO = new System.Windows.Forms.Button();
            this.checkShowWeapon = new System.Windows.Forms.CheckBox();
            this.groupLaunch = new System.Windows.Forms.GroupBox();
            this.groupEntry = new System.Windows.Forms.GroupBox();
            this.checkShowHUD = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMovementSpeed = new System.Windows.Forms.TextBox();
            this.buttonSpeedDefault = new System.Windows.Forms.Button();
            this.checkInfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkThirdPerson = new System.Windows.Forms.CheckBox();
            this.buttonLeaveSession = new System.Windows.Forms.Button();
            this.checkFreezeClient = new System.Windows.Forms.CheckBox();
            this.checkToggleAI = new System.Windows.Forms.CheckBox();
            this.buttonPauseGame = new System.Windows.Forms.Button();
            this.buttonWarning = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxJumpHeight = new System.Windows.Forms.TextBox();
            this.buttonJumpDefault = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupCommands.SuspendLayout();
            this.groupLaunch.SuspendLayout();
            this.groupEntry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // textBoxCommands
            // 
            this.textBoxCommands.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCommands.Enabled = false;
            this.textBoxCommands.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommands.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxCommands.Location = new System.Drawing.Point(11, 19);
            this.textBoxCommands.MaxLength = 50;
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(159, 23);
            this.textBoxCommands.TabIndex = 2;
            this.textBoxCommands.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCommands.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCommands_MouseClick);
            this.textBoxCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCommands_KeyDown);
            this.textBoxCommands.Leave += new System.EventHandler(this.textBoxCommands_Leave);
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
            this.buttonSetFOV.Location = new System.Drawing.Point(6, 22);
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
            this.buttonNoClip.Location = new System.Drawing.Point(6, 109);
            this.buttonNoClip.Name = "buttonNoClip";
            this.buttonNoClip.Size = new System.Drawing.Size(101, 23);
            this.buttonNoClip.TabIndex = 12;
            this.buttonNoClip.Text = "NoClip";
            this.buttonNoClip.UseVisualStyleBackColor = false;
            this.buttonNoClip.Click += new System.EventHandler(this.buttonNoClip_Click);
            // 
            // textBoxMapName
            // 
            this.textBoxMapName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMapName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMapName.Enabled = false;
            this.textBoxMapName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMapName.Location = new System.Drawing.Point(11, 74);
            this.textBoxMapName.MaxLength = 50;
            this.textBoxMapName.Name = "textBoxMapName";
            this.textBoxMapName.Size = new System.Drawing.Size(159, 23);
            this.textBoxMapName.TabIndex = 13;
            this.textBoxMapName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMapName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMapName_MouseClick);
            this.textBoxMapName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMapName_KeyDown);
            this.textBoxMapName.Leave += new System.EventHandler(this.textBoxMapName_Leave);
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
            this.buttonCredits.Location = new System.Drawing.Point(465, 208);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(72, 23);
            this.buttonCredits.TabIndex = 4;
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.UseVisualStyleBackColor = false;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // textBoxCBUFEntry
            // 
            this.textBoxCBUFEntry.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCBUFEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCBUFEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBUFEntry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCBUFEntry.Location = new System.Drawing.Point(37, 50);
            this.textBoxCBUFEntry.MaxLength = 10;
            this.textBoxCBUFEntry.Name = "textBoxCBUFEntry";
            this.textBoxCBUFEntry.Size = new System.Drawing.Size(133, 23);
            this.textBoxCBUFEntry.TabIndex = 19;
            this.textBoxCBUFEntry.Text = "Enter Cbuf";
            this.textBoxCBUFEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCBUFEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCBUFEntry_MouseClick);
            this.textBoxCBUFEntry.Enter += new System.EventHandler(this.textBoxCBUFEntry_Enter);
            this.textBoxCBUFEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCBUFEntry_KeyDown);
            this.textBoxCBUFEntry.Leave += new System.EventHandler(this.textBoxCBUFEntry_Leave);
            // 
            // richTextGameList
            // 
            this.richTextGameList.BackColor = System.Drawing.SystemColors.Info;
            this.richTextGameList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(11, 50);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(23, 23);
            this.buttonList.TabIndex = 21;
            this.buttonList.Text = "?🔄️";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // groupCommands
            // 
            this.groupCommands.Controls.Add(this.buttonGodmode);
            this.groupCommands.Controls.Add(this.buttonUFO);
            this.groupCommands.Controls.Add(this.buttonSetFOV);
            this.groupCommands.Controls.Add(this.buttonNoClip);
            this.groupCommands.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCommands.Location = new System.Drawing.Point(331, 12);
            this.groupCommands.Name = "groupCommands";
            this.groupCommands.Size = new System.Drawing.Size(113, 172);
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
            this.buttonGodmode.Location = new System.Drawing.Point(6, 51);
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
            this.buttonUFO.Location = new System.Drawing.Point(6, 80);
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
            this.checkShowWeapon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowWeapon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkShowWeapon.Location = new System.Drawing.Point(5, 145);
            this.checkShowWeapon.Name = "checkShowWeapon";
            this.checkShowWeapon.Size = new System.Drawing.Size(106, 19);
            this.checkShowWeapon.TabIndex = 19;
            this.checkShowWeapon.Text = "Show Weapon";
            this.checkShowWeapon.UseVisualStyleBackColor = true;
            this.checkShowWeapon.CheckedChanged += new System.EventHandler(this.checkShowWeapon_CheckedChanged);
            // 
            // groupLaunch
            // 
            this.groupLaunch.Controls.Add(this.buttonConnect);
            this.groupLaunch.Controls.Add(this.textBoxCBUFEntry);
            this.groupLaunch.Controls.Add(this.buttonList);
            this.groupLaunch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLaunch.Location = new System.Drawing.Point(9, 12);
            this.groupLaunch.Name = "groupLaunch";
            this.groupLaunch.Size = new System.Drawing.Size(179, 83);
            this.groupLaunch.TabIndex = 23;
            this.groupLaunch.TabStop = false;
            this.groupLaunch.Text = "Launch Controls";
            // 
            // groupEntry
            // 
            this.groupEntry.Controls.Add(this.textBoxCommands);
            this.groupEntry.Controls.Add(this.buttonSendCommand);
            this.groupEntry.Controls.Add(this.textBoxMapName);
            this.groupEntry.Controls.Add(this.buttonLoadMap);
            this.groupEntry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.checkShowHUD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowHUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkShowHUD.Location = new System.Drawing.Point(5, 167);
            this.checkShowHUD.Name = "checkShowHUD";
            this.checkShowHUD.Size = new System.Drawing.Size(87, 19);
            this.checkShowHUD.TabIndex = 20;
            this.checkShowHUD.Text = "Show HUD";
            this.checkShowHUD.UseVisualStyleBackColor = true;
            this.checkShowHUD.CheckedChanged += new System.EventHandler(this.checkShowHUD_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMovementSpeed);
            this.groupBox1.Controls.Add(this.buttonSpeedDefault);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 83);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movement Speed";
            // 
            // textBoxMovementSpeed
            // 
            this.textBoxMovementSpeed.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMovementSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMovementSpeed.Enabled = false;
            this.textBoxMovementSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovementSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxMovementSpeed.Location = new System.Drawing.Point(6, 51);
            this.textBoxMovementSpeed.MaxLength = 4;
            this.textBoxMovementSpeed.Name = "textBoxMovementSpeed";
            this.textBoxMovementSpeed.Size = new System.Drawing.Size(101, 23);
            this.textBoxMovementSpeed.TabIndex = 20;
            this.textBoxMovementSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMovementSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMovementSpeed_MouseClick);
            this.textBoxMovementSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMovementSpeed_KeyDown);
            this.textBoxMovementSpeed.Leave += new System.EventHandler(this.textBoxMovementSpeed_Leave);
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
            this.buttonSpeedDefault.Text = "Default (190)";
            this.buttonSpeedDefault.UseVisualStyleBackColor = false;
            this.buttonSpeedDefault.Click += new System.EventHandler(this.buttonSpeedDefault_Click);
            // 
            // checkInfiniteAmmo
            // 
            this.checkInfiniteAmmo.AutoSize = true;
            this.checkInfiniteAmmo.Enabled = false;
            this.checkInfiniteAmmo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInfiniteAmmo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkInfiniteAmmo.Location = new System.Drawing.Point(5, 98);
            this.checkInfiniteAmmo.Name = "checkInfiniteAmmo";
            this.checkInfiniteAmmo.Size = new System.Drawing.Size(107, 19);
            this.checkInfiniteAmmo.TabIndex = 21;
            this.checkInfiniteAmmo.Text = "Infinite Ammo";
            this.checkInfiniteAmmo.UseVisualStyleBackColor = true;
            this.checkInfiniteAmmo.CheckedChanged += new System.EventHandler(this.checkInfiniteAmmo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkThirdPerson);
            this.groupBox2.Controls.Add(this.buttonLeaveSession);
            this.groupBox2.Controls.Add(this.checkFreezeClient);
            this.groupBox2.Controls.Add(this.checkToggleAI);
            this.groupBox2.Controls.Add(this.checkShowHUD);
            this.groupBox2.Controls.Add(this.checkInfiniteAmmo);
            this.groupBox2.Controls.Add(this.buttonPauseGame);
            this.groupBox2.Controls.Add(this.checkShowWeapon);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(203, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 219);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Options";
            // 
            // checkThirdPerson
            // 
            this.checkThirdPerson.AutoSize = true;
            this.checkThirdPerson.Enabled = false;
            this.checkThirdPerson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkThirdPerson.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkThirdPerson.Location = new System.Drawing.Point(5, 116);
            this.checkThirdPerson.Name = "checkThirdPerson";
            this.checkThirdPerson.Size = new System.Drawing.Size(96, 19);
            this.checkThirdPerson.TabIndex = 25;
            this.checkThirdPerson.Text = "Third Person";
            this.checkThirdPerson.UseVisualStyleBackColor = true;
            this.checkThirdPerson.CheckedChanged += new System.EventHandler(this.checkThirdPerson_CheckedChanged);
            // 
            // buttonLeaveSession
            // 
            this.buttonLeaveSession.BackColor = System.Drawing.Color.Silver;
            this.buttonLeaveSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaveSession.Enabled = false;
            this.buttonLeaveSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeaveSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaveSession.Location = new System.Drawing.Point(6, 51);
            this.buttonLeaveSession.Name = "buttonLeaveSession";
            this.buttonLeaveSession.Size = new System.Drawing.Size(101, 23);
            this.buttonLeaveSession.TabIndex = 24;
            this.buttonLeaveSession.Text = "Disconnect";
            this.buttonLeaveSession.UseVisualStyleBackColor = false;
            this.buttonLeaveSession.Click += new System.EventHandler(this.buttonLeaveSession_Click);
            // 
            // checkFreezeClient
            // 
            this.checkFreezeClient.AutoSize = true;
            this.checkFreezeClient.Enabled = false;
            this.checkFreezeClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFreezeClient.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkFreezeClient.Location = new System.Drawing.Point(5, 80);
            this.checkFreezeClient.Name = "checkFreezeClient";
            this.checkFreezeClient.Size = new System.Drawing.Size(99, 19);
            this.checkFreezeClient.TabIndex = 23;
            this.checkFreezeClient.Text = "Freeze Client";
            this.checkFreezeClient.UseVisualStyleBackColor = true;
            this.checkFreezeClient.CheckedChanged += new System.EventHandler(this.checkFreezeClient_CheckedChanged);
            // 
            // checkToggleAI
            // 
            this.checkToggleAI.AutoSize = true;
            this.checkToggleAI.Checked = true;
            this.checkToggleAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkToggleAI.Enabled = false;
            this.checkToggleAI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToggleAI.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkToggleAI.Location = new System.Drawing.Point(5, 189);
            this.checkToggleAI.Name = "checkToggleAI";
            this.checkToggleAI.Size = new System.Drawing.Size(78, 19);
            this.checkToggleAI.TabIndex = 22;
            this.checkToggleAI.Text = "Toggle AI";
            this.checkToggleAI.UseVisualStyleBackColor = true;
            this.checkToggleAI.CheckedChanged += new System.EventHandler(this.checkToggleAI_CheckedChanged);
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
            this.buttonPauseGame.Text = "Pause Game";
            this.buttonPauseGame.UseVisualStyleBackColor = false;
            this.buttonPauseGame.Click += new System.EventHandler(this.buttonPauseGame_Click);
            // 
            // buttonWarning
            // 
            this.buttonWarning.BackColor = System.Drawing.Color.Salmon;
            this.buttonWarning.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWarning.Location = new System.Drawing.Point(543, 208);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Size = new System.Drawing.Size(23, 23);
            this.buttonWarning.TabIndex = 22;
            this.buttonWarning.Text = "!";
            this.buttonWarning.UseVisualStyleBackColor = false;
            this.buttonWarning.Click += new System.EventHandler(this.buttonWarning_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxJumpHeight);
            this.groupBox3.Controls.Add(this.buttonJumpDefault);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(459, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 85);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jump Height";
            // 
            // textBoxJumpHeight
            // 
            this.textBoxJumpHeight.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxJumpHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJumpHeight.Enabled = false;
            this.textBoxJumpHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJumpHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxJumpHeight.Location = new System.Drawing.Point(6, 51);
            this.textBoxJumpHeight.MaxLength = 4;
            this.textBoxJumpHeight.Name = "textBoxJumpHeight";
            this.textBoxJumpHeight.Size = new System.Drawing.Size(101, 23);
            this.textBoxJumpHeight.TabIndex = 19;
            this.textBoxJumpHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJumpHeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxJumpHeight_MouseClick);
            this.textBoxJumpHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJumpHeight_KeyDown);
            this.textBoxJumpHeight.Leave += new System.EventHandler(this.textBoxJumpHeight_Leave);
            // 
            // buttonJumpDefault
            // 
            this.buttonJumpDefault.BackColor = System.Drawing.Color.Silver;
            this.buttonJumpDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJumpDefault.Enabled = false;
            this.buttonJumpDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonJumpDefault.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJumpDefault.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonJumpDefault.Location = new System.Drawing.Point(6, 22);
            this.buttonJumpDefault.Name = "buttonJumpDefault";
            this.buttonJumpDefault.Size = new System.Drawing.Size(101, 23);
            this.buttonJumpDefault.TabIndex = 15;
            this.buttonJumpDefault.Text = "Default (39)";
            this.buttonJumpDefault.UseVisualStyleBackColor = false;
            this.buttonJumpDefault.Click += new System.EventHandler(this.buttonJumpDefault_Click);
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(580, 238);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonWarning);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupEntry);
            this.Controls.Add(this.groupLaunch);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.richTextGameList);
            this.Controls.Add(this.groupCommands);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alpha Commander v1.09";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupCommands.ResumeLayout(false);
            this.groupLaunch.ResumeLayout(false);
            this.groupLaunch.PerformLayout();
            this.groupEntry.ResumeLayout(false);
            this.groupEntry.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxCommands;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetFOV;
        private System.Windows.Forms.Button buttonNoClip;
        private System.Windows.Forms.TextBox textBoxMapName;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.TextBox textBoxCBUFEntry;
        private System.Windows.Forms.RichTextBox richTextGameList;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.GroupBox groupCommands;
        private System.Windows.Forms.GroupBox groupLaunch;
        private System.Windows.Forms.GroupBox groupEntry;
        private System.Windows.Forms.CheckBox checkShowWeapon;
        private System.Windows.Forms.Button buttonUFO;
        private System.Windows.Forms.Button buttonGodmode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSpeedDefault;
        private System.Windows.Forms.CheckBox checkShowHUD;
        private System.Windows.Forms.CheckBox checkInfiniteAmmo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPauseGame;
        private System.Windows.Forms.CheckBox checkToggleAI;
        private System.Windows.Forms.Button buttonWarning;
        private System.Windows.Forms.CheckBox checkFreezeClient;
        private System.Windows.Forms.Button buttonLeaveSession;
        private System.Windows.Forms.CheckBox checkThirdPerson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonJumpDefault;
        private System.Windows.Forms.TextBox textBoxJumpHeight;
        private System.Windows.Forms.TextBox textBoxMovementSpeed;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

