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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(AppContext.BaseDirectory+"Справка.html");
        }

    }
}
