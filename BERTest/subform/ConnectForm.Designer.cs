namespace SubForm
{
    partial class SubFormConnect 
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PPGserverAddress = new System.Windows.Forms.TextBox();
            this.PPGserverPort = new System.Windows.Forms.TextBox();
            this.saveConfig = new System.Windows.Forms.Button();
            this.ATTserverPort = new System.Windows.Forms.TextBox();
            this.ATTserverAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "serverAddress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(38, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "serverPort";
            // 
            // PPGserverAddress
            // 
            this.PPGserverAddress.Location = new System.Drawing.Point(40, 97);
            this.PPGserverAddress.Name = "PPGserverAddress";
            this.PPGserverAddress.Size = new System.Drawing.Size(140, 21);
            this.PPGserverAddress.TabIndex = 2;
            // 
            // PPGserverPort
            // 
            this.PPGserverPort.Location = new System.Drawing.Point(40, 157);
            this.PPGserverPort.Name = "PPGserverPort";
            this.PPGserverPort.Size = new System.Drawing.Size(140, 21);
            this.PPGserverPort.TabIndex = 3;
            // 
            // saveConfig
            // 
            this.saveConfig.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveConfig.Location = new System.Drawing.Point(40, 218);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(340, 32);
            this.saveConfig.TabIndex = 4;
            this.saveConfig.Text = "Save Config";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // ATTserverPort
            // 
            this.ATTserverPort.Location = new System.Drawing.Point(240, 157);
            this.ATTserverPort.Name = "ATTserverPort";
            this.ATTserverPort.Size = new System.Drawing.Size(140, 21);
            this.ATTserverPort.TabIndex = 13;
            // 
            // ATTserverAddress
            // 
            this.ATTserverAddress.Location = new System.Drawing.Point(240, 97);
            this.ATTserverAddress.Name = "ATTserverAddress";
            this.ATTserverAddress.Size = new System.Drawing.Size(140, 21);
            this.ATTserverAddress.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(238, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "serverPort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(238, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "serverAddress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(37, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "PPG TCP SET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(237, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "ATT TCP SET";
            // 
            // SubFormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 284);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ATTserverPort);
            this.Controls.Add(this.ATTserverAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.PPGserverPort);
            this.Controls.Add(this.PPGserverAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubFormConnect";
            this.Text = "TCP Connect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PPGserverAddress;
        private System.Windows.Forms.TextBox PPGserverPort;
        private System.Windows.Forms.Button saveConfig; 
        private System.Windows.Forms.TextBox ATTserverPort;
        private System.Windows.Forms.TextBox ATTserverAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}