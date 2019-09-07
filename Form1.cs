using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Diagnoses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(startForm));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
            textBox2.PasswordChar = '*';
            button1.Enabled = false;  
        }
        public void startForm()
        {
            Application.Run(new proBar());
        }

        const string name = "Admin",name2="vracuzi";
        const string pass = "250299",pass2="0828";
        string name1= "C:/Windows/progkay/pass.txt";
        string a;
        

     
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a') && (e.KeyChar <= 'z'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        textBox2.Focus();
                }
                return;
            }
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a') && (e.KeyChar <= 'z'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox2))
                        button1.Focus();

                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Diagnoses = new Form2();
               if((textBox1.Text == name) && (textBox2.Text == pass))
              {
                Hide();
                Diagnoses.ShowDialog();
                Close();
              }
             a = File.ReadAllText(name1);

              if ((textBox1.Text == name2) && (textBox2.Text == pass2)&&(a=="111"))
                      {
                          Hide();
                          Diagnoses.ShowDialog();
                          Close();
                      }
                      else
                      {
                          label3.Text = "Ошибка, не правильный логин или пороль.";
                          textBox1.Text = "";
                          textBox2.Text = "";
                          textBox1.Focus();

                      }
           }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0)
            {
                label3.Text = "";
            }
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                button1.Enabled=false;
            else
                button1.Enabled = true;

        }
    }
}
