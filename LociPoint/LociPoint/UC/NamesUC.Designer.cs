namespace LociPoint.UC
{
    partial class NamesUC
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(525, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 41);
            this.label1.TabIndex = 77;
            this.label1.Text = "Names and Faces";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCountry.Location = new System.Drawing.Point(513, 254);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(107, 30);
            this.lblCountry.TabIndex = 75;
            this.lblCountry.Text = "Country";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "All",
            "England",
            "Greece",
            "Japan"});
            this.cbCountry.Location = new System.Drawing.Point(519, 295);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(347, 38);
            this.cbCountry.TabIndex = 76;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblType.Location = new System.Drawing.Point(513, 155);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 30);
            this.lblType.TabIndex = 73;
            this.lblType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Names and Faces",
            "Names"});
            this.cbType.Location = new System.Drawing.Point(519, 196);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(347, 38);
            this.cbType.TabIndex = 74;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAmount.Location = new System.Drawing.Point(513, 359);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(108, 30);
            this.lblAmount.TabIndex = 62;
            this.lblAmount.Text = "Amount";
            // 
            // numericAmount
            // 
            this.numericAmount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericAmount.Location = new System.Drawing.Point(519, 392);
            this.numericAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(347, 37);
            this.numericAmount.TabIndex = 63;
            this.numericAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(518, 709);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(348, 93);
            this.btnStart.TabIndex = 72;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTime.Location = new System.Drawing.Point(513, 458);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 30);
            this.lblTime.TabIndex = 64;
            this.lblTime.Text = "Time";
            // 
            // tbRecallSecs
            // 
            this.tbRecallSecs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbRecallSecs.Location = new System.Drawing.Point(754, 626);
            this.tbRecallSecs.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecallSecs.Name = "tbRecallSecs";
            this.tbRecallSecs.Size = new System.Drawing.Size(112, 37);
            this.tbRecallSecs.TabIndex = 71;
            // 
            // tbHrs
            // 
            this.tbHrs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbHrs.Location = new System.Drawing.Point(519, 506);
            this.tbHrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbHrs.Name = "tbHrs";
            this.tbHrs.Size = new System.Drawing.Size(112, 37);
            this.tbHrs.TabIndex = 65;
            // 
            // tbRecallMins
            // 
            this.tbRecallMins.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbRecallMins.Location = new System.Drawing.Point(638, 626);
            this.tbRecallMins.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecallMins.Name = "tbRecallMins";
            this.tbRecallMins.Size = new System.Drawing.Size(112, 37);
            this.tbRecallMins.TabIndex = 70;
            // 
            // tbMins
            // 
            this.tbMins.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbMins.Location = new System.Drawing.Point(637, 506);
            this.tbMins.Margin = new System.Windows.Forms.Padding(4);
            this.tbMins.Name = "tbMins";
            this.tbMins.Size = new System.Drawing.Size(112, 37);
            this.tbMins.TabIndex = 66;
            // 
            // tbRecallHrs
            // 
            this.tbRecallHrs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbRecallHrs.Location = new System.Drawing.Point(519, 626);
            this.tbRecallHrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecallHrs.Name = "tbRecallHrs";
            this.tbRecallHrs.Size = new System.Drawing.Size(112, 37);
            this.tbRecallHrs.TabIndex = 69;
            // 
            // tbSecs
            // 
            this.tbSecs.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbSecs.Location = new System.Drawing.Point(754, 506);
            this.tbSecs.Margin = new System.Windows.Forms.Padding(4);
            this.tbSecs.Name = "tbSecs";
            this.tbSecs.Size = new System.Drawing.Size(112, 37);
            this.tbSecs.TabIndex = 67;
            // 
            // lblRecallTime
            // 
            this.lblRecallTime.AutoSize = true;
            this.lblRecallTime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRecallTime.Location = new System.Drawing.Point(513, 578);
            this.lblRecallTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecallTime.Name = "lblRecallTime";
            this.lblRecallTime.Size = new System.Drawing.Size(152, 30);
            this.lblRecallTime.TabIndex = 68;
            this.lblRecallTime.Text = "Recall Time";
            // 
            // NamesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tbRecallSecs);
            this.Controls.Add(this.tbHrs);
            this.Controls.Add(this.tbRecallMins);
            this.Controls.Add(this.tbMins);
            this.Controls.Add(this.tbRecallHrs);
            this.Controls.Add(this.tbSecs);
            this.Controls.Add(this.lblRecallTime);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NamesUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.NamesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Button btnStart;
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
