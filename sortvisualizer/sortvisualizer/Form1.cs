using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortvisualizer
{
    public partial class Form1 : Form
    {
        int[] Array;
        Graphics g,h;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            h = panel2.CreateGraphics();
            int numEntries = panel1.Width;
            int maxVal = panel1.Height;
            Array = new int[numEntries];
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numEntries, maxVal);
            h.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numEntries, maxVal);
            Random rand = new Random();
            for (int i = 0; i < numEntries; i++)
            {
                Array[i] = rand.Next(0, maxVal);
            }
            for (int i = 0; i < numEntries; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maxVal = Array[i], 1, maxVal);
                h.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maxVal = Array[i], 1, maxVal);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Interface1 he = new SortEnginequick();
            Interface1 se = new SortEngineMerge();
            he.DoWork(Array, h, panel2.Height);
            se.DoWork(Array, g, panel1.Height);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
