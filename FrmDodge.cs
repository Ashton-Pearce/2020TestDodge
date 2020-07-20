using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020TestDodge
{
    public partial class Dodge : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Planet[] planet = new Planet[7];




        public Dodge()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                planet[i] = new Planet();
            }

        }

        private void Dodge_Load(object sender, EventArgs e)
        {

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);
            }

        }
    }
}
