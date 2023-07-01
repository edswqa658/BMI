namespace BMI
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            tboxKG = new TextBox();
            tboxCM = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            lblVideoLink = new LinkLabel();
            lblRet = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            tbarRet = new TrackBar();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbarRet).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tboxKG);
            groupBox1.Controls.Add(tboxCM);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 68);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "등록";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 26);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "몸무게(kg)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "신장(cm)";
            // 
            // tboxKG
            // 
            tboxKG.Location = new Point(289, 22);
            tboxKG.Name = "tboxKG";
            tboxKG.Size = new Size(100, 23);
            tboxKG.TabIndex = 1;
            // 
            // tboxCM
            // 
            tboxCM.Location = new Point(87, 23);
            tboxCM.Name = "tboxCM";
            tboxCM.Size = new Size(100, 23);
            tboxCM.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(421, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "계산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblVideoLink);
            groupBox2.Controls.Add(lblRet);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbarRet);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 153);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "결과";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblVideoLink
            // 
            lblVideoLink.Location = new Point(15, 123);
            lblVideoLink.Name = "lblVideoLink";
            lblVideoLink.Size = new Size(469, 16);
            lblVideoLink.TabIndex = 4;
            lblVideoLink.LinkClicked += lblVideoLink_LinkClicked;
            // 
            // lblRet
            // 
            lblRet.Location = new Point(15, 97);
            lblRet.Name = "lblRet";
            lblRet.Size = new Size(477, 15);
            lblRet.TabIndex = 3;
            // 
            // label7
            // 
            label7.BackColor = Color.LawnGreen;
            label7.Location = new Point(156, 43);
            label7.Name = "label7";
            label7.Size = new Size(154, 22);
            label7.TabIndex = 2;
            label7.Text = "정상";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.Red;
            label9.Location = new Point(378, 43);
            label9.Name = "label9";
            label9.Size = new Size(106, 22);
            label9.TabIndex = 2;
            label9.Text = "비만";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Moccasin;
            label8.Location = new Point(307, 43);
            label8.Name = "label8";
            label8.Size = new Size(72, 22);
            label8.TabIndex = 2;
            label8.Text = "과체중";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(36, 43);
            label6.Name = "label6";
            label6.Size = new Size(122, 22);
            label6.TabIndex = 2;
            label6.Text = "저체중";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbarRet
            // 
            tbarRet.Enabled = false;
            tbarRet.Location = new Point(24, 58);
            tbarRet.Maximum = 280;
            tbarRet.Minimum = 150;
            tbarRet.Name = "tbarRet";
            tbarRet.Size = new Size(468, 45);
            tbarRet.TabIndex = 3;
            tbarRet.TickStyle = TickStyle.TopLeft;
            tbarRet.Value = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 28);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 2;
            label5.Text = "25";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 28);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 2;
            label4.Text = "23";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 28);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "18.5";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 258);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BMI 계산기";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbarRet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox tboxKG;
        private TextBox tboxCM;
        private Button button1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private TrackBar tbarRet;
        private Label lblRet;
        private LinkLabel lblVideoLink;
    }
}