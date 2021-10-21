using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        config db = new config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.ExecutedSelect("SELECT * FROM `user_info` where username='" + txt_user.Text + "' and password='" + txt_pass.Text + "'");
            if (db.Count() == 1)
            {
                MessageBox.Show("Sukses! Anda masuk sebagai " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Kombinasi user dan password salah!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
