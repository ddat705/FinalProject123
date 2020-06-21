namespace FinalProject
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInforUser = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbPictureUser = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabInforUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPictureUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInforUser);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInforUser
            // 
            this.tabInforUser.Controls.Add(this.panel1);
            this.tabInforUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInforUser.Location = new System.Drawing.Point(4, 25);
            this.tabInforUser.Name = "tabInforUser";
            this.tabInforUser.Padding = new System.Windows.Forms.Padding(5);
            this.tabInforUser.Size = new System.Drawing.Size(711, 360);
            this.tabInforUser.TabIndex = 0;
            this.tabInforUser.Text = "Thông tin tài khoản";
            this.tabInforUser.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 348);
            this.panel1.TabIndex = 0;
            // 
            // ptbPictureUser
            // 
            this.ptbPictureUser.Location = new System.Drawing.Point(3, 3);
            this.ptbPictureUser.Name = "ptbPictureUser";
            this.ptbPictureUser.Size = new System.Drawing.Size(150, 175);
            this.ptbPictureUser.TabIndex = 0;
            this.ptbPictureUser.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(213, 33);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(102, 24);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ptbPictureUser);
            this.panel2.Location = new System.Drawing.Point(28, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 183);
            this.panel2.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(213, 93);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(95, 24);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "SĐT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chức vụ:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(321, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(321, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(321, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 42);
            this.label6.TabIndex = 9;
            this.label6.Text = "Username:";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(321, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 42);
            this.label7.TabIndex = 10;
            this.label7.Text = "Username:";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(321, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 42);
            this.label8.TabIndex = 11;
            this.label8.Text = "Username:";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInforUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPictureUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInforUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox ptbPictureUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

