using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVP
{
    public partial class MemoryGame : Form
    {
        bool Prv;
        String ImeSlika = "";
        Bitmap bitmap;
        int vreme = 0;
        PictureBox p;
        List<Bitmap> ListaRasporedeni = new List<Bitmap>();
        List<Bitmap> ListaSliki = new List<Bitmap>();
        int max = 1;
        Timer timer;


        public MemoryGame()
        {
            InitializeComponent();
            Prv = true;

            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();

            bitmap = null;
            ListaSliki.AddRange(new Bitmap[] { Properties.Resources.avocado, Properties.Resources.avocado, Properties.Resources.banana, Properties.Resources.banana,
                Properties.Resources.coconut, Properties.Resources.coconut, Properties.Resources.dragonFruit, Properties.Resources.dragonFruit, Properties.Resources.mango,
                Properties.Resources.mango, Properties.Resources.Jabolka, Properties.Resources.Jabolka, Properties.Resources.pineapple, Properties.Resources.pineapple,
                Properties.Resources.watermelon, Properties.Resources.watermelon});

        }
        public void timer_tick(object sender, EventArgs e)
        {
            if (isFinished() == true)
            {
                timer.Stop();
                if (MessageBox.Show("Честитки. Продолжете на наредната игра.", "Следна игра", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    SlidingPuzzle form = new SlidingPuzzle();
                    form.Show();
                }
            }
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            Shuffle();
            for (int i = 0; i < 16; i++)
            {
                ((PictureBox)gbPuzzle2.Controls[i]).Image = Properties.Resources.prasalnik;
            }
        }

        void Shuffle()
        {

            int j;
            List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            Random r = new Random();
            for (int i = 0; i < 16; i++)
            {
                Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                ((PictureBox)gbPuzzle2.Controls[i]).Image = ListaSliki[j];
                ListaRasporedeni.Add(ListaSliki[j]);

            }

        }

        public bool isFinished()
        {
            for (int i = 0; i < 16; i++)
            {
                if (((PictureBox)gbPuzzle2.Controls[i]).Visible == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void pbx2_Click(object sender, EventArgs e)
        {

        }

        private void pbx3_Click(object sender, EventArgs e)
        {

        }

        private void pbx1_Click(object sender, EventArgs e)
        {

        }

        private void pbx4_Click(object sender, EventArgs e)
        {

        }
        private static bool Equals(Bitmap bmp1, Bitmap bmp2)
        {
            if (!bmp1.Size.Equals(bmp2.Size))
            {
                return false;
            }
            for (int x = 0; x < bmp1.Width; ++x)
            {
                for (int y = 0; y < bmp1.Height; ++y)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void pbx1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[15]).Image = ListaRasporedeni[15];


                if (Prv)
                {

                    bitmap = ListaRasporedeni[15];
                    p = ((PictureBox)gbPuzzle2.Controls[15]);
                    Prv = false;
                }
                else
                {

                    if (Equals(bitmap, ListaRasporedeni[15]))
                    {
                        p.Visible = false;
                        pbx1.Visible = false;
                    }
                    else
                    {

                        p.Image = Properties.Resources.prasalnik;
                        pbx1.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx2_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[14]).Image = ListaRasporedeni[14];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[14];
                    p = ((PictureBox)gbPuzzle2.Controls[14]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[14]))
                    {
                        p.Visible = false;
                        pbx2.Visible = false;
                    }
                    else
                    {

                        p.Image = Properties.Resources.prasalnik;
                        pbx2.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx3_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[13]).Image = ListaRasporedeni[13];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[13];
                    p = ((PictureBox)gbPuzzle2.Controls[13]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[13]))
                    {
                        p.Visible = false;
                        pbx3.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx3.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx4_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[12]).Image = ListaRasporedeni[12];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[12];
                    p = ((PictureBox)gbPuzzle2.Controls[12]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[12]))
                    {
                        p.Visible = false;
                        pbx4.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx4.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx5_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[11]).Image = ListaRasporedeni[11];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[11];
                    p = ((PictureBox)gbPuzzle2.Controls[11]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[11]))
                    {
                        p.Visible = false;
                        pbx5.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx5.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx6_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[10]).Image = ListaRasporedeni[10];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[10];
                    p = ((PictureBox)gbPuzzle2.Controls[10]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[10]))
                    {
                        p.Visible = false;
                        pbx6.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx6.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx7_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[9]).Image = ListaRasporedeni[9];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[9];
                    p = ((PictureBox)gbPuzzle2.Controls[9]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[9]))
                    {
                        p.Visible = false;
                        pbx7.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx7.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }

            }
        }

        private void pbx8_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[8]).Image = ListaRasporedeni[8];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[8];
                    p = ((PictureBox)gbPuzzle2.Controls[8]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[8]))
                    {
                        p.Visible = false;
                        pbx8.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx8.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx9_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[7]).Image = ListaRasporedeni[7];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[7];
                    p = ((PictureBox)gbPuzzle2.Controls[7]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[7]))
                    {
                        p.Visible = false;
                        pbx9.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx9.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx10_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[6]).Image = ListaRasporedeni[6];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[6];
                    p = ((PictureBox)gbPuzzle2.Controls[6]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[6]))
                    {
                        p.Visible = false;
                        pbx10.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx10.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx11_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[5]).Image = ListaRasporedeni[5];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[5];
                    p = ((PictureBox)gbPuzzle2.Controls[5]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[5]))
                    {
                        p.Visible = false;
                        pbx11.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx11.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx12_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[4]).Image = ListaRasporedeni[4];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[4];
                    p = ((PictureBox)gbPuzzle2.Controls[4]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[4]))
                    {
                        p.Visible = false;
                        pbx12.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx12.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx13_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[3]).Image = ListaRasporedeni[3];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[3];
                    p = ((PictureBox)gbPuzzle2.Controls[3]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[3]))
                    {
                        p.Visible = false;
                        pbx13.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx13.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx14_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[2]).Image = ListaRasporedeni[2];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[2];
                    p = ((PictureBox)gbPuzzle2.Controls[2]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[2]))
                    {
                        p.Visible = false;
                        pbx14.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx14.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx15_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[1]).Image = ListaRasporedeni[1];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[1];
                    p = ((PictureBox)gbPuzzle2.Controls[1]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[1]))
                    {
                        p.Visible = false;
                        pbx15.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx15.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }

        private void pbx16_MouseClick(object sender, MouseEventArgs e)
        {
            if ((float)(Math.Sqrt((e.Location.X - pbx1.Location.X) * (e.Location.X - pbx1.Location.X) + (e.Location.Y - pbx1.Location.Y) * (e.Location.Y - pbx1.Location.Y))) <= pbx1.Width)
            {
                ((PictureBox)gbPuzzle2.Controls[0]).Image = ListaRasporedeni[0];
                if (Prv)
                {
                    bitmap = ListaRasporedeni[0];
                    p = ((PictureBox)gbPuzzle2.Controls[0]);
                    Prv = false;
                }
                else
                {
                    if (Equals(bitmap, ListaRasporedeni[0]))
                    {
                        p.Visible = false;
                        pbx16.Visible = false;
                    }
                    else
                    {
                        p.Image = Properties.Resources.prasalnik;
                        pbx16.Image = Properties.Resources.prasalnik;

                    }
                    Prv = true;
                }
            }
        }
    }
}
