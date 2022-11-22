namespace CarRentalApp
{
    partial class ResetPassword
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
            this.lblEnterPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.tbEnterPass = new System.Windows.Forms.TextBox();
            this.tbConfirmPss = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterPass
            // 
            this.lblEnterPass.AutoSize = true;
            this.lblEnterPass.Location = new System.Drawing.Point(177, 21);
            this.lblEnterPass.Name = "lblEnterPass";
            this.lblEnterPass.Size = new System.Drawing.Size(106, 13);
            this.lblEnterPass.TabIndex = 0;
            this.lblEnterPass.Text = "Enter new password:";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(177, 113);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(93, 13);
            this.lblConfirmPass.TabIndex = 1;
            this.lblConfirmPass.Text = "Confirm password:";
            // 
            // tbEnterPass
            // 
            this.tbEnterPass.Location = new System.Drawing.Point(150, 51);
            this.tbEnterPass.Name = "tbEnterPass";
            this.tbEnterPass.Size = new System.Drawing.Size(162, 20);
            this.tbEnterPass.TabIndex = 2;
            // 
            // tbConfirmPss
            // 
            this.tbConfirmPss.Location = new System.Drawing.Point(150, 144);
            this.tbConfirmPss.Name = "tbConfirmPss";
            this.tbConfirmPss.Size = new System.Drawing.Size(162, 20);
            this.tbConfirmPss.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(180, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 36);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset password";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 271);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbConfirmPss);
            this.Controls.Add(this.tbEnterPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblEnterPass);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox tbEnterPass;
        private System.Windows.Forms.TextBox tbConfirmPss;
        private System.Windows.Forms.Button btnReset;
    }
}