using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gif
{
    public partial class Glitter : Form
    {
        Point m_Start;

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        int m_InitialStyle;

        public Glitter(Image CurrentImage ,Point start)
        {
            InitializeComponent();
            this.TopMost = true;

            m_InitialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, m_InitialStyle | 0x80000 | 0x20);

            m_Start = start;

            this.Width = pictureBox_Main.Width = CurrentImage.Width;
            this.Height = pictureBox_Main.Height = CurrentImage.Height;

            BackColor = Color.Magenta;
            TransparencyKey = Color.Magenta;

            pictureBox_Main.Image = CurrentImage;
        }

        public void ChangeImage(Image CurrentImage)
        {
            this.Width = pictureBox_Main.Width = CurrentImage.Width;
            this.Height = pictureBox_Main.Height = CurrentImage.Height;
            pictureBox_Main.Image = CurrentImage;
        }
    }
}
