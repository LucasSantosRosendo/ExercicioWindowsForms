using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logincinin
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox2.Text, senha = textBox1.Text;
            if (login == "admin" && senha == "ds@etefmc")
            {

                MessageBox.Show("Login efetuado com sucesso! ✔️");

            } else
            {

                MessageBox.Show("❌ ERR0 444! Login e/ou senha incorretos! ❌");

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
