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
    class NPC
    {
        //attributes
        public bool stranded;
        public Rectangle location;

        //constructor
        public NPC(int x, int y, int width, int height)
        {
            location = new Rectangle(x, y, width, height);
            stranded = true;
        }

        //draws npc
        public void Draw(SpriteBatch batch, Texture2D gt, Vector2 camera)
        {
            Rectangle rect = new Rectangle((int)(location.X - camera.X), (int)(location.Y - camera.Y), location.Width, location.Height);
            batch.Draw(gt, rect, Color.White);
        }
    }
}
