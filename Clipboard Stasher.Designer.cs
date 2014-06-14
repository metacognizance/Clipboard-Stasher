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
            this.m_history = new System.Windows.Forms.ListBox();
            this.m_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_history
            // 
            this.m_history.FormattingEnabled = true;
            this.m_history.Location = new System.Drawing.Point(12, 12);
            this.m_history.Name = "m_history";
            this.m_history.Size = new System.Drawing.Size(260, 212);
            this.m_history.TabIndex = 0;
            this.m_history.SelectedIndexChanged += new System.EventHandler(this.m_history_SelectedIndexChanged);
            // 
            // m_clear
            // 
            this.m_clear.Location = new System.Drawing.Point(12, 231);
            this.m_clear.Name = "m_clear";
            this.m_clear.Size = new System.Drawing.Size(260, 23);
            this.m_clear.TabIndex = 1;
            this.m_clear.Text = "Clear";
            this.m_clear.UseVisualStyleBackColor = true;
            this.m_clear.Click += new System.EventHandler(this.m_clear_Click);
            // 
            // ClipboardStasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.m_clear);
            this.Controls.Add(this.m_history);
            this.Name = "ClipboardStasher";
            this.Text = "Clipboard Stasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_history;
        private System.Windows.Forms.Button m_clear;


    }
}

