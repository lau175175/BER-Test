using System;

namespace BER_test
{
    partial class MainForm  
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxAmp = new System.Windows.Forms.TextBox();
            this.LabelPostCousor = new System.Windows.Forms.Label();
            this.LabelLowerEye = new System.Windows.Forms.Label();
            this.LabelUpperEye = new System.Windows.Forms.Label();
            this.LabelPreCousor = new System.Windows.Forms.Label();
            this.BarLowerEye = new System.Windows.Forms.HScrollBar();
            this.BarUpperEye = new System.Windows.Forms.HScrollBar();
            this.BarPostCousor = new System.Windows.Forms.HScrollBar();
            this.BarPreCousor = new System.Windows.Forms.HScrollBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTestPattern = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxClockRatio = new System.Windows.Forms.ComboBox();
            this.comboBoxSymbolRate = new System.Windows.Forms.ComboBox();
            this.comboBoxModulation = new System.Windows.Forms.ComboBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxATTStep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attOutput = new System.Windows.Forms.Button();
            this.textBoxATTStop = new System.Windows.Forms.TextBox();
            this.textBoxATTStart = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LabelAtt = new System.Windows.Forms.Label();
            this.BarAtt = new System.Windows.Forms.HScrollBar();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxWaveLength = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxBERTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BERlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBERButt = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ATTtcpConnect = new System.Windows.Forms.Button();
            this.PPGtcpConnect = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonBERRefresh = new System.Windows.Forms.Button();
            this.checkPPG = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.connectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1109, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1085, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config PPG";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxAmp);
            this.groupBox6.Controls.Add(this.LabelPostCousor);
            this.groupBox6.Controls.Add(this.LabelLowerEye);
            this.groupBox6.Controls.Add(this.LabelUpperEye);
            this.groupBox6.Controls.Add(this.LabelPreCousor);
            this.groupBox6.Controls.Add(this.BarLowerEye);
            this.groupBox6.Controls.Add(this.BarUpperEye);
            this.groupBox6.Controls.Add(this.BarPostCousor);
            this.groupBox6.Controls.Add(this.BarPreCousor);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.comboBoxTestPattern);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(372, 38);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(708, 219);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pattern/Adjust";
            // 
            // textBoxAmp
            // 
            this.textBoxAmp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAmp.Location = new System.Drawing.Point(20, 158);
            this.textBoxAmp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmp.Name = "textBoxAmp";
            this.textBoxAmp.Size = new System.Drawing.Size(112, 30);
            this.textBoxAmp.TabIndex = 22;
            // 
            // LabelPostCousor
            // 
            this.LabelPostCousor.AutoSize = true;
            this.LabelPostCousor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPostCousor.Location = new System.Drawing.Point(615, 84);
            this.LabelPostCousor.Name = "LabelPostCousor";
            this.LabelPostCousor.Size = new System.Drawing.Size(59, 20);
            this.LabelPostCousor.TabIndex = 30;
            this.LabelPostCousor.Text = "value";
            // 
            // LabelLowerEye
            // 
            this.LabelLowerEye.AutoSize = true;
            this.LabelLowerEye.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLowerEye.Location = new System.Drawing.Point(615, 175);
            this.LabelLowerEye.Name = "LabelLowerEye";
            this.LabelLowerEye.Size = new System.Drawing.Size(59, 20);
            this.LabelLowerEye.TabIndex = 29;
            this.LabelLowerEye.Text = "value";
            // 
            // LabelUpperEye
            // 
            this.LabelUpperEye.AutoSize = true;
            this.LabelUpperEye.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelUpperEye.Location = new System.Drawing.Point(615, 135);
            this.LabelUpperEye.Name = "LabelUpperEye";
            this.LabelUpperEye.Size = new System.Drawing.Size(59, 20);
            this.LabelUpperEye.TabIndex = 28;
            this.LabelUpperEye.Text = "value";
            // 
            // LabelPreCousor
            // 
            this.LabelPreCousor.AutoSize = true;
            this.LabelPreCousor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPreCousor.Location = new System.Drawing.Point(615, 42);
            this.LabelPreCousor.Name = "LabelPreCousor";
            this.LabelPreCousor.Size = new System.Drawing.Size(59, 20);
            this.LabelPreCousor.TabIndex = 26;
            this.LabelPreCousor.Text = "value";
            // 
            // BarLowerEye
            // 
            this.BarLowerEye.LargeChange = 1;
            this.BarLowerEye.Location = new System.Drawing.Point(259, 178);
            this.BarLowerEye.Minimum = -100;
            this.BarLowerEye.Name = "BarLowerEye";
            this.BarLowerEye.Size = new System.Drawing.Size(332, 23);
            this.BarLowerEye.TabIndex = 25;
            // 
            // BarUpperEye
            // 
            this.BarUpperEye.LargeChange = 1;
            this.BarUpperEye.Location = new System.Drawing.Point(259, 135);
            this.BarUpperEye.Minimum = -100;
            this.BarUpperEye.Name = "BarUpperEye";
            this.BarUpperEye.Size = new System.Drawing.Size(332, 23);
            this.BarUpperEye.TabIndex = 24;
            // 
            // BarPostCousor
            // 
            this.BarPostCousor.LargeChange = 1;
            this.BarPostCousor.Location = new System.Drawing.Point(259, 85);
            this.BarPostCousor.Minimum = -100;
            this.BarPostCousor.Name = "BarPostCousor";
            this.BarPostCousor.Size = new System.Drawing.Size(332, 23);
            this.BarPostCousor.TabIndex = 23;
            // 
            // BarPreCousor
            // 
            this.BarPreCousor.LargeChange = 1;
            this.BarPreCousor.Location = new System.Drawing.Point(259, 42);
            this.BarPreCousor.Minimum = -100;
            this.BarPreCousor.Name = "BarPreCousor";
            this.BarPreCousor.Size = new System.Drawing.Size(332, 23);
            this.BarPreCousor.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(139, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Lower Eye";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(139, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 18);
            this.label14.TabIndex = 18;
            this.label14.Text = "Upper Eye";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(139, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Post Cursor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(139, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Pre Cursor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(5, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Amplitude(mV)";
            // 
            // comboBoxTestPattern
            // 
            this.comboBoxTestPattern.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxTestPattern.FormattingEnabled = true;
            this.comboBoxTestPattern.Location = new System.Drawing.Point(20, 68);
            this.comboBoxTestPattern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTestPattern.Name = "comboBoxTestPattern";
            this.comboBoxTestPattern.Size = new System.Drawing.Size(112, 28);
            this.comboBoxTestPattern.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(5, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Test Pattern";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxClockRatio);
            this.groupBox4.Controls.Add(this.comboBoxSymbolRate);
            this.groupBox4.Controls.Add(this.comboBoxModulation);
            this.groupBox4.Controls.Add(this.comboBoxMode);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(5, 38);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(360, 219);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mode/Rate";
            // 
            // comboBoxClockRatio
            // 
            this.comboBoxClockRatio.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxClockRatio.FormattingEnabled = true;
            this.comboBoxClockRatio.Location = new System.Drawing.Point(131, 176);
            this.comboBoxClockRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClockRatio.Name = "comboBoxClockRatio";
            this.comboBoxClockRatio.Size = new System.Drawing.Size(213, 28);
            this.comboBoxClockRatio.TabIndex = 10;
            // 
            // comboBoxSymbolRate
            // 
            this.comboBoxSymbolRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSymbolRate.FormattingEnabled = true;
            this.comboBoxSymbolRate.Location = new System.Drawing.Point(131, 131);
            this.comboBoxSymbolRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSymbolRate.Name = "comboBoxSymbolRate";
            this.comboBoxSymbolRate.Size = new System.Drawing.Size(213, 28);
            this.comboBoxSymbolRate.TabIndex = 9;
            // 
            // comboBoxModulation
            // 
            this.comboBoxModulation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxModulation.FormattingEnabled = true;
            this.comboBoxModulation.Location = new System.Drawing.Point(131, 82);
            this.comboBoxModulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxModulation.Name = "comboBoxModulation";
            this.comboBoxModulation.Size = new System.Drawing.Size(213, 28);
            this.comboBoxModulation.TabIndex = 8;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(131, 35);
            this.comboBoxMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(213, 28);
            this.comboBoxMode.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Clock Ratio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(7, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Symbol Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modulation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxATTStep);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.attOutput);
            this.groupBox2.Controls.Add(this.textBoxATTStop);
            this.groupBox2.Controls.Add(this.textBoxATTStart);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.LabelAtt);
            this.groupBox2.Controls.Add(this.BarAtt);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboBoxWaveLength);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 315);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1085, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config ATT";
            // 
            // textBoxATTStep
            // 
            this.textBoxATTStep.Location = new System.Drawing.Point(743, 89);
            this.textBoxATTStep.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxATTStep.Name = "textBoxATTStep";
            this.textBoxATTStep.Size = new System.Drawing.Size(132, 30);
            this.textBoxATTStep.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "ATT Step";
            // 
            // attOutput
            // 
            this.attOutput.Location = new System.Drawing.Point(892, 38);
            this.attOutput.Margin = new System.Windows.Forms.Padding(4);
            this.attOutput.Name = "attOutput";
            this.attOutput.Size = new System.Drawing.Size(157, 56);
            this.attOutput.TabIndex = 35;
            this.attOutput.Text = "ATT output";
            this.attOutput.UseVisualStyleBackColor = true;
            this.attOutput.Click += new System.EventHandler(this.attOutput_Click);
            // 
            // textBoxATTStop
            // 
            this.textBoxATTStop.Location = new System.Drawing.Point(743, 51);
            this.textBoxATTStop.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxATTStop.Name = "textBoxATTStop";
            this.textBoxATTStop.Size = new System.Drawing.Size(132, 30);
            this.textBoxATTStop.TabIndex = 34;
            // 
            // textBoxATTStart
            // 
            this.textBoxATTStart.Location = new System.Drawing.Point(743, 12);
            this.textBoxATTStart.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxATTStart.Name = "textBoxATTStart";
            this.textBoxATTStart.Size = new System.Drawing.Size(132, 30);
            this.textBoxATTStart.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(595, 56);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "ATT Stop";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(595, 16);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "ATT Start";
            // 
            // LabelAtt
            // 
            this.LabelAtt.AutoSize = true;
            this.LabelAtt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelAtt.Location = new System.Drawing.Point(504, 74);
            this.LabelAtt.Name = "LabelAtt";
            this.LabelAtt.Size = new System.Drawing.Size(59, 20);
            this.LabelAtt.TabIndex = 30;
            this.LabelAtt.Text = "value";
            // 
            // BarAtt
            // 
            this.BarAtt.LargeChange = 1;
            this.BarAtt.Location = new System.Drawing.Point(163, 74);
            this.BarAtt.Maximum = 20;
            this.BarAtt.Name = "BarAtt";
            this.BarAtt.Size = new System.Drawing.Size(332, 23);
            this.BarAtt.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(7, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "ATT(dB)";
            // 
            // comboBoxWaveLength
            // 
            this.comboBoxWaveLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxWaveLength.FormattingEnabled = true;
            this.comboBoxWaveLength.Location = new System.Drawing.Point(163, 26);
            this.comboBoxWaveLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWaveLength.Name = "comboBoxWaveLength";
            this.comboBoxWaveLength.Size = new System.Drawing.Size(331, 28);
            this.comboBoxWaveLength.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(7, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 18);
            this.label16.TabIndex = 18;
            this.label16.Text = "Wave Length";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxBERTime);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxChannel);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.BERlabel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.saveBERButt);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 448);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(637, 152);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TEST";
            // 
            // textBoxBERTime
            // 
            this.textBoxBERTime.Location = new System.Drawing.Point(460, 95);
            this.textBoxBERTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBERTime.Name = "textBoxBERTime";
            this.textBoxBERTime.Size = new System.Drawing.Size(132, 30);
            this.textBoxBERTime.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Channel";
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Location = new System.Drawing.Point(163, 69);
            this.comboBoxChannel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.Size = new System.Drawing.Size(160, 28);
            this.comboBoxChannel.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(368, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 20);
            this.label21.TabIndex = 30;
            this.label21.Text = "BER";
            // 
            // BERlabel
            // 
            this.BERlabel.AutoSize = true;
            this.BERlabel.Location = new System.Drawing.Point(368, 101);
            this.BERlabel.Name = "BERlabel";
            this.BERlabel.Size = new System.Drawing.Size(53, 20);
            this.BERlabel.TabIndex = 5;
            this.BERlabel.Text = "0E-0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time(s)";
            // 
            // saveBERButt
            // 
            this.saveBERButt.Location = new System.Drawing.Point(23, 58);
            this.saveBERButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBERButt.Name = "saveBERButt";
            this.saveBERButt.Size = new System.Drawing.Size(111, 50);
            this.saveBERButt.TabIndex = 0;
            this.saveBERButt.Text = "Save";
            this.saveBERButt.UseVisualStyleBackColor = true;
            this.saveBERButt.Click += new System.EventHandler(this.saveBERButt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.ATTtcpConnect);
            this.groupBox5.Controls.Add(this.PPGtcpConnect);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(887, 448);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(205, 150);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TCP Connect";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 101);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 20);
            this.label20.TabIndex = 3;
            this.label20.Text = "ATT";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 50);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "PPG";
            // 
            // ATTtcpConnect
            // 
            this.ATTtcpConnect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ATTtcpConnect.Location = new System.Drawing.Point(75, 92);
            this.ATTtcpConnect.Margin = new System.Windows.Forms.Padding(4);
            this.ATTtcpConnect.Name = "ATTtcpConnect";
            this.ATTtcpConnect.Size = new System.Drawing.Size(123, 39);
            this.ATTtcpConnect.TabIndex = 1;
            this.ATTtcpConnect.Text = "Disconnect";
            this.ATTtcpConnect.UseVisualStyleBackColor = true;
            this.ATTtcpConnect.Click += new System.EventHandler(this.ATTtcpConnect_Click);
            // 
            // PPGtcpConnect
            // 
            this.PPGtcpConnect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PPGtcpConnect.Location = new System.Drawing.Point(75, 41);
            this.PPGtcpConnect.Margin = new System.Windows.Forms.Padding(4);
            this.PPGtcpConnect.Name = "PPGtcpConnect";
            this.PPGtcpConnect.Size = new System.Drawing.Size(123, 39);
            this.PPGtcpConnect.TabIndex = 0;
            this.PPGtcpConnect.Text = "Disconnect";
            this.PPGtcpConnect.UseVisualStyleBackColor = true;
            this.PPGtcpConnect.Click += new System.EventHandler(this.PPGtcpConnect_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonBERRefresh);
            this.groupBox7.Controls.Add(this.checkPPG);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(673, 450);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(205, 150);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PPG Statu";
            // 
            // buttonBERRefresh
            // 
            this.buttonBERRefresh.Location = new System.Drawing.Point(35, 106);
            this.buttonBERRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBERRefresh.Name = "buttonBERRefresh";
            this.buttonBERRefresh.Size = new System.Drawing.Size(133, 42);
            this.buttonBERRefresh.TabIndex = 1;
            this.buttonBERRefresh.Text = "Refresh";
            this.buttonBERRefresh.UseVisualStyleBackColor = true;
            this.buttonBERRefresh.Click += new System.EventHandler(this.buttonBERRefresh_Click);
            // 
            // checkPPG
            // 
            this.checkPPG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkPPG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkPPG.FormattingEnabled = true;
            this.checkPPG.Items.AddRange(new object[] {
            "PPG OFF",
            "PPG RUN"});
            this.checkPPG.Location = new System.Drawing.Point(35, 21);
            this.checkPPG.Margin = new System.Windows.Forms.Padding(4);
            this.checkPPG.Name = "checkPPG";
            this.checkPPG.Size = new System.Drawing.Size(132, 79);
            this.checkPPG.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1109, 612);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BER TEST";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button saveBERButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BERlabel;
        private System.Windows.Forms.ComboBox comboBoxClockRatio;
        private System.Windows.Forms.ComboBox comboBoxSymbolRate;
        private System.Windows.Forms.ComboBox comboBoxModulation;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxTestPattern;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxWaveLength;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.HScrollBar BarPreCousor;
        private System.Windows.Forms.Label LabelUpperEye;
        private System.Windows.Forms.Label LabelPreCousor;
        private System.Windows.Forms.HScrollBar BarLowerEye;
        private System.Windows.Forms.HScrollBar BarUpperEye;
        private System.Windows.Forms.HScrollBar BarPostCousor;
        private System.Windows.Forms.Label LabelLowerEye;
        private System.Windows.Forms.Label LabelPostCousor;
        private System.Windows.Forms.TextBox textBoxAmp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.HScrollBar BarAtt;
        private System.Windows.Forms.Label LabelAtt;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxATTStop;
        private System.Windows.Forms.TextBox textBoxATTStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button PPGtcpConnect;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckedListBox checkPPG;
        private System.Windows.Forms.Button attOutput;
        private System.Windows.Forms.ComboBox comboBoxChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ATTtcpConnect;
        private System.Windows.Forms.Button buttonBERRefresh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxBERTime;
        private System.Windows.Forms.TextBox textBoxATTStep;
        private System.Windows.Forms.Label label3;
    }
}

