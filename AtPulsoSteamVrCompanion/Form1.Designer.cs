namespace AtPulsoSteamVrCompanion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BuVrStatus = new Button();
            label1 = new Label();
            TbApAddress = new TextBox();
            CbStartWithSteamVR = new CheckBox();
            CbPreset = new ComboBox();
            label2 = new Label();
            CbMinimize = new CheckBox();
            CbToTray = new CheckBox();
            groupBox1 = new GroupBox();
            BuVrR = new Button();
            BuVrL = new Button();
            BuHr = new Button();
            groupBox2 = new GroupBox();
            BuPresetSave = new Button();
            CbDevice = new ComboBox();
            label11 = new Label();
            groupBox3 = new GroupBox();
            NudX = new NumericUpDown();
            label5 = new Label();
            label10 = new Label();
            NudY = new NumericUpDown();
            NudRoll = new NumericUpDown();
            label6 = new Label();
            label9 = new Label();
            NudZ = new NumericUpDown();
            NudYaw = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            NudPitch = new NumericUpDown();
            label4 = new Label();
            NudOpacity = new NumericUpDown();
            label3 = new Label();
            NudSize = new NumericUpDown();
            TiGetPulse = new System.Windows.Forms.Timer(components);
            TiCheckVr = new System.Windows.Forms.Timer(components);
            NiMain = new NotifyIcon(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudRoll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudYaw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudPitch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudOpacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudSize).BeginInit();
            SuspendLayout();
            // 
            // BuVrStatus
            // 
            resources.ApplyResources(BuVrStatus, "BuVrStatus");
            BuVrStatus.BackColor = Color.LightPink;
            BuVrStatus.Name = "BuVrStatus";
            BuVrStatus.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // TbApAddress
            // 
            resources.ApplyResources(TbApAddress, "TbApAddress");
            TbApAddress.Name = "TbApAddress";
            TbApAddress.TextChanged += TbApAddress_TextChanged;
            // 
            // CbStartWithSteamVR
            // 
            resources.ApplyResources(CbStartWithSteamVR, "CbStartWithSteamVR");
            CbStartWithSteamVR.Name = "CbStartWithSteamVR";
            CbStartWithSteamVR.UseVisualStyleBackColor = true;
            CbStartWithSteamVR.CheckedChanged += CbStartWithSteamVR_CheckedChanged;
            // 
            // CbPreset
            // 
            resources.ApplyResources(CbPreset, "CbPreset");
            CbPreset.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPreset.FormattingEnabled = true;
            CbPreset.Items.AddRange(new object[] { resources.GetString("CbPreset.Items"), resources.GetString("CbPreset.Items1"), resources.GetString("CbPreset.Items2") });
            CbPreset.Name = "CbPreset";
            CbPreset.SelectedIndexChanged += CbPreset_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // CbMinimize
            // 
            resources.ApplyResources(CbMinimize, "CbMinimize");
            CbMinimize.Name = "CbMinimize";
            CbMinimize.UseVisualStyleBackColor = true;
            CbMinimize.CheckedChanged += CbMinimize_CheckedChanged;
            // 
            // CbToTray
            // 
            resources.ApplyResources(CbToTray, "CbToTray");
            CbToTray.Name = "CbToTray";
            CbToTray.UseVisualStyleBackColor = true;
            CbToTray.CheckedChanged += CbToTray_CheckedChanged;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(BuVrR);
            groupBox1.Controls.Add(BuVrL);
            groupBox1.Controls.Add(BuHr);
            groupBox1.Controls.Add(BuVrStatus);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CbToTray);
            groupBox1.Controls.Add(TbApAddress);
            groupBox1.Controls.Add(CbMinimize);
            groupBox1.Controls.Add(CbStartWithSteamVR);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // BuVrR
            // 
            resources.ApplyResources(BuVrR, "BuVrR");
            BuVrR.BackColor = Color.LightPink;
            BuVrR.Name = "BuVrR";
            BuVrR.UseVisualStyleBackColor = false;
            // 
            // BuVrL
            // 
            resources.ApplyResources(BuVrL, "BuVrL");
            BuVrL.BackColor = Color.LightPink;
            BuVrL.Name = "BuVrL";
            BuVrL.UseVisualStyleBackColor = false;
            // 
            // BuHr
            // 
            resources.ApplyResources(BuHr, "BuHr");
            BuHr.BackColor = Color.LightPink;
            BuHr.Name = "BuHr";
            BuHr.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(BuPresetSave);
            groupBox2.Controls.Add(CbDevice);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(NudOpacity);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(NudSize);
            groupBox2.Controls.Add(CbPreset);
            groupBox2.Controls.Add(label2);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // BuPresetSave
            // 
            resources.ApplyResources(BuPresetSave, "BuPresetSave");
            BuPresetSave.Name = "BuPresetSave";
            BuPresetSave.UseVisualStyleBackColor = true;
            BuPresetSave.Click += BuPresetSave_Click;
            // 
            // CbDevice
            // 
            resources.ApplyResources(CbDevice, "CbDevice");
            CbDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            CbDevice.FormattingEnabled = true;
            CbDevice.Name = "CbDevice";
            CbDevice.SelectedIndexChanged += CbDevice_SelectedIndexChanged;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(NudX);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(NudY);
            groupBox3.Controls.Add(NudRoll);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(NudZ);
            groupBox3.Controls.Add(NudYaw);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(NudPitch);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // NudX
            // 
            resources.ApplyResources(NudX, "NudX");
            NudX.DecimalPlaces = 2;
            NudX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NudX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudX.Name = "NudX";
            NudX.ValueChanged += Nud_ValueChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // NudY
            // 
            resources.ApplyResources(NudY, "NudY");
            NudY.DecimalPlaces = 2;
            NudY.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NudY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudY.Name = "NudY";
            NudY.ValueChanged += Nud_ValueChanged;
            // 
            // NudRoll
            // 
            resources.ApplyResources(NudRoll, "NudRoll");
            NudRoll.DecimalPlaces = 2;
            NudRoll.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            NudRoll.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            NudRoll.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            NudRoll.Name = "NudRoll";
            NudRoll.ValueChanged += Nud_ValueChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // NudZ
            // 
            resources.ApplyResources(NudZ, "NudZ");
            NudZ.DecimalPlaces = 2;
            NudZ.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NudZ.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudZ.Name = "NudZ";
            NudZ.ValueChanged += Nud_ValueChanged;
            // 
            // NudYaw
            // 
            resources.ApplyResources(NudYaw, "NudYaw");
            NudYaw.DecimalPlaces = 2;
            NudYaw.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            NudYaw.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            NudYaw.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            NudYaw.Name = "NudYaw";
            NudYaw.ValueChanged += Nud_ValueChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // NudPitch
            // 
            resources.ApplyResources(NudPitch, "NudPitch");
            NudPitch.DecimalPlaces = 2;
            NudPitch.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            NudPitch.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            NudPitch.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            NudPitch.Name = "NudPitch";
            NudPitch.ValueChanged += Nud_ValueChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // NudOpacity
            // 
            resources.ApplyResources(NudOpacity, "NudOpacity");
            NudOpacity.DecimalPlaces = 2;
            NudOpacity.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            NudOpacity.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NudOpacity.Name = "NudOpacity";
            NudOpacity.ValueChanged += Nud_ValueChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // NudSize
            // 
            resources.ApplyResources(NudSize, "NudSize");
            NudSize.DecimalPlaces = 2;
            NudSize.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NudSize.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudSize.Name = "NudSize";
            NudSize.ValueChanged += Nud_ValueChanged;
            // 
            // TiGetPulse
            // 
            TiGetPulse.Enabled = true;
            TiGetPulse.Interval = 500;
            TiGetPulse.Tick += TiGetPulse_Tick;
            // 
            // TiCheckVr
            // 
            TiCheckVr.Enabled = true;
            TiCheckVr.Interval = 1000;
            TiCheckVr.Tick += TiCheckVr_Tick;
            // 
            // NiMain
            // 
            resources.ApplyResources(NiMain, "NiMain");
            NiMain.Click += NiMain_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            Shown += Form1_Shown;
            Resize += Form1_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudRoll).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudYaw).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudPitch).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudOpacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BuVrStatus;
        private Label label1;
        private TextBox TbApAddress;
        private CheckBox CbStartWithSteamVR;
        private ComboBox CbPreset;
        private Label label2;
        private CheckBox CbMinimize;
        private CheckBox CbToTray;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
        private NumericUpDown NudRoll;
        private Label label9;
        private NumericUpDown NudYaw;
        private Label label8;
        private NumericUpDown NudPitch;
        private Label label7;
        private NumericUpDown NudZ;
        private Label label6;
        private NumericUpDown NudY;
        private Label label5;
        private NumericUpDown NudX;
        private Label label4;
        private NumericUpDown NudOpacity;
        private Label label3;
        private NumericUpDown NudSize;
        private GroupBox groupBox3;
        private ComboBox CbDevice;
        private Label label11;
        private System.Windows.Forms.Timer TiGetPulse;
        private System.Windows.Forms.Timer TiCheckVr;
        private Button BuHr;
        private Button BuPresetSave;
        private Button BuVrR;
        private Button BuVrL;
        private NotifyIcon NiMain;
    }
}