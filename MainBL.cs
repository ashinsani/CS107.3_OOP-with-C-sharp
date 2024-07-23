using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uplift_new_
{
    public partial class MainBL : Form
    {
        public MainBL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInPg objlgi = new LogInPg();
            objlgi.Show();
            this.Hide();
        }
    }
}
