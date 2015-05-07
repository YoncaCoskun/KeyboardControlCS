using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardControlProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int xKoord = pictureBox1.Location.X;
            int yKoord = pictureBox1.Location.Y;

            if (e.KeyCode==Keys.Right && xKoord<300)
            {
                xKoord += 5;
            }
            if (e.KeyCode==Keys.Left && xKoord>0)
            {
                xKoord -= 5;
            }

            if (e.KeyCode==Keys.Up && yKoord>0)
            {
                yKoord -= 5;
            }

            if (e.KeyCode==Keys.Down && yKoord<300)
            {
                yKoord += 5;
            }
            pictureBox1.Location = new Point(xKoord,yKoord);
        }

        
    }
}
