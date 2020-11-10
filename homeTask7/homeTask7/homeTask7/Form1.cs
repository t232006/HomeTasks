using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeTask7
{
    public partial class Form1 : Form
    {
        guess obj2;
        doubler obj = new doubler();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SSL.Text = obj.ChangeCount(action.add);
            label1.Text = obj.ChangeResult(action.add);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SSL.Text = obj.ChangeCount(action.add);
            label1.Text = obj.ChangeResult(action.mul2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SSL.Text = obj.ChangeCount(action.zero);
            label1.Text = obj.ChangeResult(action.zero);
            obj.ListAction.Clear();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (obj.CheckResult((sender as Label).Text))
                (sender as Label).Text = "Поздравляю, ты достиг цели за " + SSL.Text + " ходов."; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Visible = true;
                label3.Visible = true;
                N3.Checked = true;
                label3.Text = obj.Goal.ToString();
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                N3.Checked = false;
            }
        }

        private void N3_Click(object sender, EventArgs e)
        {
            //checkBox1_CheckedChanged(sender, e);
            checkBox1.Checked = N3.Checked;
        }

        private void откатитьНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text=obj.ChangeResult(action.sub);
            if (label1.Text!="0")
            SSL.Text = obj.ChangeCount(action.sub);
        }

        private void угадайЧислоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NN1.Enabled=false;
            panel1.Visible = true;
            obj2=new guess();
        }

        private void NN1_Click(object sender, EventArgs e)
        {
            //NN2.Enabled = false;
            panel1.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SSL.Text = (byte.Parse(SSL.Text) + 1).ToString();
            obj2.Assump = byte.Parse(textBox1.Text);
            if (obj2.MakeMove()) label4.Text = "угадано"; else
            label4.Text="Неверно. Твое число в промежутке \n от "+obj2.Min.ToString()+" до "+obj2.Max.ToString();


        }
    }
}
