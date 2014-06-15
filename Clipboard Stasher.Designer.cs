namespace Clipboard_Stasher
{
    partial class ClipboardStasher
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
            this.m_history = new System.Windows.Forms.ListBox();
            this.m_clear = new System.Windows.Forms.Button();
            this.m_trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // m_history
            // 
            this.m_history.FormattingEnabled = true;
            this.m_history.Location = new System.Drawing.Point(12, 12);
            this.m_history.Name = "m_history";
            this.m_history.Size = new System.Drawing.Size(227, 368);
            this.m_history.TabIndex = 0;
            this.m_history.SelectedIndexChanged += new System.EventHandler(this.m_history_SelectedIndexChanged);
            // 
            // m_clear
            // 
            this.m_clear.Location = new System.Drawing.Point(12, 392);
            this.m_clear.Name = "m_clear";
            this.m_clear.Size = new System.Drawing.Size(227, 23);
            this.m_clear.TabIndex = 1;
            this.m_clear.Text = "Clear";
            this.m_clear.UseVisualStyleBackColor = true;
            this.m_clear.Click += new System.EventHandler(this.m_clear_Click);
            // 
            // m_trayIcon
            // 
            this.m_trayIcon.Text = "Clipboard Stasher";
            this.m_trayIcon.Visible = true;
            this.m_trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.m_trayIcon_MouseDoubleClick);
            // 
            // ClipboardStasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 427);
            this.Controls.Add(this.m_clear);
            this.Controls.Add(this.m_history);
            this.Name = "ClipboardStasher";
            this.Text = "Clipboard Stasher";
            this.Load += new System.EventHandler(this.ClipboardStasher_Load);
            this.Resize += new System.EventHandler(this.ClipboardStasher_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_history;
        private System.Windows.Forms.Button m_clear;
        private System.Windows.Forms.NotifyIcon m_trayIcon;


    }
}

