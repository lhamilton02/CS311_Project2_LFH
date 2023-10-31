namespace Craps
{
    partial class frmMain
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
            btnRoll = new Button();
            lblDiceValue1 = new Label();
            lblDiceValue2 = new Label();
            lblBankBalance = new Label();
            txtboxBetValue = new TextBox();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(289, 33);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(349, 172);
            btnRoll.TabIndex = 0;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblDiceValue1
            // 
            lblDiceValue1.AutoSize = true;
            lblDiceValue1.Location = new Point(12, 276);
            lblDiceValue1.Name = "lblDiceValue1";
            lblDiceValue1.Size = new Size(100, 32);
            lblDiceValue1.TabIndex = 1;
            lblDiceValue1.Text = "";
            lblDiceValue1.Click += lblDiceValue1_Click;
            // 
            // lblDiceValue2
            // 
            lblDiceValue2.AutoSize = true;
            lblDiceValue2.Location = new Point(12, 353);
            lblDiceValue2.Name = "lblDiceValue2";
            lblDiceValue2.Size = new Size(65, 32);
            lblDiceValue2.TabIndex = 2;
            lblDiceValue2.Text = "";
            // 
            // lblBankBalance
            // 
            lblBankBalance.AutoSize = true;
            lblBankBalance.Location = new Point(12, 33);
            lblBankBalance.Name = "lblBankBalance";
            lblBankBalance.Size = new Size(219, 32);
            lblBankBalance.TabIndex = 3;
            lblBankBalance.Text = "Bank Balance: $100";
            lblBankBalance.Click += lblBankBalance_Click;
            // 
            // txtboxBetValue
            // 
            txtboxBetValue.Location = new Point(12, 68);
            txtboxBetValue.Name = "txtboxBetValue";
            txtboxBetValue.PlaceholderText = "Enter Your Bet";
            txtboxBetValue.Size = new Size(200, 39);
            txtboxBetValue.TabIndex = 4;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(574, 335);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(86, 32);
            lblDisplay.TabIndex = 5;
            lblDisplay.Text = "";
            lblDisplay.Click += lblDisplay_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(txtboxBetValue);
            Controls.Add(lblBankBalance);
            Controls.Add(lblDiceValue2);
            Controls.Add(lblDiceValue1);
            Controls.Add(btnRoll);
            Name = "frmMain";
            Text = "Craps";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoll;
        private Label lblDiceValue1;
        private Label lblDiceValue2;
        private Label lblBankBalance;
        private TextBox txtboxBetValue;
        private Label lblDisplay;
    }
}