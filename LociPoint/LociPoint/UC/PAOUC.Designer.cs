namespace LociPoint.UC
{
    partial class PAOUC
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
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblPAO = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEdit.Location = new System.Drawing.Point(1078, 107);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(132, 41);
            this.lblEdit.TabIndex = 54;
            this.lblEdit.Text = "Modify";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRange.Location = new System.Drawing.Point(635, 107);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(127, 41);
            this.lblRange.TabIndex = 53;
            this.lblRange.Text = "Range";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSystemName.Location = new System.Drawing.Point(136, 107);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(250, 41);
            this.lblSystemName.TabIndex = 52;
            this.lblSystemName.Text = "System Name";
            // 
            // lblPAO
            // 
            this.lblPAO.AutoSize = true;
            this.lblPAO.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPAO.Location = new System.Drawing.Point(590, 42);
            this.lblPAO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPAO.Name = "lblPAO";
            this.lblPAO.Size = new System.Drawing.Size(236, 42);
            this.lblPAO.TabIndex = 51;
            this.lblPAO.Text = "PAO Systems";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 161);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1374, 700);
            this.panel.TabIndex = 55;
            // 
            // PAOUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.lblPAO);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PAOUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.PAOUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblPAO;
        private System.Windows.Forms.Panel panel;
    }
}
