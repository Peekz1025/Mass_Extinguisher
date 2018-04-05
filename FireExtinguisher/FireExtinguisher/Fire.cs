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
    class Fire
    {
        //attributes
        public int health;
        public int damage;
        public Color color;
        Texture2D fireTex;
        public Rectangle location;

        //constructor
        public Fire(int x, int y, int width, int height)
        {
            //new rectangle
            location = new Rectangle(x,y,width,height);
            //how much health
            health = 100;
            //how much damage is applied
            damage = 1;
            color = Color.White;
        }

        //gets and sets the location
        public Rectangle Location
        {
            get { return location; }
            set { location = value; }
        }

        //gets and sets texture
        public Texture2D FireTexture
        {
            get { return fireTex; }
            set { fireTex = value; }
        }

        //gets and sets the damage the fire does
        //wil be 0 if health is 0
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        //gets and sets the health of the fire
        //used for shooting
        public int Health
        {
            //returns health
            get { return health; }
            set { health = value; }
        }

        //draws fires
        public void Draw(SpriteBatch batch, Vector2 camera)
        {
            if (health >= 0)
            {
                Rectangle rect = new Rectangle((int)(location.X - camera.X), (int)(location.Y - camera.Y), location.Width, location.Height);
                batch.Draw(FireTexture, rect, color);
            }
        }


    }
}
