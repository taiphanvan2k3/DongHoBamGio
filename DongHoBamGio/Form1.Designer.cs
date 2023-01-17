namespace DongHoBamGio
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelShowTime = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.labelTick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelShowTime
            // 
            this.labelShowTime.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelShowTime.Location = new System.Drawing.Point(141, 58);
            this.labelShowTime.Name = "labelShowTime";
            this.labelShowTime.Size = new System.Drawing.Size(518, 156);
            this.labelShowTime.TabIndex = 0;
            this.labelShowTime.Text = "00 : 00 : 00";
            this.labelShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Gray;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(428, 256);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(159, 50);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStartPause
            // 
            this.btnStartPause.BackColor = System.Drawing.Color.Green;
            this.btnStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPause.Location = new System.Drawing.Point(205, 256);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(159, 50);
            this.btnStartPause.TabIndex = 1;
            this.btnStartPause.Text = "Start";
            this.btnStartPause.UseVisualStyleBackColor = false;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // labelTick
            // 
            this.labelTick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTick.Location = new System.Drawing.Point(470, 126);
            this.labelTick.Name = "labelTick";
            this.labelTick.Size = new System.Drawing.Size(64, 23);
            this.labelTick.TabIndex = 3;
            this.labelTick.Text = "00";
            this.labelTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTick);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.labelShowTime);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelShowTime;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Label labelTick;
    }
}

