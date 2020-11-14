using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeTask9
{
    public partial class Form1 : Form
    {
        Engine obj = new Engine();
        DialogResult dl;
        ushort counter = 0;
        byte procent = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void N2_Click(object sender, EventArgs e)
        {
            //obj.loadFromText();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML файлы (*.xml)|*.xml";
            dl=sfd.ShowDialog();
            if (dl == DialogResult.OK)
                 obj.saveToXML(sfd.FileName);
        }

        private void N3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML файлы (*.xml)|*.xml";
            dl = ofd.ShowDialog();
            if (dl == DialogResult.OK)
            {
                obj.loadFromXML(ofd.FileName);
                //obj.loadFromText();
                if (N5.Checked)
                {
                    foreach (block i in obj.cont)
                        listBox1.Items.Add(i.question);
                    UpDown1.Maximum = obj.cont.Count;
                }
                else
                {
                    progressBar1.Maximum = (int)UpDown1.Value;
                    obj.selectQuesitons((ushort)UpDown1.Value);
                    foreach (block i in obj.contForPupil)
                        listBox1.Items.Add(i.question);
                    textBox1.Text = listBox1.Items[0].ToString();
                    listBox1.SelectedIndex = 0;
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            cb1.Checked = obj.cont[listBox1.SelectedIndex].answer;
        }

        private void N4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            if (AddBut.BackColor == Color.White)
            {
                textBox1.Clear();
                AddBut.BackColor = Color.LightGreen;
                DelBut.BackColor = Color.LightGreen;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            else //green - insert into base
            {
                obj.add(textBox1.Text, cb1.Checked);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                AddBut.BackColor = Color.White;
                DelBut.BackColor = Color.White;
                textBox1.Enabled = false;
            }
            
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (DelBut.BackColor == Color.LightGreen)
                {
                    textBox1.Clear();
                    AddBut.BackColor = Color.White;
                    DelBut.BackColor = Color.White;
                }
                else
                {
                    dl = MessageBox.Show("Имейте ввиду, что, удалив вопрос, вы облегчаете жизнь пилотам. Согласны ли вы на это?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dl == DialogResult.Yes)
                    {
                        obj.del(listBox1.SelectedIndex);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        textBox1.Clear();
                    }
                }
                textBox1.Enabled = false;
            }
            catch { MessageBox.Show("Выберите вопрос.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { };
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked) textBox1.Enabled = true; else 
            {
                obj.del(listBox1.SelectedIndex);
                obj.add(textBox1.Text, cb1.Checked);
                textBox1.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DR;
            DR=MessageBox.Show("Не изволите ли сохраниться?", "Сохранение", MessageBoxButtons.YesNoCancel);
            if (DR == DialogResult.Yes)
            {
                N2_Click(sender, e);
                e.Cancel = (dl == DialogResult.OK) ? false : true;
            }
            else
            if (DR == DialogResult.Cancel) e.Cancel = true; else e.Cancel = false;
        }

        private void N1_Click(object sender, EventArgs e)
        {
            obj.cont.Clear();
            obj.contForPupil.Clear();
            listBox1.Items.Clear();
            textBox1.Clear();
            cb1.Checked = false;
            //AnsBut.Enabled = true;
            cb3.Enabled = true;
            radioButton2.Enabled = true;
            progressBar1.Value = 0;
            label1.Visible = false;
            FinBut.Visible = false;
            //AddBut_Click(sender, e);
        }

        private void N6_Click(object sender, EventArgs e)
        {
            N5.Checked = false;
            N6.Checked = true;
            if (obj.cont.Count == 0) N3_Click(sender, e);


        }

        private void N5_Click(object sender, EventArgs e)
        {
            N5.Checked = true;
            N6.Checked = false;
            panel1.Visible = true;
            panel2.Visible = false;
            N3_Click(sender, e);

        }

        private void AnsBut_Click(object sender, EventArgs e)
        {
            /*if (cb3.Checked = obj.contForPupil[listBox1.SelectedIndex].answer)
                counter++;*/
            //progressBar1.Value+=1;
            int progress=progressBar1.Value;
            obj.contForPupil[listBox1.SelectedIndex].getanswer = (cb3.Checked) ? (sbyte)1 :(sbyte)0; 
            cb3.Checked = false;
            radioButton2.Checked = false;
            obj.CheckAnswers(out counter, out progress);
            progressBar1.Value = progress;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                FinBut.Visible = true;
            }
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = (listBox1.SelectedIndex +1) % listBox1.Items.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex=(listBox1.SelectedIndex==0)? listBox1.Items.Count-1: listBox1.SelectedIndex-1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int lbs = listBox1.SelectedIndex;
                textBox1.Text = listBox1.Items[lbs].ToString();
                if (obj.contForPupil[lbs].getanswer == 0) radioButton2.Checked = true;
                else
                if (obj.contForPupil[lbs].getanswer == 1) cb3.Checked = true;
            }
            catch { }
            finally { }
            

        }

        private void FinBut_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            procent = (byte)((double)counter / progressBar1.Maximum * 100);
            if (procent < UpDown2.Value)
            {
                label1.ForeColor = Color.Red;
                label1.Text = $"Вы ответили правильно на {counter} вопросов ({procent}%), \n при минимуме в {UpDown2.Value}%. \n Cтатус - не сдал!";
            }
            else
            {
                label1.ForeColor = Color.Green;
                label1.Text = $"Вы ответили правильно на {counter} вопросов ({procent}%), \n при минимуме в {UpDown2.Value}%. \n Cтатус - сдал!";
            }
            cb3.Enabled = false;
            radioButton2.Enabled = false;
            FinBut.Visible = false;
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 About = new Form2();
            About.ShowDialog();
        }

        private void N8_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
