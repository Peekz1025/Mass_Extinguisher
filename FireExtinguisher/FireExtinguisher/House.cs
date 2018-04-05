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
    class House
    {
        //attributes
        public Texture2D texture;
        public Vector2 location;

        //constructor
        //used to draw the background in relation to the moveing camera
        public House()
        {

        }

        //draw method
        public void Draw(SpriteBatch batch, Vector2 v, Vector2 camera, Texture2D t)
        {
            Vector2 rect = new Vector2((int)(v.X - camera.X), (int)(v.Y - camera.Y));
            batch.Draw(t, rect, Color.White);
        }
    }
}
