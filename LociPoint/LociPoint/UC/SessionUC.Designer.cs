namespace LociPoint.UC
{
    partial class SessionUC
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
            this.components = new System.ComponentModel.Container();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.btnScore = new System.Windows.Forms.Button();
            this.lblMemo = new System.Windows.Forms.Label();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSecs = new System.Windows.Forms.Label();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblHrs = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelSession = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.btnScore);
            this.panelTimer.Controls.Add(this.lblMemo);
            this.panelTimer.Controls.Add(this.lblColon1);
            this.panelTimer.Controls.Add(this.label4);
            this.panelTimer.Controls.Add(this.lblSecs);
            this.panelTimer.Controls.Add(this.lblMins);
            this.panelTimer.Controls.Add(this.lblHrs);
            this.panelTimer.Controls.Add(this.btnStop);
            this.panelTimer.Controls.Add(this.btnStart);
            this.panelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(1374, 259);
            this.panelTimer.TabIndex = 0;
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnScore.Location = new System.Drawing.Point(616, 163);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(166, 60);
            this.btnScore.TabIndex = 15;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Visible = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMemo.ForeColor = System.Drawing.Color.Red;
            this.lblMemo.Location = new System.Drawing.Point(540, 163);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(325, 30);
            this.lblMemo.TabIndex = 14;
            this.lblMemo.Text = "Press Start to begin session";
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblColon1.Location = new System.Drawing.Point(635, 23);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(37, 56);
            this.lblColon1.TabIndex = 13;
            this.lblColon1.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(735, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 56);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // lblSecs
            // 
            this.lblSecs.AutoSize = true;
            this.lblSecs.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSecs.Location = new System.Drawing.Point(762, 23);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(78, 56);
            this.lblSecs.TabIndex = 11;
            this.lblSecs.Text = "00";
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMins.Location = new System.Drawing.Point(665, 23);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(78, 56);
            this.lblMins.TabIndex = 10;
            this.lblMins.Text = "00";
            // 
            // lblHrs
            // 
            this.lblHrs.AutoSize = true;
            this.lblHrs.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHrs.Location = new System.Drawing.Point(566, 23);
            this.lblHrs.Name = "lblHrs";
            this.lblHrs.Size = new System.Drawing.Size(78, 56);
            this.lblHrs.TabIndex = 9;
            this.lblHrs.Text = "00";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStop.Location = new System.Drawing.Point(705, 92);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(160, 60);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStart.Location = new System.Drawing.Point(534, 92);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 60);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelSession
            // 
            this.panelSession.AutoScroll = true;
            this.panelSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSession.Location = new System.Drawing.Point(0, 259);
            this.panelSession.Name = "panelSession";
            this.panelSession.Size = new System.Drawing.Size(1374, 602);
            this.panelSession.TabIndex = 1;
            this.panelSession.Visible = false;
            this.panelSession.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSession_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // SessionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSession);
            this.Controls.Add(this.panelTimer);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SessionUC";
            this.Size = new System.Drawing.Size(1374, 861);
            this.Load += new System.EventHandler(this.SessionUC_Load);
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblHrs;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelSession;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Button btnScore;
    }
}
