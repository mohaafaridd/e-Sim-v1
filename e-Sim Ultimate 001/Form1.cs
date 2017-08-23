using e_Sim_Ultimate_001.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Sim_Ultimate_001
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Equ_1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Equ;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.MoneyMark_1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.MoneyMark;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
           pictureBox3.Image = Resources.Merc_1;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Merc;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.Company_1;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.Company;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 firstmen = new Form1();
            Secondary_menu secmen = new Secondary_menu();
            this.Hide();
            secmen.tabControl1.SelectedIndex = 0;

            secmen.ShowDialog();
            
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 firstmen = new Form1();
            Secondary_menu secmen = new Secondary_menu();
            this.Hide();
            secmen.tabControl1.SelectedIndex = 1;


            secmen.ShowDialog();
           
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 firstmen = new Form1();
            Secondary_menu secmen = new Secondary_menu();
            this.Hide();
            secmen.tabControl1.SelectedIndex = 2;

            secmen.ShowDialog();
            
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 firstmen = new Form1();
            Secondary_menu secmen = new Secondary_menu();
            this.Hide();
            secmen.tabControl1.SelectedIndex = 3;


            secmen.ShowDialog();
            
            this.Close();
        }
    }


}
