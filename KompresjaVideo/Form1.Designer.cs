namespace KompresjaVideo
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
            this.groupBoxVlc = new System.Windows.Forms.GroupBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.btnVlcLocation = new System.Windows.Forms.Button();
            this.textBoxVlcLocation = new System.Windows.Forms.TextBox();
            this.labelVlcLocation = new System.Windows.Forms.Label();
            this.comboBoxAudioCodec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Auid = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVideoCodec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonTranscode = new System.Windows.Forms.Button();
            this.buttonFileInput = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxVideoBitRate = new System.Windows.Forms.TextBox();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.textBoxAudioBitRate = new System.Windows.Forms.TextBox();
            this.groupBoxVlc.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.Auid.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVlc
            // 
            this.groupBoxVlc.Controls.Add(this.textBoxInput);
            this.groupBoxVlc.Controls.Add(this.buttonFileInput);
            this.groupBoxVlc.Controls.Add(this.labelVlcLocation);
            this.groupBoxVlc.Controls.Add(this.btnVlcLocation);
            this.groupBoxVlc.Controls.Add(this.textBoxVlcLocation);
            this.groupBoxVlc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVlc.Name = "groupBoxVlc";
            this.groupBoxVlc.Size = new System.Drawing.Size(544, 82);
            this.groupBoxVlc.TabIndex = 0;
            this.groupBoxVlc.TabStop = false;
            this.groupBoxVlc.Text = "Input";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.groupBox4);
            this.groupBoxSettings.Controls.Add(this.Auid);
            this.groupBoxSettings.Enabled = false;
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 100);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(544, 152);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // btnVlcLocation
            // 
            this.btnVlcLocation.Location = new System.Drawing.Point(455, 19);
            this.btnVlcLocation.Name = "btnVlcLocation";
            this.btnVlcLocation.Size = new System.Drawing.Size(80, 23);
            this.btnVlcLocation.TabIndex = 0;
            this.btnVlcLocation.Text = "Set location";
            this.btnVlcLocation.UseVisualStyleBackColor = true;
            this.btnVlcLocation.Click += new System.EventHandler(this.btnVlcLocation_Click);
            // 
            // textBoxVlcLocation
            // 
            this.textBoxVlcLocation.Location = new System.Drawing.Point(110, 21);
            this.textBoxVlcLocation.Name = "textBoxVlcLocation";
            this.textBoxVlcLocation.ReadOnly = true;
            this.textBoxVlcLocation.Size = new System.Drawing.Size(339, 20);
            this.textBoxVlcLocation.TabIndex = 1;
            // 
            // labelVlcLocation
            // 
            this.labelVlcLocation.AutoSize = true;
            this.labelVlcLocation.Location = new System.Drawing.Point(6, 24);
            this.labelVlcLocation.Name = "labelVlcLocation";
            this.labelVlcLocation.Size = new System.Drawing.Size(92, 13);
            this.labelVlcLocation.TabIndex = 2;
            this.labelVlcLocation.Text = "Status: no vlc.exe";
            // 
            // comboBoxAudioCodec
            // 
            this.comboBoxAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioCodec.FormattingEnabled = true;
            this.comboBoxAudioCodec.Location = new System.Drawing.Point(54, 13);
            this.comboBoxAudioCodec.Name = "comboBoxAudioCodec";
            this.comboBoxAudioCodec.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAudioCodec.TabIndex = 0;
            this.comboBoxAudioCodec.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioCodec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codec:";
            // 
            // Auid
            // 
            this.Auid.Controls.Add(this.textBoxAudioBitRate);
            this.Auid.Controls.Add(this.label2);
            this.Auid.Controls.Add(this.label3);
            this.Auid.Controls.Add(this.comboBoxAudioCodec);
            this.Auid.Location = new System.Drawing.Point(275, 19);
            this.Auid.Name = "Auid";
            this.Auid.Size = new System.Drawing.Size(260, 74);
            this.Auid.TabIndex = 4;
            this.Auid.TabStop = false;
            this.Auid.Text = "Audio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxScale);
            this.groupBox4.Controls.Add(this.textBoxFPS);
            this.groupBox4.Controls.Add(this.textBoxVideoBitRate);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.comboBoxVideoCodec);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(9, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 126);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codec:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BitRate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BitRate:";
            // 
            // comboBoxVideoCodec
            // 
            this.comboBoxVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoCodec.FormattingEnabled = true;
            this.comboBoxVideoCodec.Location = new System.Drawing.Point(54, 13);
            this.comboBoxVideoCodec.Name = "comboBoxVideoCodec";
            this.comboBoxVideoCodec.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVideoCodec.TabIndex = 6;
            this.comboBoxVideoCodec.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoCodec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FPS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Scale:";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.buttonTranscode);
            this.groupBoxOutput.Controls.Add(this.richTextBoxOutput);
            this.groupBoxOutput.Controls.Add(this.textBoxOutput);
            this.groupBoxOutput.Controls.Add(this.buttonOutput);
            this.groupBoxOutput.Enabled = false;
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 258);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(544, 183);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(452, 17);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(83, 23);
            this.buttonOutput.TabIndex = 3;
            this.buttonOutput.Text = "Set location";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(443, 20);
            this.textBoxOutput.TabIndex = 3;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(6, 45);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(529, 103);
            this.richTextBoxOutput.TabIndex = 4;
            this.richTextBoxOutput.Text = "";
            // 
            // buttonTranscode
            // 
            this.buttonTranscode.Enabled = false;
            this.buttonTranscode.Location = new System.Drawing.Point(329, 154);
            this.buttonTranscode.Name = "buttonTranscode";
            this.buttonTranscode.Size = new System.Drawing.Size(206, 23);
            this.buttonTranscode.TabIndex = 5;
            this.buttonTranscode.Text = "Transcode";
            this.buttonTranscode.UseVisualStyleBackColor = true;
            this.buttonTranscode.Click += new System.EventHandler(this.buttonTranscode_Click);
            // 
            // buttonFileInput
            // 
            this.buttonFileInput.Location = new System.Drawing.Point(455, 48);
            this.buttonFileInput.Name = "buttonFileInput";
            this.buttonFileInput.Size = new System.Drawing.Size(80, 23);
            this.buttonFileInput.TabIndex = 3;
            this.buttonFileInput.Text = "File";
            this.buttonFileInput.UseVisualStyleBackColor = true;
            this.buttonFileInput.Click += new System.EventHandler(this.buttonFileInput_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(110, 50);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.Size = new System.Drawing.Size(339, 20);
            this.textBoxInput.TabIndex = 4;
            // 
            // textBoxVideoBitRate
            // 
            this.textBoxVideoBitRate.Location = new System.Drawing.Point(54, 42);
            this.textBoxVideoBitRate.Name = "textBoxVideoBitRate";
            this.textBoxVideoBitRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxVideoBitRate.TabIndex = 13;
            this.textBoxVideoBitRate.TextChanged += new System.EventHandler(this.textBoxVideoBitRate_TextChanged);
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Location = new System.Drawing.Point(54, 69);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPS.TabIndex = 14;
            this.textBoxFPS.TextChanged += new System.EventHandler(this.textBoxFPS_TextChanged);
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(54, 96);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(100, 20);
            this.textBoxScale.TabIndex = 15;
            this.textBoxScale.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            // 
            // textBoxAudioBitRate
            // 
            this.textBoxAudioBitRate.Location = new System.Drawing.Point(54, 42);
            this.textBoxAudioBitRate.Name = "textBoxAudioBitRate";
            this.textBoxAudioBitRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxAudioBitRate.TabIndex = 16;
            this.textBoxAudioBitRate.TextChanged += new System.EventHandler(this.textBoxAudioBitRate_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 449);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxVlc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxVlc.ResumeLayout(false);
            this.groupBoxVlc.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.Auid.ResumeLayout(false);
            this.Auid.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVlc;
        private System.Windows.Forms.TextBox textBoxVlcLocation;
        private System.Windows.Forms.Button btnVlcLocation;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label labelVlcLocation;
        private System.Windows.Forms.ComboBox comboBoxAudioCodec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxVideoCodec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Auid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonTranscode;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonFileInput;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.TextBox textBoxVideoBitRate;
        private System.Windows.Forms.TextBox textBoxAudioBitRate;
    }
}

