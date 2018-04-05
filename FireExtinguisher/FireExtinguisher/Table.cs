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
    class Table
    {
        //this class is a generic object in game that needs to be drawn in the scene.
        //unused, but was going to be used to draw a table and more chair to be extra platforms

        //attributes
        public Rectangle location;

        //constructor
        public Table(int x, int y, int width, int height)
        {
            location = new Rectangle(x, y, width, height);
        }

        //draws the table
        public void Draw(SpriteBatch batch, Texture2D gt, Vector2 camera)
        {
            Rectangle rect = new Rectangle((int)(location.X - camera.X), (int)(location.Y - camera.Y), location.Width, location.Height);
            batch.Draw(gt, rect, Color.White);
        }
    }
}
