namespace ATMMachine
{
    partial class MainMenu
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
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_AccountBalance = new System.Windows.Forms.Button();
            this.btn_ChangePin = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(165, 82);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(115, 52);
            this.btn_Withdraw.TabIndex = 0;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(164, 195);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(116, 52);
            this.btn_Deposit.TabIndex = 1;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_AccountBalance
            // 
            this.btn_AccountBalance.Location = new System.Drawing.Point(446, 195);
            this.btn_AccountBalance.Name = "btn_AccountBalance";
            this.btn_AccountBalance.Size = new System.Drawing.Size(115, 52);
            this.btn_AccountBalance.TabIndex = 2;
            this.btn_AccountBalance.Text = "Account Balance";
            this.btn_AccountBalance.UseVisualStyleBackColor = true;
            this.btn_AccountBalance.Click += new System.EventHandler(this.btn_AccountBalance_Click);
            // 
            // btn_ChangePin
            // 
            this.btn_ChangePin.Location = new System.Drawing.Point(446, 82);
            this.btn_ChangePin.Name = "btn_ChangePin";
            this.btn_ChangePin.Size = new System.Drawing.Size(115, 52);
            this.btn_ChangePin.TabIndex = 3;
            this.btn_ChangePin.Text = "Change Pin";
            this.btn_ChangePin.UseVisualStyleBackColor = true;
            this.btn_ChangePin.Click += new System.EventHandler(this.btn_ChangePin_Click);
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(446, 296);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(116, 52);
            this.btn_History.TabIndex = 4;
            this.btn_History.Text = "Account History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Location = new System.Drawing.Point(164, 296);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(116, 52);
            this.btn_SignOut.TabIndex = 5;
            this.btn_SignOut.Text = "Sign Out";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.btn_ChangePin);
            this.Controls.Add(this.btn_AccountBalance);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_Withdraw);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_AccountBalance;
        private System.Windows.Forms.Button btn_ChangePin;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_SignOut;
    }
}