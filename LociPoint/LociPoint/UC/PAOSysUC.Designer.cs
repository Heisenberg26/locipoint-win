namespace LociPoint.UC
{
    partial class PAOSysUC
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
            this.lblAction = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblPAO = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAction.Location = new System.Drawing.Point(457, 76);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(127, 41);
            this.lblAction.TabIndex = 54;
            this.lblAction.Text = "Action";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPerson.Location = new System.Drawing.Point(122, 76);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(129, 41);
            this.lblPerson.TabIndex = 53;
            this.lblPerson.Text = "Person";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEdit.Location = new System.Drawing.Point(1153, 76);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(77, 41);
            this.lblEdit.TabIndex = 52;
            this.lblEdit.Text = "Edit";
            // 
            // lblPAO
            // 
            this.lblPAO.AutoSize = true;
            this.lblPAO.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPAO.Location = new System.Drawing.Point(566, 17);
            this.lblPAO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPAO.Name = "lblPAO";
            this.lblPAO.Size = new System.Drawing.Size(221, 42);
            this.lblPAO.TabIndex = 51;
            this.lblPAO.Text = "PAO System";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblObject.Location = new System.Drawing.Point(808, 76);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(133, 41);
            this.lblObject.TabIndex = 55;
            this.lblObject.Text = "Object";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 131);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1374, 730);
            this.panel.TabIndex = 56;
            // 
            // PAOSysUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblPAO);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PAOSysUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.PAOSysUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblPAO;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Panel panel;
    }
}
