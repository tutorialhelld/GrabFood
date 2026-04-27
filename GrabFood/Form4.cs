using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String userName;
            userName = textBox1.Text;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                button1.Enabled = false;
                MessageBox.Show("enter a username.");
                if (textBox1.Text == "")
                {
                    button1.Enabled = true;
                }
            }
            else
            {
                button1.Enabled = true;
                panel1.Visible = true;
                label4.Visible = true;
                textBox2.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                label6.Visible = true;
                textBox4.Visible = true;
                label7.Visible = true;
                textBox5.Visible = true;
                button2.Visible = true;

            }

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int phoneNumber;
            if (int.TryParse(textBox4.Text, out phoneNumber))
            {
   
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.");
                textBox4.Clear();
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            String address;
            address = textBox5.Text;
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                userInfo.AddUser(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Username: "+textBox1.Text+"\nPassword matched: " + textBox3.Text + "\nPhone number: " + textBox4.Text + "\nAddress: " + textBox5.Text);

            }
            else
            {
                MessageBox.Show("Password does not match.");
                textBox3.Clear();
            }
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
