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
    public partial class Men : Form
    {
        public Men()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainAL objmal = new MainAL();
            objmal.Show();
            this.Hide();
        }
    }
}
