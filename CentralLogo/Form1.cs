using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralLogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buildButton_Click(object sender, EventArgs e)
        {
            buildButton.Visible = false;

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Green, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);     //sets up brushes and formGraphics

           
            formGraphics.FillEllipse(drawBrush, 250, 100, 400, 300);  //forms background

            drawBrush.Color = Color.White;
            Font drawFont = new Font("Sitka Small", 180, FontStyle.Bold);  //forms big C
            formGraphics.DrawString("C", drawFont, drawBrush, 225, 150);

            
            Font drawFont2 = new Font("Sitka Small", 50, FontStyle.Bold);
            formGraphics.DrawString("Rams", drawFont2, drawBrush, 335, 225);  //forms "rams"

            Font drawFont3 = new Font("Sitka Small", 25, FontStyle.Bold);
            formGraphics.TranslateTransform(585, 190);
            formGraphics.RotateTransform(90); 
            formGraphics.DrawString("Arcade", drawFont3, drawBrush, new Rectangle());  //forms "arcade"
            formGraphics.ResetTransform();
        }
    }
}
