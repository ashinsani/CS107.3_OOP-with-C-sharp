using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uplift_new_
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            lbl_catError.Visible = false;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            pictureBox2.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainAL objmal = new MainAL();   
            objmal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                pictureBox2.Image = Image.FromFile(selectedImagePath);
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string category = comboBox1.Text;
            Image image = pictureBox2.Image;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Csharp database\DBuplift\DBUplift.mdf';Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO info values('"+ title +"','" + category + "','" + image + "')";
            SqlCommand cmd = new SqlCommand(qry, con);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Inserted Successfully");
            }


            lbl_catError.Visible = false;
            string Category;
            bool error = false;
            if (comboBox1.SelectedIndex == -1)
            {
                lbl_catError.Text = "Please Select a category";
                lbl_catError.Visible = true;
                error = true;
            }
            Category = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
