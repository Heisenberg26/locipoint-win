namespace LociPoint.UC
{
    partial class ScoresUC
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
            this.lblScores = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblScores.Location = new System.Drawing.Point(575, 37);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(189, 41);
            this.lblScores.TabIndex = 5;
            this.lblScores.Text = "My Scores";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 164);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1374, 697);
            this.panel.TabIndex = 6;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblScore.Location = new System.Drawing.Point(178, 120);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(113, 41);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblType.Location = new System.Drawing.Point(630, 120);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(98, 41);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDate.Location = new System.Drawing.Point(1089, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 41);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // ScoresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblScores);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ScoresUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.ScoresUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
    }
}
