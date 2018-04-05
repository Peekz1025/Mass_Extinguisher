using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireExtinguisher
{
    class Water
    {
        //attributes
        public Rectangle waterRec;
        public int distance;
        public int dtraveled;     

        //constructor
        public Water(int x, int y, int width, int height)
        {
            waterRec = new Rectangle(x,y,width,height);
            distance = 350;
            dtraveled = 0;
        }

        //gets and sets how far the water has traveled
        public int Dtraveled
        {
            get { return dtraveled; }
            set { dtraveled = value; }
        }
        
        //draws water
        public void DrawWater(SpriteBatch batch, Texture2D wt, Vector2 camera)
        {
            Rectangle rect = new Rectangle((int)(waterRec.X - camera.X), (int)(waterRec.Y - camera.Y), waterRec.Width, waterRec.Height);
            batch.Draw(wt, rect, Color.White);
        }

        //resets the water so it return to the player
        public void Reset(int x, int y, int width, int height)
        {
            waterRec = new Rectangle(x,y,width,height);
        }

        //moves water to the left
        public void Shootl()
        {
            dtraveled += 1;
            waterRec.X += 1;
        }

        //moves water to the right
        public void Shootr()
        {
            dtraveled += 1;
            waterRec.X -= 1;
        }
    }
}
