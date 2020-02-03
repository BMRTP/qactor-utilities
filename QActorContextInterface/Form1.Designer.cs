namespace QActorContextInterface
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
            this.label7 = new System.Windows.Forms.Label();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMessageID = new System.Windows.Forms.TextBox();
            this.txbMit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMessageType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.txbDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.txbIPAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMessage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Message:";
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(98, 214);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(164, 20);
            this.txbMessage.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Message ID:";
            // 
            // txbMessageID
            // 
            this.txbMessageID.Location = new System.Drawing.Point(98, 188);
            this.txbMessageID.Name = "txbMessageID";
            this.txbMessageID.Size = new System.Drawing.Size(164, 20);
            this.txbMessageID.TabIndex = 29;
            // 
            // txbMit
            // 
            this.txbMit.Location = new System.Drawing.Point(98, 162);
            this.txbMit.Name = "txbMit";
            this.txbMit.Size = new System.Drawing.Size(164, 20);
            this.txbMit.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Dest:";
            // 
            // cmbMessageType
            // 
            this.cmbMessageType.FormattingEnabled = true;
            this.cmbMessageType.Items.AddRange(new object[] {
            "event",
            "dispatch",
            "request",
            "response"});
            this.cmbMessageType.Location = new System.Drawing.Point(98, 109);
            this.cmbMessageType.Name = "cmbMessageType";
            this.cmbMessageType.Size = new System.Drawing.Size(164, 21);
            this.cmbMessageType.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Message Type:";
            // 
            // lstOutput
            // 
            this.lstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(268, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(321, 329);
            this.lstOutput.TabIndex = 24;
            this.lstOutput.TabStop = false;
            // 
            // txbDest
            // 
            this.txbDest.Location = new System.Drawing.Point(98, 136);
            this.txbDest.Name = "txbDest";
            this.txbDest.Size = new System.Drawing.Size(164, 20);
            this.txbDest.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Port:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(15, 15);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(58, 13);
            this.lblIP.TabIndex = 21;
            this.lblIP.Text = "IPAddress:";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(79, 38);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(183, 20);
            this.txbPort.TabIndex = 2;
            this.txbPort.Text = "8018";
            // 
            // txbIPAddress
            // 
            this.txbIPAddress.Location = new System.Drawing.Point(79, 12);
            this.txbIPAddress.Name = "txbIPAddress";
            this.txbIPAddress.Size = new System.Drawing.Size(183, 20);
            this.txbIPAddress.TabIndex = 1;
            this.txbIPAddress.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 64);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(247, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(15, 240);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(247, 23);
            this.btnSend.TabIndex = 31;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(12, 318);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(250, 23);
            this.btnSend2.TabIndex = 33;
            this.btnSend2.Text = "Send";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Complete message:";
            // 
            // cmbMessage
            // 
            this.cmbMessage.FormattingEnabled = true;
            this.cmbMessage.Location = new System.Drawing.Point(12, 291);
            this.cmbMessage.Name = "cmbMessage";
            this.cmbMessage.Size = new System.Drawing.Size(250, 21);
            this.cmbMessage.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 350);
            this.Controls.Add(this.cmbMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbMessageID);
            this.Controls.Add(this.txbMit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMessageType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txbDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.txbIPAddress);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "QActor Context Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMessageID;
        private System.Windows.Forms.TextBox txbMit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMessageType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.TextBox txbDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.TextBox txbIPAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMessage;
    }
}

