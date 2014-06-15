using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Clipboard_Stasher
{
    public partial class ClipboardStasher : Form
    {
        private NotificationForm _form;

        public ClipboardStasher()
        {
            InitializeComponent();
            m_trayIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon("32365.ico");
            Icon = m_trayIcon.Icon;
            _form = new NotificationForm(m_history.Items);
        }

        private void ClipboardStasher_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ClipboardStasher_Resize(object sender, EventArgs e)
        {
            m_trayIcon.BalloonTipTitle = "Clipboard Stasher";
            m_trayIcon.BalloonTipText = "Double-click the icon in order to restore the window.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                m_trayIcon.Visible = true;
                m_trayIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                m_trayIcon.Visible = false;
            }
        }

        private class NotificationForm : Form
        {
            public NotificationForm(ListBox.ObjectCollection p_history)
            {
                m_history = p_history;
                NativeMethods.SetParent(Handle, NativeMethods.HWND_MESSAGE);
                NativeMethods.AddClipboardFormatListener(Handle);
            }

            static ListBox.ObjectCollection m_history;

            public static event EventHandler ClipboardUpdate;

            private static void OnClipboardUpdate(EventArgs e)
            {
                var handler = ClipboardUpdate;
                if (handler != null)
                {
                    handler(null, e);
                }
                if (Clipboard.ContainsText(System.Windows.Forms.TextDataFormat.Text))
                {
                    if (m_history.Count == 0)
                    {
                        m_history.Add((String)System.Windows.Forms.Clipboard.GetData(System.Windows.Forms.DataFormats.StringFormat));
                    }
                    else
                    {
                        if (m_history[m_history.Count - 1].ToString() != (String)System.Windows.Forms.Clipboard.GetData(System.Windows.Forms.DataFormats.StringFormat))
                        {
                            m_history.Add((String)System.Windows.Forms.Clipboard.GetData(System.Windows.Forms.DataFormats.StringFormat));
                        }
                    }
                }
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == NativeMethods.WM_CLIPBOARDUPDATE)
                {
                    OnClipboardUpdate(null);
                }
                base.WndProc(ref m);
            }
        }

        private void m_history_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetData(System.Windows.Forms.DataFormats.StringFormat, m_history.SelectedItem.ToString());
        }

        private void m_clear_Click(object sender, EventArgs e)
        {
            m_history.Items.Clear();
        }

        private void m_trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }

    internal static class NativeMethods
    {
        public const int WM_CLIPBOARDUPDATE = 0x031D;
        public static IntPtr HWND_MESSAGE = new IntPtr(-3);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
    }
}
