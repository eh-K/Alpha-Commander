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
            this.buttonNoClipGod = new System.Windows.Forms.Button();
            this.textMapEntry = new System.Windows.Forms.TextBox();
            this.checkDebugBuild = new System.Windows.Forms.CheckBox();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.textCBUFEntry = new System.Windows.Forms.TextBox();
            this.richTextGameList = new System.Windows.Forms.RichTextBox();
            this.buttonList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPhotoMode = new System.Windows.Forms.Button();
            this.checkShowWeapon = new System.Windows.Forms.CheckBox();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
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
            // buttonNoClipGod
            // 
            this.buttonNoClipGod.BackColor = System.Drawing.Color.Silver;
            this.buttonNoClipGod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNoClipGod.Enabled = false;
            this.buttonNoClipGod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNoClipGod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNoClipGod.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNoClipGod.Location = new System.Drawing.Point(6, 79);
            this.buttonNoClipGod.Name = "buttonNoClipGod";
            this.buttonNoClipGod.Size = new System.Drawing.Size(101, 23);
            this.buttonNoClipGod.TabIndex = 12;
            this.buttonNoClipGod.Text = "No Clip | God";
            this.buttonNoClipGod.UseVisualStyleBackColor = false;
            this.buttonNoClipGod.Click += new System.EventHandler(this.buttonNoClipGod_Click);
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
            // checkDebugBuild
            // 
            this.checkDebugBuild.AutoSize = true;
            this.checkDebugBuild.Enabled = false;
            this.checkDebugBuild.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDebugBuild.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkDebugBuild.Location = new System.Drawing.Point(6, 39);
            this.checkDebugBuild.Name = "checkDebugBuild";
            this.checkDebugBuild.Size = new System.Drawing.Size(62, 19);
            this.checkDebugBuild.TabIndex = 17;
            this.checkDebugBuild.Text = "Debug";
            this.checkDebugBuild.UseVisualStyleBackColor = true;
            this.checkDebugBuild.CheckedChanged += new System.EventHandler(this.checkDebugBuild_CheckedChanged);
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
            this.buttonCredits.Location = new System.Drawing.Point(208, 229);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(101, 23);
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
            this.richTextGameList.Location = new System.Drawing.Point(321, 17);
            this.richTextGameList.Name = "richTextGameList";
            this.richTextGameList.ReadOnly = true;
            this.richTextGameList.Size = new System.Drawing.Size(295, 232);
            this.richTextGameList.TabIndex = 20;
            this.richTextGameList.Text = resources.GetString("richTextGameList.Text");
            this.richTextGameList.Visible = false;
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonList.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonList.Location = new System.Drawing.Point(11, 50);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(23, 23);
            this.buttonList.TabIndex = 21;
            this.buttonList.Text = "?";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPhotoMode);
            this.groupBox1.Controls.Add(this.buttonSetFOV);
            this.groupBox1.Controls.Add(this.buttonNoClipGod);
            this.groupBox1.Location = new System.Drawing.Point(202, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 108);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // buttonPhotoMode
            // 
            this.buttonPhotoMode.BackColor = System.Drawing.Color.Silver;
            this.buttonPhotoMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhotoMode.Enabled = false;
            this.buttonPhotoMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPhotoMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhotoMode.Location = new System.Drawing.Point(6, 50);
            this.buttonPhotoMode.Name = "buttonPhotoMode";
            this.buttonPhotoMode.Size = new System.Drawing.Size(101, 23);
            this.buttonPhotoMode.TabIndex = 18;
            this.buttonPhotoMode.Text = "Photomode";
            this.buttonPhotoMode.UseVisualStyleBackColor = false;
            this.buttonPhotoMode.Click += new System.EventHandler(this.buttonPhotoMode_Click);
            // 
            // checkShowWeapon
            // 
            this.checkShowWeapon.AutoSize = true;
            this.checkShowWeapon.Checked = true;
            this.checkShowWeapon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowWeapon.Enabled = false;
            this.checkShowWeapon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowWeapon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkShowWeapon.Location = new System.Drawing.Point(6, 19);
            this.checkShowWeapon.Name = "checkShowWeapon";
            this.checkShowWeapon.Size = new System.Drawing.Size(104, 19);
            this.checkShowWeapon.TabIndex = 19;
            this.checkShowWeapon.Text = "Show Weapon";
            this.checkShowWeapon.UseVisualStyleBackColor = true;
            this.checkShowWeapon.CheckedChanged += new System.EventHandler(this.checkShowWeapon_CheckedChanged);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.buttonConnect);
            this.groupBoxMain.Controls.Add(this.textCBUFEntry);
            this.groupBoxMain.Controls.Add(this.buttonList);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(179, 97);
            this.groupBoxMain.TabIndex = 23;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Launch Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textCommandBox);
            this.groupBox2.Controls.Add(this.buttonSendCommand);
            this.groupBox2.Controls.Add(this.textMapEntry);
            this.groupBox2.Controls.Add(this.buttonLoadMap);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 131);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entry Section";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkShowWeapon);
            this.groupBox3.Controls.Add(this.checkDebugBuild);
            this.groupBox3.Location = new System.Drawing.Point(202, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(321, 259);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.richTextGameList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alpha Commander v1.01";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textCommandBox;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetFOV;
        private System.Windows.Forms.Button buttonNoClipGod;
        private System.Windows.Forms.TextBox textMapEntry;
        private System.Windows.Forms.CheckBox checkDebugBuild;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.TextBox textCBUFEntry;
        private System.Windows.Forms.RichTextBox richTextGameList;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPhotoMode;
        private System.Windows.Forms.CheckBox checkShowWeapon;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

