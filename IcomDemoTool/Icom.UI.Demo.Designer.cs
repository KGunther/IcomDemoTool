﻿namespace Icom.UI
{
    partial class Demo
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
            myCIV.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPorts = new System.Windows.Forms.ListBox();
            this.lbRadios = new System.Windows.Forms.ListBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.mlText = new System.Windows.Forms.TextBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.cmdFind = new System.Windows.Forms.Button();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.cmdTune = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPorts
            // 
            this.lbPorts.FormattingEnabled = true;
            this.lbPorts.ItemHeight = 20;
            this.lbPorts.Location = new System.Drawing.Point(39, 54);
            this.lbPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPorts.Name = "lbPorts";
            this.lbPorts.Size = new System.Drawing.Size(174, 104);
            this.lbPorts.TabIndex = 0;
            // 
            // lbRadios
            // 
            this.lbRadios.FormattingEnabled = true;
            this.lbRadios.ItemHeight = 20;
            this.lbRadios.Location = new System.Drawing.Point(250, 54);
            this.lbRadios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbRadios.Name = "lbRadios";
            this.lbRadios.Size = new System.Drawing.Size(187, 104);
            this.lbRadios.TabIndex = 1;
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(39, 171);
            this.cmdConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(176, 32);
            this.cmdConnect.TabIndex = 2;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // mlText
            // 
            this.mlText.Location = new System.Drawing.Point(39, 297);
            this.mlText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mlText.Multiline = true;
            this.mlText.Name = "mlText";
            this.mlText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mlText.Size = new System.Drawing.Size(398, 193);
            this.mlText.TabIndex = 3;
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(250, 212);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(189, 34);
            this.cmdSend.TabIndex = 4;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(250, 168);
            this.cmdFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(189, 35);
            this.cmdFind.TabIndex = 5;
            this.cmdFind.Text = "Find Radio";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Location = new System.Drawing.Point(39, 217);
            this.cmdDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(176, 29);
            this.cmdDisconnect.TabIndex = 6;
            this.cmdDisconnect.Text = "Disconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(39, 257);
            this.txtFrequency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(172, 26);
            this.txtFrequency.TabIndex = 7;
            // 
            // cmdTune
            // 
            this.cmdTune.Location = new System.Drawing.Point(250, 254);
            this.cmdTune.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdTune.Name = "cmdTune";
            this.cmdTune.Size = new System.Drawing.Size(189, 34);
            this.cmdTune.TabIndex = 8;
            this.cmdTune.Text = "Tune";
            this.cmdTune.UseVisualStyleBackColor = true;
            this.cmdTune.Click += new System.EventHandler(this.cmdTune_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 511);
            this.Controls.Add(this.cmdTune);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.cmdDisconnect);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.mlText);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.lbRadios);
            this.Controls.Add(this.lbPorts);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Demo";
            this.Text = "Icom Demo";
            this.Load += new System.EventHandler(this.IcomDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPorts;
        private System.Windows.Forms.ListBox lbRadios;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.TextBox mlText;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Button cmdTune;
    }
}

