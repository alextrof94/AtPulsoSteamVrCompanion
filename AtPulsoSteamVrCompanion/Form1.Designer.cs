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
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BuPresetSave = new Button();
            CbDevice = new ComboBox();
            label11 = new Label();
            groupBox3 = new GroupBox();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
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
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
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
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.Tag = "O,--";
            button5.UseVisualStyleBackColor = true;
            button5.Click += BuAdjust_Click;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.Tag = "O,-";
            button6.UseVisualStyleBackColor = true;
            button6.Click += BuAdjust_Click;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.Tag = "O,++";
            button7.UseVisualStyleBackColor = true;
            button7.Click += BuAdjust_Click;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.Name = "button8";
            button8.Tag = "O,+";
            button8.UseVisualStyleBackColor = true;
            button8.Click += BuAdjust_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.Tag = "S,--";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BuAdjust_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.Tag = "S,-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BuAdjust_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.Tag = "S,++";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BuAdjust_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.Tag = "S,+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BuAdjust_Click;
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
            groupBox3.Controls.Add(button29);
            groupBox3.Controls.Add(button30);
            groupBox3.Controls.Add(button31);
            groupBox3.Controls.Add(button32);
            groupBox3.Controls.Add(button25);
            groupBox3.Controls.Add(button26);
            groupBox3.Controls.Add(button27);
            groupBox3.Controls.Add(button28);
            groupBox3.Controls.Add(button21);
            groupBox3.Controls.Add(button22);
            groupBox3.Controls.Add(button23);
            groupBox3.Controls.Add(button24);
            groupBox3.Controls.Add(button17);
            groupBox3.Controls.Add(button18);
            groupBox3.Controls.Add(button19);
            groupBox3.Controls.Add(button20);
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(button14);
            groupBox3.Controls.Add(button15);
            groupBox3.Controls.Add(button16);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(button12);
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
            // button29
            // 
            resources.ApplyResources(button29, "button29");
            button29.Name = "button29";
            button29.Tag = "R,--";
            button29.UseVisualStyleBackColor = true;
            button29.Click += BuAdjust_Click;
            // 
            // button30
            // 
            resources.ApplyResources(button30, "button30");
            button30.Name = "button30";
            button30.Tag = "R,-";
            button30.UseVisualStyleBackColor = true;
            button30.Click += BuAdjust_Click;
            // 
            // button31
            // 
            resources.ApplyResources(button31, "button31");
            button31.Name = "button31";
            button31.Tag = "R,++";
            button31.UseVisualStyleBackColor = true;
            button31.Click += BuAdjust_Click;
            // 
            // button32
            // 
            resources.ApplyResources(button32, "button32");
            button32.Name = "button32";
            button32.Tag = "R,+";
            button32.UseVisualStyleBackColor = true;
            button32.Click += BuAdjust_Click;
            // 
            // button25
            // 
            resources.ApplyResources(button25, "button25");
            button25.Name = "button25";
            button25.Tag = "Yaw,--";
            button25.UseVisualStyleBackColor = true;
            button25.Click += BuAdjust_Click;
            // 
            // button26
            // 
            resources.ApplyResources(button26, "button26");
            button26.Name = "button26";
            button26.Tag = "Yaw,-";
            button26.UseVisualStyleBackColor = true;
            button26.Click += BuAdjust_Click;
            // 
            // button27
            // 
            resources.ApplyResources(button27, "button27");
            button27.Name = "button27";
            button27.Tag = "Yaw,++";
            button27.UseVisualStyleBackColor = true;
            button27.Click += BuAdjust_Click;
            // 
            // button28
            // 
            resources.ApplyResources(button28, "button28");
            button28.Name = "button28";
            button28.Tag = "Yaw,+";
            button28.UseVisualStyleBackColor = true;
            button28.Click += BuAdjust_Click;
            // 
            // button21
            // 
            resources.ApplyResources(button21, "button21");
            button21.Name = "button21";
            button21.Tag = "P,--";
            button21.UseVisualStyleBackColor = true;
            button21.Click += BuAdjust_Click;
            // 
            // button22
            // 
            resources.ApplyResources(button22, "button22");
            button22.Name = "button22";
            button22.Tag = "P,-";
            button22.UseVisualStyleBackColor = true;
            button22.Click += BuAdjust_Click;
            // 
            // button23
            // 
            resources.ApplyResources(button23, "button23");
            button23.Name = "button23";
            button23.Tag = "P,++";
            button23.UseVisualStyleBackColor = true;
            button23.Click += BuAdjust_Click;
            // 
            // button24
            // 
            resources.ApplyResources(button24, "button24");
            button24.Name = "button24";
            button24.Tag = "P,+";
            button24.UseVisualStyleBackColor = true;
            button24.Click += BuAdjust_Click;
            // 
            // button17
            // 
            resources.ApplyResources(button17, "button17");
            button17.Name = "button17";
            button17.Tag = "Z,--";
            button17.UseVisualStyleBackColor = true;
            button17.Click += BuAdjust_Click;
            // 
            // button18
            // 
            resources.ApplyResources(button18, "button18");
            button18.Name = "button18";
            button18.Tag = "Z,-";
            button18.UseVisualStyleBackColor = true;
            button18.Click += BuAdjust_Click;
            // 
            // button19
            // 
            resources.ApplyResources(button19, "button19");
            button19.Name = "button19";
            button19.Tag = "Z,++";
            button19.UseVisualStyleBackColor = true;
            button19.Click += BuAdjust_Click;
            // 
            // button20
            // 
            resources.ApplyResources(button20, "button20");
            button20.Name = "button20";
            button20.Tag = "Z,+";
            button20.UseVisualStyleBackColor = true;
            button20.Click += BuAdjust_Click;
            // 
            // button13
            // 
            resources.ApplyResources(button13, "button13");
            button13.Name = "button13";
            button13.Tag = "Y,--";
            button13.UseVisualStyleBackColor = true;
            button13.Click += BuAdjust_Click;
            // 
            // button14
            // 
            resources.ApplyResources(button14, "button14");
            button14.Name = "button14";
            button14.Tag = "Y,-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += BuAdjust_Click;
            // 
            // button15
            // 
            resources.ApplyResources(button15, "button15");
            button15.Name = "button15";
            button15.Tag = "Y,++";
            button15.UseVisualStyleBackColor = true;
            button15.Click += BuAdjust_Click;
            // 
            // button16
            // 
            resources.ApplyResources(button16, "button16");
            button16.Name = "button16";
            button16.Tag = "Y,+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += BuAdjust_Click;
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.Name = "button9";
            button9.Tag = "X,--";
            button9.UseVisualStyleBackColor = true;
            button9.Click += BuAdjust_Click;
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.Name = "button10";
            button10.Tag = "X,-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += BuAdjust_Click;
            // 
            // button11
            // 
            resources.ApplyResources(button11, "button11");
            button11.Name = "button11";
            button11.Tag = "X,++";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BuAdjust_Click;
            // 
            // button12
            // 
            resources.ApplyResources(button12, "button12");
            button12.Name = "button12";
            button12.Tag = "X,+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += BuAdjust_Click;
            // 
            // NudX
            // 
            resources.ApplyResources(NudX, "NudX");
            NudX.DecimalPlaces = 2;
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
            NudOpacity.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
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
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}