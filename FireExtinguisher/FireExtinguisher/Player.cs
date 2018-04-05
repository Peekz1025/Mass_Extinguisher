using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace FireExtinguisher
{
    class Player
    {
        //players location
        public Rectangle playerRectangle;

        //the water the player shoots
        public Water water;

        //textures for player and water
        public Texture2D tex;
        public Texture2D waterTex;

        //if is on ground
        public bool grounded;
        
        //if were in the game
        bool inGame = true;

        //if shooting is true
        public bool isShootingl = false;
        public bool isShootingr = false;

        //previous and current keyboard state
        KeyboardState kbState, previousState;

        //health attribute
        public int health;

        //if running
        bool running;

        //velocity for jumping
        public int yVelocity;

        //tints the player
        Color color;

        //if carrying person
        public bool carry;

        //states of player
        SpriteEffects currentEffect;
        Vector2 location;
        enum PlayerStates { FaceLeft, WalkLeft, FaceRight, WalkRight };
        PlayerStates playerState;


        //constructor
        public Player(int x, int y, int width, int height)
        {
            //sets new player rectangle
            playerRectangle = new Rectangle(x, y, width, height);
            //sets new water rectangle
            water = new Water(playerRectangle.X, playerRectangle.Y, 100, 100);
            //if player is on ground
            grounded = false; 
            //gets new keyboard state
            kbState = new KeyboardState();
            //gets new keyboard state
            previousState = new KeyboardState();
            //sets players health
            health = 80;
            //color 
            color = Color.White;
            //carrying person or not
            carry = false;
            //player animation
            playerState = PlayerStates.FaceRight;
            location = new Vector2(x, y);
        }

        //returns color
        public Color PlayerColor
        {
            get { return color; }
            set { color = value; }
        }
 
        //returns if the player is on the ground
        public bool Grounded()
        {
            //if on ground or not
            return grounded;
        }

        //shooting to the left
        public void Shootingl(Fire f)
        {
            isShootingl = true;
            water.Shootl();
            //if collides with a fire, get rid of the fire and stop water
            if (water.waterRec.Intersects(f.location))
            {
                f.health -= 101;
                f.damage = 0;
                f.location = new Rectangle(0, 0, 0, 0);
                isShootingl = false;
            }
            //if it goes x distance, stop the water
            else if (water.dtraveled >= water.distance)
            {
                f.health -= 101;
                f.damage = 0;
                f.location = new Rectangle(0, 0, 0, 0);
                isShootingl = false;
            }
        }

        //shooting to the right
        public void Shootingr(Fire f)
        {
            isShootingr = true;
            water.Shootr();
            //if collides with a fire, get rid of the fire and stop water
            if (water.waterRec.Intersects(f.location))
            {
                f.health -= 101;
                f.damage = 0;
                f.location = new Rectangle(0, 0, 0, 0);
                isShootingr = false;
            }
            //if it goes x distance, stop the water
            else if (water.dtraveled >= water.distance)
            {
                f.health -= 101;
                f.damage = 0;
                f.location = new Rectangle(0, 0, 0, 0);
                isShootingr = false;
            }
        }

        //makes the player move, shoot, and swing
        public void processInput()
        {
            GamePadCapabilities c = GamePad.GetCapabilities(PlayerIndex.One);
            if (c.IsConnected == false)
            {
                KeyboardState kbState = Keyboard.GetState();
                MouseState mState= Mouse.GetState();

                //makes player turn around
                switch (playerState)
                {
                    case PlayerStates.FaceLeft:
                        currentEffect = SpriteEffects.FlipHorizontally;
                        break;
                    case PlayerStates.WalkLeft:
                        currentEffect = SpriteEffects.FlipHorizontally;
                        break;
                    case PlayerStates.FaceRight:
                        currentEffect = SpriteEffects.None;
                        break;
                    case PlayerStates.WalkRight:
                        currentEffect = SpriteEffects.None;
                        break;
                    default:
                        return;
                }

                //moves palyer left
                if (Keyboard.GetState().IsKeyDown(Keys.A))
                {
                    playerRectangle.X -= 5;
                    playerState = PlayerStates.WalkLeft;
                }
                //moves palyer right
                if (Keyboard.GetState().IsKeyDown(Keys.D))
                {
                    playerRectangle.X += 5;
                    playerState = PlayerStates.WalkRight;
                }
                //moves player left fast (cannot run while carrying person)
                if ((Keyboard.GetState().IsKeyDown(Keys.LeftShift) || Keyboard.GetState().IsKeyDown(Keys.Right)) && Keyboard.GetState().IsKeyDown(Keys.A) && !carry)
                {
                    playerRectangle.X -= 5;
                    playerState = PlayerStates.WalkLeft;
                }
                //moves player right fast (cannot run while carrying person)
                if ((Keyboard.GetState().IsKeyDown(Keys.LeftShift) || Keyboard.GetState().IsKeyDown(Keys.Right)) && Keyboard.GetState().IsKeyDown(Keys.D) && !carry)
                {
                    playerRectangle.X += 5;
                    playerState = PlayerStates.WalkRight;
                }

                //jumping                                                                      
                if (grounded == true && Keyboard.GetState().IsKeyDown(Keys.Space))          
                {
                    int count = 0;
                    yVelocity = -30;
                    count = 0;
                    grounded = false;
                }

                playerRectangle.Y += yVelocity;

                //shooting right
                if (mState.RightButton == ButtonState.Pressed && isShootingl == false)
                {
                    water = new Water(playerRectangle.X, playerRectangle.Y + 50, 100, 100);
                    isShootingl = true;
                }
                //shooting left
                else if (mState.LeftButton == ButtonState.Pressed && isShootingr == false)
                {
                    water = new Water(playerRectangle.X, playerRectangle.Y + 50, 100, 100);
                    isShootingr = true;
                }

            }//process input

            /*
            //unfinished x-box controller suppport
            //negates keyboard use if controller is connected
            if (c.IsConnected)
            {
                GamePadState state = GamePad.GetState(PlayerIndex.One);
                if (c.HasLeftXThumbStick)
                {
                    playerRectangle.X += (int)state.ThumbSticks.Left.X * 3;
                }


                if (grounded == true && state.IsButtonDown(Buttons.A))
                {
                    int count = 0;

                    while (true)
                    {
                       
                        playerRectangle.Y -= 8;
                        count++;
                        if (count == 15)
                            break;
                    }
                    //Thread.Sleep(1);

                    count = 0;
                    grounded = false;
                }

                if (c.HasLeftVibrationMotor && c.HasRightVibrationMotor)
                {
                    if (state.IsButtonDown(Buttons.RightShoulder))
                    {
                        //isShooting = true;

                        //if (isShooting == true)
                            //Shooting();


                        GamePad.SetVibration(PlayerIndex.One, 1, 1);

                    }
                    //else { isShooting = false; }
                }
            }//end of is connected
            */
        }//end of getInput()

        public void InGame(bool playable)
        {
            //if in game
            inGame = playable;
        }

        //sets player texture
        public Texture2D Tex
        {
            //tex
            get { return tex; }
            set { tex = value; }
        }

        //draw method for player
        //uses currentEffect to turn him around
        public void Draw(SpriteBatch batch, Vector2 camera)
        {
            Rectangle rect = new Rectangle((int) (playerRectangle.X - camera.X), (int) (playerRectangle.Y - camera.Y), playerRectangle.Width, playerRectangle.Height);
            batch.Draw(texture: tex, destinationRectangle: rect, color: color, effects: currentEffect);
        }

        /// <summary>
        /// When player jumps, gravity pulls you down
        /// </summary>
        /// <param name="player"></param>
        /// <param name="glst"></param>
        public void Gravity(Player player, List<Ground> glst)
        {
            player.grounded = false;
            foreach(Ground g in glst)
            {
                //if the player intersects with a ground object
                if (player.playerRectangle.Intersects(g.groundRec))
                {
                    //if player comes from top
                    if (player.yVelocity > 0)
                    {
                        //move the player so to not be interesting with ground's rect
                        player.grounded = true;
                        while (player.playerRectangle.Intersects(g.groundRec))
                        {
                            Rectangle rect = player.playerRectangle;
                            rect.Y -= 1;
                            player.playerRectangle = rect;
                        }
                        Rectangle rectt = player.playerRectangle;
                        rectt.Y += 1;
                        player.playerRectangle = rectt;
                    }
                    //if player comes from bottom
                    else
                    {
                        while (player.playerRectangle.Intersects(g.groundRec))
                        {
                            Rectangle rect = player.playerRectangle;
                            rect.Y += 1;
                            player.playerRectangle = rect;
                        }
                    }
                    player.yVelocity = 0;
                    break;
                }
            }

            if (!player.grounded)
            {
                player.yVelocity += 2;
            }
        }

    }
}