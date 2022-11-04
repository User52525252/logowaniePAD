using logowaniePAD.Properties;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Linq.Expressions;

namespace logowaniePAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cpth;

        (Image, string)[] imagesWithCodes =
        {
                (logowaniePAD.Properties.Resources._1, "mxyxw"),
                (logowaniePAD.Properties.Resources._2, "b5nmm"),
                (logowaniePAD.Properties.Resources._3, "74853"),
                (logowaniePAD.Properties.Resources._4, "cg5dd"),
                (logowaniePAD.Properties.Resources._5, "x3deb"),
                (logowaniePAD.Properties.Resources._6, "befhd"),
                (logowaniePAD.Properties.Resources._7, "c7gb3"),


        };



        public void capcha()
        {
            //liczba losowa
            Random random = new Random();
            var los = random.Next(imagesWithCodes.Length);
            pictureBox1.Image = imagesWithCodes[los].Item1;
            var correctimageCode = los;
            cpth =imagesWithCodes[los].Item2;
        }
      


        private void label5_Click(object sender, EventArgs e)
        {
            capcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string has = "Qwerty1@34";
            string login = "admin";
            if((textBox1.Text==login ) && (textBox2.Text == has) && textBox3.Text == cpth)
            {
                var frm = new Form2();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            else
            {
                capcha();
            }
            

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            capcha();
        }


    }
}