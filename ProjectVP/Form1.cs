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
    public partial class Form1 : Form
    {
        RectangleDoc rectangleDoc;
        Rectangle squere;
        Timer timer;
        int timeElapsed;
        int max_time;
        StringBuilder sb;
        int selectedNumber;
        int kolkuBukviSobereni = 0;
        bool beseTuka1;
        bool beseTuka2;
        bool beseTuka3;
        int sifra_za_prenos;
        int poeni_lavirint;

        public Form1(int sifra)
        {
            InitializeComponent();
            Initialization();
            sifra_za_prenos = sifra;
        }
        public void Initialization()
        {
            this.DoubleBuffered = true;
            kolkuBukviSobereni = 0;
            sb = new StringBuilder();
            squere = new Rectangle(Color.Black);
            squere.X = 40; squere.Y = 80; squere.Width = 20; squere.Height = 20;
            rectangleDoc = new RectangleDoc();
            rectangleDoc.AddRectangle(squere);

            DifferentWords();
            PlaceLetterLabels();
            beseTuka1 = false;
            beseTuka2 = false;
            beseTuka3 = false;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
            timeElapsed = 0;
            max_time = 90;
            poeni_lavirint = 0;

        }
        public void DifferentWords()
        {
            Random random = new Random();
            int num = random.Next(0, 10);
            switch (num)
            {
                case 0: label1.Text = "C"; label2.Text = "A"; label3.Text = "R"; break;
                case 1: label1.Text = "C"; label2.Text = "A"; label3.Text = "T"; break;
                case 2: label1.Text = "R"; label2.Text = "U"; label3.Text = "N"; break;
                case 3: label1.Text = "A"; label2.Text = "G"; label3.Text = "E"; break;
                case 4: label1.Text = "B"; label2.Text = "O"; label3.Text = "X"; break;
                case 5: label1.Text = "F"; label2.Text = "O"; label3.Text = "X"; break;
                case 6: label1.Text = "E"; label2.Text = "Y"; label3.Text = "E"; break;
                case 7: label1.Text = "S"; label2.Text = "K"; label3.Text = "Y"; break;
                case 8: label1.Text = "A"; label2.Text = "R"; label3.Text = "T"; break;
                case 9: label1.Text = "J"; label2.Text = "O"; label3.Text = "B"; break;
            }
            selectedNumber = num;
        }
        public void PlaceLetterLabels()
        {
            Random random = new Random();
            int x = random.Next(20, 370);
            int y = random.Next(60, 400);
            while (CheckColisionsForLabels(x, y))
            {
                x = random.Next(20, 370);
                y = random.Next(60, 400);
                CheckColisionsForLabels(x, y);
            }
            label1.Location = new Point(x, y);
            x = random.Next(20, 370);
            y = random.Next(60, 400);
            while (CheckColisionsForLabels(x, y))
            {
                x = random.Next(20, 370);
                y = random.Next(60, 400);
                CheckColisionsForLabels(x, y);
            }
            label2.Location = new Point(x, y);
            x = random.Next(20, 370);
            y = random.Next(60, 400);
            while (CheckColisionsForLabels(x, y))
            {
                x = random.Next(20, 370);
                y = random.Next(60, 400);
                CheckColisionsForLabels(x, y);
            }
            label3.Location = new Point(x, y);
        }
        public bool CheckColisionsForLabels(int x, int y)
        {

            foreach (Rectangle r in rectangleDoc.rectangles)
            {
                if ((x + label1.Width > r.X && y + label1.Height > r.Y && r.X + r.Width > x && r.Y + r.Height > y) == true)
                {

                    return true;
                }

            }
            return false;
        }
        public void timer_tick(object sender, EventArgs e)
        {

            if (max_time == timeElapsed)
            {

                timer.Stop();
                lblTimer.Text = String.Format("Време: " + "{0:00}:{1:00}", (max_time - timeElapsed) / 60, (max_time - timeElapsed) % 60);
                DialogResult result;
                result = MessageBox.Show("Ви истече времето. Обидете се повторно!", "Прашање", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Initialization();
                }
                else
                {

                }

            }
            else
            {
                lblTimer.Text = String.Format("Време: " + "{0:00}:{1:00}", (max_time - timeElapsed) / 60, (max_time - timeElapsed) % 60);
                max_time--;
            }


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            rectangleDoc.Draw(e.Graphics);


            Pen p = new Pen(Color.Black, 2);
            e.Graphics.DrawRectangle(p, 20, 60, 400, 400);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (squere.Y > 60)
                {
                    squere.Y -= 5;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                if (squere.Y < 440)
                {
                    squere.Y += 5;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (squere.X > 20)
                {
                    squere.X -= 5;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (squere.X < 400)
                {
                    squere.X += 5;
                }
            }
            if (rectangleDoc.isSquereColliding() == true)
            {
                Initialization();
                MessageBox.Show("Се судривте со препрека, обидете се повторно!");
            }
            if (isFinish() == true)
            {
                string str = "";
                switch (selectedNumber)
                {
                    case 0: str = "Од буквите може да се направи зборот CAR што на македонски значи АВТОМОБИЛ"; break;
                    case 1: str = "Од буквите може да се направи зборот CAT што на македонски значи МАЧКА"; break;
                    case 2: str = "Од буквите може да се направи зборот RUN што на македонски значи ТРЧА"; break;
                    case 3: str = "Од буквите може да се направи зборот AGE што на македонски значи ГОДИНА"; break;
                    case 4: str = "Од буквите може да се направи зборот BOX што на македонски значи КУТИЈА"; break;
                    case 5: str = "Од буквите може да се направи зборот FOX што на македонски значи ЛИСИЦА"; break;
                    case 6: str = "Од буквите може да се направи зборот EYE што на македонски значи ОКО"; break;
                    case 7: str = "Од буквите може да се направи зборот SKY што на македонски значи НЕБО"; break;
                    case 8: str = "Од буквите може да се направи зборот ART што на македонски значи уметност"; break;
                    case 9: str = "Од буквите може да се направи зборот JOB што на македонски значи РАБОТА"; break;
                }
                if (kolkuBukviSobereni == 3)
                {
                    MessageBox.Show("Честитки, го решивте лавиринтот!" + " " + str);
                    poeni_lavirint = 10;
                    timer.Stop();
                    if (MessageBox.Show("Продолжете на наредната игра.До сега имате освоено " + poeni_lavirint + " поени", "Следна игра", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MemoryGame form = new MemoryGame(sifra_za_prenos, poeni_lavirint);
                        form.Show();
                    }
                    else
                    {
                        SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FINKI VI SEMESTAR\VP\ProjectVP\Database.mdf;Integrated Security=True;Connect Timeout=30");
                        string Query = "update players set Poeni='" + poeni_lavirint + "' where Id='" + sifra_za_prenos + "'";
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
                    }
                }
                else
                {
                    MessageBox.Show("Честитки, го решивте лавиринтот, но не ги собравте сите букви!" + " " + str);
                    poeni_lavirint = 5;
                    timer.Stop();
                    if (MessageBox.Show("Продолжете на наредната игра. До сега имате освоено "+poeni_lavirint+" поени", "Следна игра", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MemoryGame form = new MemoryGame(sifra_za_prenos, poeni_lavirint);
                        form.Show();
                    }
                    else
                    {
                        SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FINKI VI SEMESTAR\VP\ProjectVP\Database.mdf;Integrated Security=True;Connect Timeout=30");
                        string Query = "update players set Poeni='" + poeni_lavirint + "' where Id='" + sifra_za_prenos + "'";
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
                    }
                }


            }
            SquereCollisions();
            Invalidate(true);

        }

        public bool isFinish()
        {
            if (squere.X + squere.Width > lblGoal.Location.X && squere.Y + squere.Height > lblGoal.Location.Y && lblGoal.Location.X + lblGoal.Width > squere.X && lblGoal.Location.Y + lblGoal.Height > squere.Y)
            {
                return true;
            }
            return false;
        }
        public void SquereCollisions()
        {

            if (squere.X + squere.Width > label1.Location.X && squere.Y + squere.Height > label1.Location.Y && label1.Location.X + label1.Width > squere.X && label1.Location.Y + label1.Height > squere.Y)
            {
                if (beseTuka1 == false)
                {
                    kolkuBukviSobereni++;
                    beseTuka1 = true;
                }

                sb.Append(label1.Text.ToString());
                label1.Text = "";


            }
            if (squere.X + squere.Width > label2.Location.X && squere.Y + squere.Height > label2.Location.Y && label2.Location.X + label2.Width > squere.X && label2.Location.Y + label2.Height > squere.Y)
            {
                if (beseTuka2 == false)
                {
                    kolkuBukviSobereni++;
                    beseTuka2 = true;
                }
                sb.Append(label2.Text.ToString());
                label2.Text = "";

            }
            if (squere.X + squere.Width > label3.Location.X && squere.Y + squere.Height > label3.Location.Y && label3.Location.X + label3.Width > squere.X && label3.Location.Y + label3.Height > squere.Y)
            {
                if (beseTuka3 == false)
                {
                    kolkuBukviSobereni++;
                    beseTuka3 = true;
                }
                sb.Append(label3.Text.ToString());
                label3.Text = "";

            }
            toolStripStatusLabel1.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
