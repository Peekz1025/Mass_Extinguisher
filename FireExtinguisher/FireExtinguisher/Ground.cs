using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FireExtinguisher
{
    class Ground
    {
        //attributes
        public Rectangle groundRec;
        public Texture2D texture;

        //constructor
        public Ground(int x, int y, int width, int height)
        {
            groundRec = new Rectangle(x, y, width, height);
        }

        //sets texture for the ground
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        //draws the ground
        public void Draw(SpriteBatch batch, Texture2D gt, Vector2 camera)
        {
            Rectangle rect = new Rectangle((int)(groundRec.X - camera.X), (int)(groundRec.Y - camera.Y), groundRec.Width, groundRec.Height);
            batch.Draw(gt, rect, Color.White);
        }

    }
}
