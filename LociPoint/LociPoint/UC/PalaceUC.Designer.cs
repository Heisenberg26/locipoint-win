namespace LociPoint.UC
{
    partial class PalaceUC
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
            this.lblPalace = new System.Windows.Forms.Label();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblRoomDes = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPalace
            // 
            this.lblPalace.AutoSize = true;
            this.lblPalace.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPalace.Location = new System.Drawing.Point(562, 42);
            this.lblPalace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalace.Name = "lblPalace";
            this.lblPalace.Size = new System.Drawing.Size(212, 42);
            this.lblPalace.TabIndex = 46;
            this.lblPalace.Text = "My Palaces";
            // 
            // panelRooms
            // 
            this.panelRooms.AutoScroll = true;
            this.panelRooms.Location = new System.Drawing.Point(0, 160);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(1374, 701);
            this.panelRooms.TabIndex = 47;
            this.panelRooms.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPalaces_Paint);
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
            // lblRoomDes
            // 
            this.lblRoomDes.AutoSize = true;
            this.lblRoomDes.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRoomDes.Location = new System.Drawing.Point(547, 107);
            this.lblRoomDes.Name = "lblRoomDes";
            this.lblRoomDes.Size = new System.Drawing.Size(312, 41);
            this.lblRoomDes.TabIndex = 49;
            this.lblRoomDes.Text = "Room Description";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRoomName.Location = new System.Drawing.Point(136, 107);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(229, 41);
            this.lblRoomName.TabIndex = 48;
            this.lblRoomName.Text = "Room Name";
            // 
            // PalaceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblRoomDes);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.lblPalace);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PalaceUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.PalaceUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalace;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblRoomDes;
        private System.Windows.Forms.Label lblRoomName;
    }
}
