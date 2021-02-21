namespace LociPoint.UC
{
    partial class WordsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbRecallSecs = new System.Windows.Forms.TextBox();
            this.tbHrs = new System.Windows.Forms.TextBox();
            this.tbRecallMins = new System.Windows.Forms.TextBox();
            this.tbMins = new System.Windows.Forms.TextBox();
            this.tbRecallHrs = new System.Windows.Forms.TextBox();
            this.tbSecs = new System.Windows.Forms.TextBox();
            this.lblRecallTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(606, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 42);
            this.label1.TabIndex = 44;
            this.label1.Text = "Words";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(486, 581);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(374, 98);
            this.btnStart.TabIndex = 43;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericAmount
            // 
            this.numericAmount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericAmount.Location = new System.Drawing.Point(486, 246);
            this.numericAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numericAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(375, 37);
            this.numericAmount.TabIndex = 34;
            this.numericAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAmount.Location = new System.Drawing.Point(481, 213);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(108, 30);
            this.lblAmount.TabIndex = 33;
            this.lblAmount.Text = "Amount";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTime.Location = new System.Drawing.Point(481, 320);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 30);
            this.lblTime.TabIndex = 72;
            this.lblTime.Text = "Time";
            // 
            // tbRecallSecs
            // 
            this.tbRecallSecs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbRecallSecs.Location = new System.Drawing.Point(747, 487);
            this.tbRecallSecs.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecallSecs.Name = "tbRecallSecs";
            this.tbRecallSecs.Size = new System.Drawing.Size(114, 37);
            this.tbRecallSecs.TabIndex = 79;
            // 
            // tbHrs
            // 
            this.tbHrs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbHrs.Location = new System.Drawing.Point(487, 367);
            this.tbHrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbHrs.Name = "tbHrs";
            this.tbHrs.Size = new System.Drawing.Size(111, 37);
            this.tbHrs.TabIndex = 73;
            // 
            // tbRecallMins
            // 
            this.tbRecallMins.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbRecallMins.Location = new System.Drawing.Point(615, 487);
            this.tbRecallMins.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecallMins.Name = "tbRecallMins";
            this.tbRecallMins.Size = new System.Drawing.Size(111, 37);
            this.tbRecallMins.TabIndex = 78;
            // 
            // tbMins
            // 
            this.tbMins.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbMins.Location = new System.Drawing.Point(615, 367);
            this.tbMins.Margin = new System.Windows.Forms.Padding(4);
            this.tbMins.Name = "tbMins";
            this.tbMins.Size = new System.Drawing.Size(111, 37);
            this.tbMins.TabIndex = 74;
            // 
            // tbRecallHrs
            // 
            this.tbRecallHrs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbRecallHrs.Location = new System.Drawing.Point(486, 487);
            this.tbRecallHrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecallHrs.Name = "tbRecallHrs";
            this.tbRecallHrs.Size = new System.Drawing.Size(111, 37);
            this.tbRecallHrs.TabIndex = 77;
            // 
            // tbSecs
            // 
            this.tbSecs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbSecs.Location = new System.Drawing.Point(747, 367);
            this.tbSecs.Margin = new System.Windows.Forms.Padding(4);
            this.tbSecs.Name = "tbSecs";
            this.tbSecs.Size = new System.Drawing.Size(114, 37);
            this.tbSecs.TabIndex = 75;
            // 
            // lblRecallTime
            // 
            this.lblRecallTime.AutoSize = true;
            this.lblRecallTime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRecallTime.Location = new System.Drawing.Point(481, 440);
            this.lblRecallTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecallTime.Name = "lblRecallTime";
            this.lblRecallTime.Size = new System.Drawing.Size(152, 30);
            this.lblRecallTime.TabIndex = 76;
            this.lblRecallTime.Text = "Recall Time";
            // 
            // WordsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tbRecallSecs);
            this.Controls.Add(this.tbHrs);
            this.Controls.Add(this.tbRecallMins);
            this.Controls.Add(this.tbMins);
            this.Controls.Add(this.tbRecallHrs);
            this.Controls.Add(this.tbSecs);
            this.Controls.Add(this.lblRecallTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.lblAmount);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WordsUC";
            this.Size = new System.Drawing.Size(1374, 861);
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox tbRecallSecs;
        private System.Windows.Forms.TextBox tbHrs;
        private System.Windows.Forms.TextBox tbRecallMins;
        private System.Windows.Forms.TextBox tbMins;
        private System.Windows.Forms.TextBox tbRecallHrs;
        private System.Windows.Forms.TextBox tbSecs;
        private System.Windows.Forms.Label lblRecallTime;
    }
}
