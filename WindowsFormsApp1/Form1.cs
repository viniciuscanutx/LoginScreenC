using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("vinicius") && textBox2.Text.Equals("123"))
                {
                    var menu = new Form2();
                    menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos!",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);


                    textBox1.Focus();
                    textBox2.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário ou senha inválidos!",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
