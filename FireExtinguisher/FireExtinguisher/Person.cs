using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace FireExtinguisher
{
    class Person
    {
        Texture2D tex;

        public Rectangle personRec;

        bool isScared;
        public Person(int x, int y, int width, int height)
        {

            personRec = new Rectangle(x, y, width, height);


        }

        public void FollowMan(Player player)
        {
            if (personRec.X - player.playerRectangle.X <= 20 && !isScared)
            {
                Random rand = new Random();

                int hold = rand.Next(143,145);
                
                personRec.X = player.playerRectangle.X - hold;

            }

            if (isScared == true)
            {
                
                isScared = false;


            }

        }

        public bool Scared
        {
            get { return isScared; }
            set { isScared = value; }
        }

        public Texture2D PesonTex
        {
            get { return tex; }
            set { tex = value; }
        }

        public void Draw(SpriteBatch batch)
        {

            batch.Draw(tex, personRec, Color.White);
        }



    }
}
