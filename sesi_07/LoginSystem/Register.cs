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
    public partial class Register : Form
    {
        config db = new config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            db.Execute("insert into `user_info` (`id`, `names`, `username`, `password`) values ( null, '" + txt_nama.Text + "', '" + txt_user.Text + "', '" + txt_pass.Text + "')");
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
