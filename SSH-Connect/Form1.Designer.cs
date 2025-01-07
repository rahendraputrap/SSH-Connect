namespace SSH_Connect
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
            inIP = new TextBox();
            label2 = new Label();
            BtnOK = new Button();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            inPort = new ComboBox();
            SuspendLayout();
            // 
            // inIP
            // 
            inIP.Location = new Point(55, 12);
            inIP.Name = "inIP";
            inIP.Size = new Size(177, 23);
            inIP.TabIndex = 0;
            inIP.KeyPress += inIP_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(55, 70);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 23);
            BtnOK.TabIndex = 4;
            BtnOK.Text = "Connect";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 109);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 133);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 7;
            label1.Text = "IP";
            // 
            // inPort
            // 
            inPort.FormattingEnabled = true;
            inPort.Location = new Point(55, 41);
            inPort.Name = "inPort";
            inPort.Size = new Size(48, 23);
            inPort.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 166);
            Controls.Add(inPort);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnOK);
            Controls.Add(label2);
            Controls.Add(inIP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inIP;
        private Label label2;
        private Button BtnOK;
        private Label label3;
        private Label label4;
        private Label label1;
        private ComboBox inPort;
    }
}
