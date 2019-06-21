using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVP
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(txtIme.Text!="" && txtPrezime.Text!="")
            {
             
                 Form1 f1 = new Form1();
                 f1.Show();
           }
           else
           {
                 MessageBox.Show("Внесете име и презиме пред да започнете!");
           }
            
        }
    }
}
