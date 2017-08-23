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
    public partial class Secondary_menu : Form
    {
        public Secondary_menu()
        {
            InitializeComponent();

            timer1.Start();

            comboBox1.Items.Add("Q1");
            comboBox1.Items.Add("Q2");
            comboBox1.Items.Add("Q3");
            comboBox1.Items.Add("Q4");
            comboBox1.Items.Add("Q5");

            if (comboBox2.Text == "")
                circularProgressBar1.ProgressColor = Color.White;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 isk = new Form1();
            this.Hide();
            isk.ShowDialog();

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(textBox1.Text);
            double totaleq = 3; // How many equipment the user will need that chosen from "FROM" combobox
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Enter the missing");
                textBox1.Focus();
            }

            else
            {
                switch (comboBox1.Text)
                {
                    case "Q1": //- Q1
                        switch (comboBox2.Text)
                        {
                            case "Q2":
                                {
                                    price = (price * 3) + (0.3); //- Q1 == > Q2

                                    textBox3.Text = price.ToString();

                                    textBox2.Text = totaleq.ToString();

                                    totaleq = 3;

                                    price = 0;

                                    break;
                                }
                            case "Q3":
                                {
                                    price = (price * 3) + (0.3); //-  3 * Q1 == >  1 * Q2

                                    price = (price * 3) + (1);  //- 3 * Q2 == > 1 * Q3

                                    totaleq = 9;

                                    textBox3.Text = price.ToString();

                                    textBox2.Text = totaleq.ToString();

                                    totaleq = 3;

                                    price = 0;

                                    break;
                                }
                            case "Q4":
                                {
                                    price = (price * 3) + (0.3); //-  3 * Q1 == >  1 * Q2

                                    price = (price * 3) + (1); //- 3 * Q2 == > 1 * Q3

                                    price = (price * 3) + (3); //- 3 * Q3 == > 3 * Q4

                                    totaleq = 27;

                                    textBox3.Text = price.ToString();

                                    textBox2.Text = totaleq.ToString();

                                    totaleq = 3;

                                    price = 0;

                                    break;
                                }

                            case "Q5":
                                {
                                    price = (price * 3) + (0.3);

                                    price = (price * 3) + (1);

                                    price = (price * 3) + (3);

                                    price = (price * 3) + (9);

                                    totaleq = 81;

                                    textBox3.Text = price.ToString();

                                    textBox2.Text = totaleq.ToString();

                                    totaleq = 3;

                                    price = 0;

                                    break;
                                }

                            case "Q6":
                                {
                                    price = (price * 3) + (0.3);

                                    price = (price * 3) + (1);

                                    price = (price * 3) + (3);

                                    price = (price * 3) + (9);

                                    price = (price * 3) + (27);

                                    totaleq = 243;

                                    textBox3.Text = price.ToString();

                                    textBox2.Text = totaleq.ToString();

                                    totaleq = 3;

                                    price = 0;

                                    break;
                                }
                        }
                        break;

                    case "Q2":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Q3":
                                    {
                                        price = (price * 3) + (1);

                                        totaleq = 3;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;

                                        break;
                                    }
                                case "Q4":
                                    {
                                        price = (price * 3) + (1);

                                        price = (price * 3) + (3);

                                        totaleq = 9;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;

                                        break;
                                    }
                                case "Q5":
                                    {
                                        price = (price * 3) + (1);

                                        price = (price * 3) + (3);

                                        price = (price * 3) + (9);

                                        totaleq = 27;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;

                                        break;
                                    }
                                case "Q6":
                                    {
                                        price = (price * 3) + (1);

                                        price = (price * 3) + (3);

                                        price = (price * 3) + (9);

                                        price = (price * 3) + (27);

                                        totaleq = 81;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;
                                        break;
                                    }
                            }
                        }
                        break;

                    case "Q3":

                        {
                            switch (comboBox2.Text)
                            {
                                case "Q4":
                                    {
                                        price = (price * 3) + (3);

                                        totaleq = 3;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        break;
                                    }
                                case "Q5":
                                    {
                                        price = (price * 3) + (3);

                                        price = (price * 3) + (9);

                                        totaleq = 9;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;

                                        break;
                                    }
                                case "Q6":
                                    {

                                        price = (price * 3) + (3);

                                        price = (price * 3) + (9);

                                        price = (price * 3) + (27);

                                        totaleq = 27;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;

                                        break;
                                    }
                            }
                        }

                        break;

                    case "Q4":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Q5":
                                    {
                                        price = (price * 3) + (9);

                                        totaleq = 3;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;

                                        break;
                                    }
                                case "Q6":
                                    {
                                        price = (price * 3) + (9);

                                        price = (price * 3) + (27);

                                        totaleq = 9;

                                        textBox3.Text = price.ToString();

                                        textBox2.Text = totaleq.ToString();

                                        totaleq = 3;

                                        price = 0;

                                        break;
                                    }
                            }
                            break;
                        }

                    case "Q5":
                        {
                            if (comboBox2.Text == "Q6")
                            {

                                price = (price * 3) + (27);

                                totaleq = 3;

                                textBox3.Text = price.ToString();

                                textBox2.Text = totaleq.ToString();

                                totaleq = 3;

                                price = 0;

                            }
                            break;
                        }

                }
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
                circularProgressBar1.ProgressColor = Color.White;

            if (comboBox1.Text == "Q1")
            {
                comboBox2.Items.Clear();
                f1.BackColor = System.Drawing.ColorTranslator.FromHtml("#e74c3c");
                f2.BackColor = System.Drawing.ColorTranslator.FromHtml("#e74c3c");
                f3.BackColor = System.Drawing.ColorTranslator.FromHtml("#e74c3c");
                circularProgressBar1.OuterColor = System.Drawing.ColorTranslator.FromHtml("#e74c3c");

                comboBox2.Items.Add("Q2");
                comboBox2.Items.Add("Q3");
                comboBox2.Items.Add("Q4");
                comboBox2.Items.Add("Q5");
                comboBox2.Items.Add("Q6");

            }

            else if (comboBox1.Text == "Q2")
            {
                comboBox2.Items.Clear();
                f1.BackColor = System.Drawing.ColorTranslator.FromHtml("#e67e22");
                f2.BackColor = System.Drawing.ColorTranslator.FromHtml("#e67e22");
                f3.BackColor = System.Drawing.ColorTranslator.FromHtml("#e67e22");
                circularProgressBar1.OuterColor = System.Drawing.ColorTranslator.FromHtml("#e67e22");

                comboBox2.Items.Add("Q3");
                comboBox2.Items.Add("Q4");
                comboBox2.Items.Add("Q5");
                comboBox2.Items.Add("Q6");

            }

            else if (comboBox1.Text == "Q3")
            {
                comboBox2.Items.Clear();
                f1.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1c40f");
                f2.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1c40f");
                f3.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1c40f");
                circularProgressBar1.OuterColor = System.Drawing.ColorTranslator.FromHtml("#f1c40f");

                comboBox2.Items.Add("Q4");
                comboBox2.Items.Add("Q5");
                comboBox2.Items.Add("Q6");

            }

            else if (comboBox1.Text == "Q4")
            {
                comboBox2.Items.Clear();
                f1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2ecc71");
                f2.BackColor = System.Drawing.ColorTranslator.FromHtml("#2ecc71");
                f3.BackColor = System.Drawing.ColorTranslator.FromHtml("#2ecc71");
                circularProgressBar1.OuterColor = System.Drawing.ColorTranslator.FromHtml("#2ecc71");

                comboBox2.Items.Add("Q5");
                comboBox2.Items.Add("Q6");

            }

            else if (comboBox1.Text == "Q5")
            {
                comboBox2.Items.Clear();
                f1.BackColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");
                f2.BackColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");
                f3.BackColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");
                circularProgressBar1.OuterColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");

                comboBox2.Items.Add("Q6");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Q2")
            {
                s1.BackColor = System.Drawing.ColorTranslator.FromHtml("#e67e22");
                s2.BackColor = System.Drawing.ColorTranslator.FromHtml("#e67e22");
                circularProgressBar1.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#e67e22");
            }

            else if (comboBox2.Text == "Q3")
            {
                s1.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1c40f");
                s2.BackColor = System.Drawing.ColorTranslator.FromHtml("#f1c40f");
                circularProgressBar1.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#f1c40f");
            }

            else if (comboBox2.Text == "Q4")
            {
                s1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2ecc71");
                s2.BackColor = System.Drawing.ColorTranslator.FromHtml("#2ecc71");
                circularProgressBar1.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#2ecc71");
            }

            else if (comboBox2.Text == "Q5")
            {
                s1.BackColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");
                s2.BackColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");
                circularProgressBar1.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");
            }

            else if (comboBox2.Text == "Q6")
            {
                s1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3498db");
                s2.BackColor = System.Drawing.ColorTranslator.FromHtml("#3498db");
                circularProgressBar1.ProgressColor = System.Drawing.ColorTranslator.FromHtml("#3498db");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OldGold2.Text = OldGold.Text;
            P12.Text = P1.Text;
            P22.Text = P2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OldGold.Text == "" || P1.Text == "" || P2.Text == "" || NewGold.Text == "")
            {
                MessageBox.Show("Enter the missing");
                OldGold.Focus();

            }
            else
            {
                float OldGold1 = float.Parse(OldGold.Text);
                float Price1 = float.Parse(P1.Text);
                float Price2 = float.Parse(P2.Text);

                int i = 0;

                float NewGold1 = float.Parse(NewGold.Text);

                while (true)
                {
                    if (OldGold1 < NewGold1)
                        OldGold1 *= Price1 * Price2;
                    else
                        break;
                    i++;
                }

                redobox.Text = i.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OldGold.Text = OldGold2.Text;
            P1.Text = P12.Text;
            P2.Text = P22.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OldGold2.Text == "" || P12.Text == "" || P22.Text == "" || redobox2.Text == "")
            {
                MessageBox.Show("Enter the missing");
                OldGold2.Focus();

            }
            else
            {
                float OldGold = float.Parse(OldGold2.Text);
                float Fprice = float.Parse(P12.Text);
                float Sprice = float.Parse(P22.Text);

                int redo = int.Parse(redobox2.Text);

                int i = 0;

                while (i != redo)
                {
                    OldGold *= Fprice * Sprice;

                    i++;
                }

                Final2.Text = OldGold.ToString();

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox5.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Enter the missing");
                textBox6.Focus();

            }
            else
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                float x = float.Parse(textBox6.Text); // Quantity
                float y = float.Parse(textBox5.Text); // Price
                float a = float.Parse(textBox4.Text); // Changing rate


                float z = 0;
                while (z < 5)
                {

                    listBox1.Items.Add(y);
                    listBox1.Items.Add("");
                    listBox2.Items.Add(x * y);
                    listBox2.Items.Add("");

                    y = y - (y * a) / 100;

                    z++;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            float YouWillGet;
            float Mmcost = float.Parse(Mcost.Text);
            float Dddone = float.Parse(Ddone.Text);
            float bh = float.Parse(textBox15.Text);
            float medkits = float.Parse(textBox16.Text);

            YouWillGet = Mmcost * Dddone;
            YouWillGet += (bh * 5);

            // Food price Calculate
            float Food_price;
            float FLB = float.Parse(textBox7.Text); // food limit before
            float FLA = float.Parse(textBox8.Text); // food limit after
            float FLP = float.Parse(textBox21.Text); // food price

            Food_price = ((FLB - FLA) + (medkits * 10)) * FLP;

            // Gifts price Caluclate
            float Gifts_price;
            float GLB = float.Parse(textBox10.Text); // food limit before
            float GLA = float.Parse(textBox9.Text); // food limit after
            float GLP = float.Parse(textBox20.Text); // food price

            Gifts_price = ((GLB - GLA) + (medkits * 10)) * GLP;

            // Q1 Weapons price Calculate 
            float Q1_price;
            float Q1LB = float.Parse(textBox12.Text); // food limit before
            float Q1LA = float.Parse(textBox11.Text); // food limit after
            float Q1LP = float.Parse(textBox19.Text); // food price

            Q1_price = (Q1LB - Q1LA) * Q1LP;

            // Q5 Weapons price Calculate 
            float Q5_price;
            float Q5LB = float.Parse(textBox14.Text); // food limit before
            float Q5LA = float.Parse(textBox13.Text); // food limit after
            float Q5LP = float.Parse(textBox18.Text); // food price

            Q5_price = (Q5LB - Q5LA) * Q5LP;

            // Tickets price Calculate 

            float total, Net;
            total = Food_price + Gifts_price + Q1_price + Q5_price;
            Net = YouWillGet - total;

            textBox22.Text = YouWillGet.ToString();

            textBox23.Text = total.ToString();

            textBox24.Text = Net.ToString();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Secondary_menu_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Mcost.Text = "0";
            Ddone.Text = "0";

            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox21.Text = "0";

            textBox10.Text = "0";
            textBox9.Text = "0";
            textBox20.Text = "0";

            textBox12.Text = "0";
            textBox11.Text = "0";
            textBox19.Text = "0";

            textBox14.Text = "0";
            textBox13.Text = "0";
            textBox18.Text = "0";

            textBox24.Text = "0";
            textBox23.Text = "0";
            textBox22.Text = "0";


        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(46, 204, 113);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(46, 204, 113);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(46, 204, 113);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(46, 204, 113);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double first_percent, second_percent, final;
            double initial = double.Parse(textBox26.Text);
            double sold = double.Parse(textBox25.Text);
            int quantity = int.Parse(textBox27.Text);

            first_percent = initial * 0.02;
            second_percent = sold * 0.01;

            final = sold - (first_percent + second_percent);
            final *= quantity;
            textBox17.Text = final.ToString();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string url = "";

            string business = "moha.khamis@outlook.com";  // your paypal email
            string description = "Donation";            // '%20' represents a space. remember HTML!
            string country = "EG";                  // AU, US, etc.
            string currency = "EUR";                 // AUD, USD, etc.

            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";

            System.Diagnostics.Process.Start(url);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            OldGold.Text = "0";
            P1.Text = "0";
            P2.Text = "0";
            NewGold.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OldGold2.Text = "0";
            P12.Text = "0";
            P22.Text = "0";
            redobox2.Text = "0";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://suna.e-sim.org/profile.html?id=345790");
        }

        private void label57_MouseEnter(object sender, EventArgs e)
        {
            label57.ForeColor = Color.FromArgb(46, 204, 113);
        }

        private void label57_MouseLeave(object sender, EventArgs e)
        {
            label57.ForeColor = Color.White;
        }

        private void label57_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox31.Text); // main gold
            double y = double.Parse(textBox30.Text); // interst
            int z = int.Parse(textBox28.Text); // how many days

            double k;

            y /= 100;
            y *= z;
            y *= x;
            x += y;
            k = x;

            textBox29.Text = k.ToString();
        }
    }
}
