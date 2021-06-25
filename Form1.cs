
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarJar_Launcher
{
    public partial class Form1 : Form
    {

        static bool alreadyAttemptedInject = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            NotifyIcon notifyIcon22 = notifyIcon2;
            notifyIcon22.Text = "Failed to inject";
            notifyIcon22.BalloonTipText = "Failed to inject, under maintenance.";
            notifyIcon22.BalloonTipTitle = "JarJar Launcher";
            notifyIcon22.ShowBalloonTip(1000);
        }

        private void notifyIcon2_BalloonTipClicked(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            NotifyIcon notifyIcon22 = notifyIcon2;
            notifyIcon22.Text = "Failed to inject";
            notifyIcon22.BalloonTipText = "Failed to inject, under maintenance try using a different injector.";
            notifyIcon22.BalloonTipTitle = "JarJar Launcher";
            notifyIcon22.ShowBalloonTip(1000);
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            string title = "TabPage " + (guna2TabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            guna2TabControl1.TabPages.Add(myTabPage);
        }
    }
}
