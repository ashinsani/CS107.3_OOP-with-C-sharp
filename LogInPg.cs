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
    public partial class LogInPg : Form
    {
        public LogInPg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignIn objsin = new SignIn();
            objsin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usname, pass;
            usname=textBox1.Text;
            pass=textBox2.Text;
            if (usname == "Admin" && pass == "admin123")
            {
                Admin objadm = new Admin();
                objadm.Show();
                this.Hide();
            }
            if (usname == "User" && pass == "user123")
                    {
                MainAL objmal = new MainAL();
                objmal.Show();
                this.Hide();
                    }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
