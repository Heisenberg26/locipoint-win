namespace LociPoint.UC
{
    partial class PalacesUC
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
            this.lblPalaces = new System.Windows.Forms.Label();
            this.panelPalaces = new System.Windows.Forms.Panel();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblPalaceName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPalaces
            // 
            this.lblPalaces.AutoSize = true;
            this.lblPalaces.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPalaces.Location = new System.Drawing.Point(590, 42);
            this.lblPalaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalaces.Name = "lblPalaces";
            this.lblPalaces.Size = new System.Drawing.Size(212, 42);
            this.lblPalaces.TabIndex = 46;
            this.lblPalaces.Text = "My Palaces";
            // 
            // panelPalaces
            // 
            this.panelPalaces.AutoScroll = true;
            this.panelPalaces.Location = new System.Drawing.Point(0, 160);
            this.panelPalaces.Name = "panelPalaces";
            this.panelPalaces.Size = new System.Drawing.Size(1374, 701);
            this.panelPalaces.TabIndex = 47;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEdit.Location = new System.Drawing.Point(1057, 107);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(132, 41);
            this.lblEdit.TabIndex = 50;
            this.lblEdit.Text = "Modify";
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalRooms.Location = new System.Drawing.Point(593, 107);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(209, 41);
            this.lblTotalRooms.TabIndex = 49;
            this.lblTotalRooms.Text = "Total rooms";
            // 
            // lblPalaceName
            // 
            this.lblPalaceName.AutoSize = true;
            this.lblPalaceName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPalaceName.Location = new System.Drawing.Point(136, 107);
            this.lblPalaceName.Name = "lblPalaceName";
            this.lblPalaceName.Size = new System.Drawing.Size(250, 41);
            this.lblPalaceName.TabIndex = 48;
            this.lblPalaceName.Text = "Palace Name";
            // 
            // PalacesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblTotalRooms);
            this.Controls.Add(this.lblPalaceName);
            this.Controls.Add(this.panelPalaces);
            this.Controls.Add(this.lblPalaces);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PalacesUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.PalacesUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalaces;
        private System.Windows.Forms.Panel panelPalaces;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblPalaceName;
    }
}
