namespace INSERT_DELETE_SELECT_БД
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelOldLogin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRegDate = new System.Windows.Forms.Label();
            this.labelNewLogin = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.textBoxNewLogin = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLockPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(113, 203);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(96, 36);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "старый login:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(85, 21);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 3;
            // 
            // labelOldLogin
            // 
            this.labelOldLogin.AutoSize = true;
            this.labelOldLogin.Location = new System.Drawing.Point(110, 104);
            this.labelOldLogin.Name = "labelOldLogin";
            this.labelOldLogin.Size = new System.Drawing.Size(0, 13);
            this.labelOldLogin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "старый password:";
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Location = new System.Drawing.Point(110, 141);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(0, 13);
            this.labelOldPass.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "registration date:";
            // 
            // labelRegDate
            // 
            this.labelRegDate.AutoSize = true;
            this.labelRegDate.Location = new System.Drawing.Point(321, 21);
            this.labelRegDate.Name = "labelRegDate";
            this.labelRegDate.Size = new System.Drawing.Size(0, 13);
            this.labelRegDate.TabIndex = 8;
            // 
            // labelNewLogin
            // 
            this.labelNewLogin.AutoSize = true;
            this.labelNewLogin.Location = new System.Drawing.Point(389, 104);
            this.labelNewLogin.Name = "labelNewLogin";
            this.labelNewLogin.Size = new System.Drawing.Size(67, 13);
            this.labelNewLogin.TabIndex = 9;
            this.labelNewLogin.Text = "новый login:";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(366, 141);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(90, 13);
            this.labelNewPass.TabIndex = 10;
            this.labelNewPass.Text = "новый password:";
            // 
            // textBoxNewLogin
            // 
            this.textBoxNewLogin.Location = new System.Drawing.Point(462, 101);
            this.textBoxNewLogin.Name = "textBoxNewLogin";
            this.textBoxNewLogin.Size = new System.Drawing.Size(134, 20);
            this.textBoxNewLogin.TabIndex = 11;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(462, 138);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(134, 20);
            this.textBoxNewPass.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // buttonLockPass
            // 
            this.buttonLockPass.Image = ((System.Drawing.Image)(resources.GetObject("buttonLockPass.Image")));
            this.buttonLockPass.Location = new System.Drawing.Point(603, 138);
            this.buttonLockPass.Name = "buttonLockPass";
            this.buttonLockPass.Size = new System.Drawing.Size(31, 23);
            this.buttonLockPass.TabIndex = 14;
            this.buttonLockPass.UseVisualStyleBackColor = true;
            this.buttonLockPass.Click += new System.EventHandler(this.buttonLockPass_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 264);
            this.Controls.Add(this.buttonLockPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxNewLogin);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelNewLogin);
            this.Controls.Add(this.labelRegDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOldPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelOldLogin);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChange);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelOldLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRegDate;
        private System.Windows.Forms.Label labelNewLogin;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.TextBox textBoxNewLogin;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLockPass;
    }
}