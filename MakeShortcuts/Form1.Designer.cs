namespace MakeShortcuts
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblDest = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(35, 55);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(63, 13);
            this.lblDest.TabIndex = 1;
            this.lblDest.Text = "Destination:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(104, 52);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(422, 20);
            this.txtFolder.TabIndex = 2;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(167, 26);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(247, 13);
            this.lblIntro.TabIndex = 4;
            this.lblIntro.Text = "Makes 999 Notepad shortcuts in destination folder.";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(563, 18);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 169);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Notepad Shortcuts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker bw;
    }
}

