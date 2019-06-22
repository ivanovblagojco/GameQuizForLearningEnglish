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
    public partial class SlidingPuzzle : Form
    {
        int temp;
        Random random;
        int inNullSliceIndex;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        List<Bitmap> lstOriginalPicture1List = new List<Bitmap>();
        List<Bitmap> lstOriginalPicture2List = new List<Bitmap>();
        List<Bitmap> lstOriginalPicture3List = new List<Bitmap>();
        int sifra_za_baza;
        int poeni_za_baza;

        public SlidingPuzzle(int sifra, int poeni)
        {
            sifra_za_baza = sifra;
            poeni_za_baza = poeni;
            InitializeComponent();
            lstOriginalPicture1List.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3,
               Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7,
               Properties.Resources._8, Properties.Resources._9, Properties.Resources._null});
            lstOriginalPicture2List.AddRange(new Bitmap[] { Properties.Resources._11, Properties.Resources._12, Properties.Resources._13,
               Properties.Resources._14, Properties.Resources._15, Properties.Resources._16, Properties.Resources._17,
               Properties.Resources._18, Properties.Resources._19, Properties.Resources._null});
            lstOriginalPicture3List.AddRange(new Bitmap[] { Properties.Resources._21, Properties.Resources._22, Properties.Resources._23,
               Properties.Resources._24, Properties.Resources._25, Properties.Resources._26, Properties.Resources._27,
               Properties.Resources._28, Properties.Resources._29, Properties.Resources._null});


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            if (random.Next(0, 3) == 0)
            {
                lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3,
                    Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7,
                    Properties.Resources._8, Properties.Resources._9, Properties.Resources._null});
                temp = 1;
            }
            else if (random.Next(0, 3) == 1)
            {
                lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._11, Properties.Resources._12, Properties.Resources._13,
                    Properties.Resources._14, Properties.Resources._15, Properties.Resources._16, Properties.Resources._17,
                    Properties.Resources._18, Properties.Resources._19, Properties.Resources._null});
                temp = 2;
            }
            else if (random.Next(0, 3) == 2)
            {
                lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._21, Properties.Resources._22, Properties.Resources._23,
                    Properties.Resources._24, Properties.Resources._25, Properties.Resources._26, Properties.Resources._27,
                    Properties.Resources._28, Properties.Resources._29, Properties.Resources._null});
                temp = 3;
            }

            Shuffle();
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    //Nekogash vo ovaa linija kod javuva greshka
                    ((PictureBox)gbPuzzle.Controls[i]).Image = lstOriginalPictureList[j];

                    if (j == 9)
                        inNullSliceIndex = i;
                }
            } while (CheckWin());
        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {
            int inPictureBoxIndex = gbPuzzle.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourNeighbors = new List<int>(new int[] { inPictureBoxIndex - 1, inPictureBoxIndex + 1, inPictureBoxIndex - 3, inPictureBoxIndex + 3 });
                if (FourNeighbors.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzle.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzle.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzle.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    if (CheckWin())
                    {
                        (gbPuzzle.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                    }
                }
            }
        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzle.Controls[i] as PictureBox).Image != lstOriginalPictureList[i])
                    break;
            }
            if (i == 8)
                return true;
            else
                return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int poeni=0;
            if (temp == 1)
            {
                if ((CheckWin() == true && tbAnswer.Text == "elephant") || (CheckWin() == true && tbAnswer.Text == "Elephant"))
                {
                    poeni = 10;
                }
                else if ((CheckWin() == false && tbAnswer.Text == "elephant") || (CheckWin() == false && tbAnswer.Text == "Elephant"))
                {
                    poeni = 5;
                }
                else if ((CheckWin() == true && tbAnswer.Text != "elephant") || (CheckWin() == true && tbAnswer.Text != "Elephant"))
                {
                    poeni = 5;
                }
                else
                {
                    poeni = 0;
                }
                
                MessageBox.Show("Poeni: " + poeni + " /10");
            }
            if (temp == 2)
            {
                if ((CheckWin() == true && tbAnswer.Text == "kangaroo") || (CheckWin() == true && tbAnswer.Text == "Kangaroo"))
                {
                    poeni = 10;
                }
                else if ((CheckWin() == false && tbAnswer.Text == "kangaroo") || (CheckWin() == false && tbAnswer.Text == "Kangaroo"))
                {
                    poeni = 5;
                }
                else if ((CheckWin() == true && tbAnswer.Text != "kangaroo") || (CheckWin() == true && tbAnswer.Text != "Kangaroo"))
                {
                    poeni = 5;
                }
                else
                {
                    poeni = 0;
                }
                MessageBox.Show("Poeni: " + poeni + " /10");
            }
            if (temp == 3)
            {
                if ((CheckWin() == true && tbAnswer.Text == "lion") || (CheckWin() == true && tbAnswer.Text == "Lion"))
                {
                    poeni = 10;
                }
                else if ((CheckWin() == false && tbAnswer.Text == "lion") || (CheckWin() == false && tbAnswer.Text == "Lion"))
                {
                    poeni = 5;
                }
                else if ((CheckWin() == true && tbAnswer.Text != "lion") || (CheckWin() == true && tbAnswer.Text != "Lion"))
                {
                    poeni = 5;
                }
                else
                {
                    poeni = 0;
                }
                MessageBox.Show("Poeni: " + poeni + " /10");
            }
            poeni_za_baza = poeni_za_baza + poeni;
            SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FINKI VI SEMESTAR\VP\ProjectVP\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Query = "update players set Poeni='" +poeni_za_baza + "' where Id='" + sifra_za_baza + "'";
            SqlCommand cmd = new SqlCommand(Query, conection);
            SqlDataReader reader;
            conection.Open();
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read()) { }

            }
            catch
            {
                MessageBox.Show("Неуспешен запис во база");
            }
            MessageBox.Show("Вашиот резултат е внесен во системот! Освоивте вкупно "+poeni_za_baza+ " поени");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
