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
                SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FINKI VI SEMESTAR\VP\ProjectVP\Database.mdf;Integrated Security=True;Connect Timeout=30");
                string Query = "insert into players(Id,Ime, Prezime) values('" + numericUpDown1.Text + "','" + txtIme.Text + "','" + txtPrezime.Text+ "')";
                SqlCommand cmd = new SqlCommand(Query, conection);
                SqlDataReader reader;
                conection.Open();
                try
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read()) { }
                    Form1 f1 = new Form1((int)numericUpDown1.Value);
                    f1.Show();
                }
                catch
                {
                    MessageBox.Show("Шифрата која што ја внесовте веќе постои во системот!");
                }
                
           }
           else
           {
                 MessageBox.Show("Внесете име и презиме пред да започнете!");
           }
            
        }
    }
}
