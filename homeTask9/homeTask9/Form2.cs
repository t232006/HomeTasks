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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
