namespace smartAssistance
{
    partial class google
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
            this.components = new System.ComponentModel.Container();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.TmrSpeaking = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCommands
            // 
            this.lstCommands.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstCommands.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.ItemHeight = 16;
            this.lstCommands.Location = new System.Drawing.Point(0, 179);
            this.lstCommands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(652, 436);
            this.lstCommands.TabIndex = 0;
            this.lstCommands.Visible = false;
            this.lstCommands.SelectedIndexChanged += new System.EventHandler(this.LstCommands_SelectedIndexChanged);
            // 
            // TmrSpeaking
            // 
            this.TmrSpeaking.Enabled = true;
            this.TmrSpeaking.Interval = 1000;
            this.TmrSpeaking.Tick += new System.EventHandler(this.TmrSpeaking_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(180, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // audio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(652, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCommands);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "audio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.Timer TmrSpeaking;
        private System.Windows.Forms.Label label1;
    }
}

