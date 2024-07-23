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
    public partial class MainAL : Form
    {
        private string usname;

        public MainAL()
        {
            InitializeComponent();
            usname = Name;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string Name;
         
            
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Women objwmn = new Women();
            objwmn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Men objmn = new Men();
            objmn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kids objkd = new Kids();    
            objkd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainBL objmbl = new MainBL();
            objmbl.Show();
            this.Hide();
        }
    }
}
