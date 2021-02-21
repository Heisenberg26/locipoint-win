namespace LociPoint.UC
{
    partial class CreateNewUC
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.panelPAO = new System.Windows.Forms.Panel();
            this.lblNumRange = new System.Windows.Forms.Label();
            this.cbNumRange = new System.Windows.Forms.ComboBox();
            this.panelPalace = new System.Windows.Forms.Panel();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.nudRoomNum = new System.Windows.Forms.NumericUpDown();
            this.panelPAO.SuspendLayout();
            this.panelPalace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(564, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Create New";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(516, 501);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(326, 90);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Memory Palaces",
            "Person-Action-Object System"});
            this.cbType.Location = new System.Drawing.Point(516, 242);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(326, 38);
            this.cbType.TabIndex = 20;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblType.Location = new System.Drawing.Point(512, 208);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 30);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbName.Location = new System.Drawing.Point(517, 330);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(326, 37);
            this.tbName.TabIndex = 18;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSystemName.Location = new System.Drawing.Point(513, 295);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(177, 30);
            this.lblSystemName.TabIndex = 17;
            this.lblSystemName.Text = "System Name";
            // 
            // panelPAO
            // 
            this.panelPAO.Controls.Add(this.lblNumRange);
            this.panelPAO.Controls.Add(this.cbNumRange);
            this.panelPAO.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panelPAO.Location = new System.Drawing.Point(517, 387);
            this.panelPAO.Name = "panelPAO";
            this.panelPAO.Size = new System.Drawing.Size(327, 78);
            this.panelPAO.TabIndex = 24;
            this.panelPAO.Visible = false;
            // 
            // lblNumRange
            // 
            this.lblNumRange.AutoSize = true;
            this.lblNumRange.Location = new System.Drawing.Point(-5, 0);
            this.lblNumRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumRange.Name = "lblNumRange";
            this.lblNumRange.Size = new System.Drawing.Size(194, 30);
            this.lblNumRange.TabIndex = 14;
            this.lblNumRange.Text = "Number Range";
            // 
            // cbNumRange
            // 
            this.cbNumRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumRange.FormattingEnabled = true;
            this.cbNumRange.Items.AddRange(new object[] {
            "0 - 10",
            "00 -100"});
            this.cbNumRange.Location = new System.Drawing.Point(1, 37);
            this.cbNumRange.Name = "cbNumRange";
            this.cbNumRange.Size = new System.Drawing.Size(321, 38);
            this.cbNumRange.TabIndex = 15;
            // 
            // panelPalace
            // 
            this.panelPalace.Controls.Add(this.lblRoomNum);
            this.panelPalace.Controls.Add(this.nudRoomNum);
            this.panelPalace.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panelPalace.Location = new System.Drawing.Point(514, 387);
            this.panelPalace.Name = "panelPalace";
            this.panelPalace.Size = new System.Drawing.Size(329, 75);
            this.panelPalace.TabIndex = 23;
            this.panelPalace.Visible = false;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Location = new System.Drawing.Point(-1, 0);
            this.lblRoomNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(228, 30);
            this.lblRoomNum.TabIndex = 12;
            this.lblRoomNum.Text = "Number of Rooms";
            // 
            // nudRoomNum
            // 
            this.nudRoomNum.Location = new System.Drawing.Point(3, 32);
            this.nudRoomNum.Name = "nudRoomNum";
            this.nudRoomNum.Size = new System.Drawing.Size(323, 37);
            this.nudRoomNum.TabIndex = 13;
            this.nudRoomNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateNewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.panelPalace);
            this.Controls.Add(this.panelPAO);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateNewUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.CreateNewUC_Load);
            this.panelPAO.ResumeLayout(false);
            this.panelPAO.PerformLayout();
            this.panelPalace.ResumeLayout(false);
            this.panelPalace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel panelPAO;
        private System.Windows.Forms.Label lblNumRange;
        private System.Windows.Forms.ComboBox cbNumRange;
        private System.Windows.Forms.Panel panelPalace;
        private System.Windows.Forms.NumericUpDown nudRoomNum;
        private System.Windows.Forms.Label lblRoomNum;
    }
}
