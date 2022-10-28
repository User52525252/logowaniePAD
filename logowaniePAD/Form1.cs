using logowaniePAD.Properties;
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
        string odp; // zmiene potrzebne do weryfikacji capcha
        int img;
        (Image, string)[] imagesWithCodes =
        {
                (logowaniePAD.Properties.Resources._1, "aaa"),
                (logowaniePAD.Properties.Resources._2, "aaa"),
                (logowaniePAD.Properties.Resources._3, "aaa"),
                (logowaniePAD.Properties.Resources._4, "aaa"),
                (logowaniePAD.Properties.Resources._5, "aaa"),
                (logowaniePAD.Properties.Resources._6, "aaa"),
                (logowaniePAD.Properties.Resources._7, "aaa"),


        };



        public void capcha()
        {
            //liczba losowa
            Random random = new Random();
            var los = random.Next(imagesWithCodes.Length);
            pictureBox1.Image = imagesWithCodes[los].Item1;
            var correctimageCode = los;           
        }
      


        private void label5_Click(object sender, EventArgs e)
        {
            capcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            capcha();
        }


    }
}