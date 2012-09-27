using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Gif
{
    public struct Vector2
    {
        public float X, Y;
    }

    public partial class Manager : Form
    {
        Point m_Start;
        Thread m_MouseThread;

        int Timeout;
        int m_NumberOfFollowers;
        Image m_CurrentImage;

        Vector2 Direction;
        Vector2 Position;
        float Speed = 2;

        public List<Glitter> m_Windows = new List<Glitter>();

        public Manager(Point Start)
        {
            m_Start = Start;
            Timeout = 5;

            InitializeComponent();

            m_MouseThread = new Thread(new ThreadStart(WatchMouse));
            m_MouseThread.IsBackground = true;
            m_MouseThread.Start();

            m_NumberOfFollowers = 1;

            m_CurrentImage = Properties.Resources.Current;   

            for (int i = 0; i < m_NumberOfFollowers; i++)
            {
                m_Windows.Add(new Glitter(m_CurrentImage, new Point(Cursor.Position.X, Cursor.Position.Y)));
                m_Windows[m_Windows.Count - 1].Show();
            }                   
        }

        void WatchMouse()
        {
            while (true)
            {
                if(m_Windows.Count > 0)
                UpdateMouse();

                Thread.Sleep(Timeout);
            }
        }

        delegate void SetTextCallback();

        public void UpdateMouse()
        {
            if (this.m_Windows[0].InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateMouse);
                this.m_Windows[0].Invoke(d, new object[] { });
            }
            else
            {
                //Position.X = (float)m_Windows[0].Location.X;
                //Position.Y = (float)m_Windows[0].Location.Y;

                //Direction.X = (Cursor.Position.X + 10) - Position.X;
                //Direction.Y = (Cursor.Position.Y + 10) - Position.Y;

                //float length = (float)Math.Sqrt(Math.Pow(Direction.X, 2) + Math.Pow(Direction.Y, 2));

                //if (length != 0)
                //{
                //    Direction.X = Direction.X / length;
                //    Direction.Y = Direction.Y / length;
                //}

                //Position.X += Direction.X * Speed;
                //Position.Y += Direction.Y * Speed;

                //m_Windows[0].Location = new Point((int)Position.X, (int)Position.Y);

                m_Windows[0].Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 10);
                m_Windows.Add(m_Windows[0]);
                m_Windows.RemoveAt(0);
            }

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Location = m_Start;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "gif files (*.gif)|*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_CurrentImage = new Bitmap(dlg.FileName);
                for (int i = 0; i < m_Windows.Count; i++)
                {
                    m_Windows[i].ChangeImage(m_CurrentImage);
                }
            }
            dlg.Dispose();
        }

        private void numericUpDown_NumberOfFollowers_ValueChanged(object sender, EventArgs e)
        {
            if (m_NumberOfFollowers < (int)numericUpDown_NumberOfFollowers.Value)
            {
                m_Windows.Add(new Glitter(m_CurrentImage, new Point(Cursor.Position.X, Cursor.Position.Y)));
                m_Windows[m_Windows.Count - 1].Show();
            }
            else
            {
               m_Windows[m_Windows.Count-1].Close();
               m_Windows.RemoveAt(m_Windows.Count - 1);
            }

            m_NumberOfFollowers = (int)numericUpDown_NumberOfFollowers.Value;

        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }
    }
}
