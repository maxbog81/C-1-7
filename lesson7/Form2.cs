using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int num=0;

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            num = rnd.Next(1, 10);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cur_num = int.Parse(textBox1.Text);

                if (cur_num==num) MessageBox.Show("Вы угадали!!!");
                if (cur_num < num) MessageBox.Show("Вы не угадали!!! Число больше!");
                if (cur_num > num) MessageBox.Show("Вы не угадали!!! Число меньше!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
