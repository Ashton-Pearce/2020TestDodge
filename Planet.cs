using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2020TestDodge
{
    class Planet
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Planet()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.planet1;
            planetRec = new Rectangle(x, y, width, height);
        }

        //Create a constructor (initialises the values of the fields)
        public Planet(int spacing)
        {
          
        }
        // Methods for the Planet class
        public void DrawPlanet(Graphics g)
        {
            g.DrawImage(planetImage, planetRec);

        }

    }
}
