using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wandows10MainSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wandowsのアンインストールToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("問題が発生しました。",
                "警告",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void バージョンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("セキュリティーソフトなんて入ってないわ",
                "あ?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("おい閉じるな",
                "は?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("最小化するな",
                  "ボケナス",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            this.WindowState = FormWindowState.Maximized;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ゴミはお前じゃwww",
                "explorer.exe",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Hide();
            this.button5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Show();
            this.button5.Show();
            this.button1.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Hide();
            this.button1.Show();
            this.button5.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
    }

    }



 
    