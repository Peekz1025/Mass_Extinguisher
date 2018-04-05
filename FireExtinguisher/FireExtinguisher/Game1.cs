using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FireExtinguisher
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        //attributes
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;
        //self explained textures
        private Texture2D groundTexture;
        private Texture2D playerTexture;
        private Texture2D fireTexture;
        private Texture2D menuTexture;
        private Texture2D paused;
        private Texture2D instructions;
        private Texture2D gameover;
        private Texture2D won;
        private Texture2D npcTexture;
        Texture2D chairTexture;
        Texture2D tableTexture;
        Texture2D background;
        Texture2D waterTex;
        //camera movement
        Vector2 camera;
        Rectangle menuRec;
        //fires
        Fire fire1;
        Fire fire2;
        Fire fire3;
        Fire fire4;
        Fire fire5;
        Fire fire6;
        Fire fire7;
        Fire fire8;
        Fire fire9;
        Fire fire10;
        Fire fire11;
        Fire fire12;
        Fire fire13;
        Fire fire14;
        Fire fire15;
        Fire fire16;
        Fire fire17;
        Fire fire18;
        Fire fire19;
        Fire fire20;
        Fire fire21;
        Fire fire22;
        Fire fire23;
        Fire fire24;
        Fire fire25;
        Fire fire26;
        Fire fire27;
        Fire fire28;
        Fire fire29;
        Fire fire30;
        Fire fire31;
        Fire fire32;
        Fire fire33;
        Fire fire34;
        Fire fire35;
        Fire fire36;
        Fire fire37;
        Fire fire38;
        Fire fire39;
        Fire fire40;
        Fire fire41;
        //floor and wall objects
        Ground ground1;
        Ground ground2;
        Ground ground3;
        Ground ground4;
        Ground ground5;
        Ground ground6;
        Ground ground7;
        Ground ground8;
        Ground ground9;
        Ground ground10;
        Ground ground11;
        Ground ground12;
        //player, npc, 
        Player player;
        NPC damsel;
        //lists if fire, floor, and wall objects
        List<Fire> flst;
        List<Ground> glsth;
        List<Ground> glstv;
        //the win condition box
        Rectangle wincon;
        //background object
        House house;
        //auto sets keyboard state, the game state and the player state
        KeyboardState kbState, previousState;
        GameState currentState = GameState.menuScreen;
        PlayerState ps = PlayerState.FaceRight;
        //unused assets for more platforms
        //Ground ground13;
        //Ground ground14;
        //Ground ground15;
        //Table table1;
        //Table chair1;
        //Table chair2;
        //List<Ground> glsto;

        //constructor
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            //graphics.ToggleFullScreen(); makes full screen  
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            IsMouseVisible = true;
            player = new Player(0,300,100,200);
            damsel = new NPC(200, -390, 50, 100);
            wincon = new Rectangle(0, 350, 100, 200);

            //table1 = new Table(1900, 530, 200, 100);
            //chair1 = new Table(190, 140, 120, 175);
            //chair2 = new Table(850, -135, 120, 175);

            house = new House();

            font = Content.Load<SpriteFont>("mainFont");

            //inistialize the two keyboards
            kbState = new KeyboardState();
            previousState = new KeyboardState();

            //makes horizontal ground objects
            ground1 = new Ground(-400, 625, 3075, 20);
            ground2 = new Ground(105, 300, 1750, 20);
            ground3 = new Ground(2100, 300, 550, 20);
            ground4 = new Ground(390, 30, 2250, 20);
            ground5 = new Ground(105, -300, 675, 20);
            ground6 = new Ground(970, -300, 267, 20);
            ground7 = new Ground(105, -530, 1130, 20);
            //makes vertical ground objects
            ground8 = new Ground(-10, -500, 20, 1000);
            ground9 = new Ground(105, -530, 20, 830);
            ground10 = new Ground(2650, 300, 20, 330);
            ground11 = new Ground(2630, -450, 20, 750);
            ground12 = new Ground(1230, -530, 20, 250);

            //initalizes list of floors
            glsth = new List<Ground>();
            glsth.Add(ground1);
            glsth.Add(ground2);
            glsth.Add(ground3);
            glsth.Add(ground4);
            glsth.Add(ground5);
            glsth.Add(ground6);
            glsth.Add(ground7);

            //inits list of walls
            glstv = new List<Ground>();
            glstv.Add(ground8);
            glstv.Add(ground9);
            glstv.Add(ground10);
            glstv.Add(ground11);
            glstv.Add(ground12);

            //makes fire objects
            //first floor
            fire1 = new Fire(550, 530, 100, 100);
            fire2 = new Fire(570, 400, 100, 100);
            fire3 = new Fire(150, 300, 100, 100);
            fire4 = new Fire(750, 320, 100, 100);
            fire5 = new Fire(1150, 400, 100, 100);
            fire6 = new Fire(900, 430, 100, 100);
            fire7 = new Fire(1280, 350, 100, 100);
            fire8 = new Fire(1620, 530, 100, 100);
            fire9 = new Fire(1710, 530, 100, 100);
            fire10 = new Fire(1670, 430, 100, 100);
            fire11 = new Fire(1800, 530, 100, 100);
            fire12 = new Fire(1700, 330, 100, 100);
            fire13 = new Fire(2200, 530, 100, 100);
            fire14 = new Fire(2100, 450, 100, 100);
            fire15 = new Fire(2180, 370, 100, 100);
            fire16 = new Fire(2580, 430, 100, 100);
            fire17 = new Fire(2520, 530, 100, 100);
            //second floor
            fire18 = new Fire(2520, 210, 100, 100);
            fire19 = new Fire(2420, 210, 100, 100);
            fire20 = new Fire(2180, 100, 100, 100);
            fire21 = new Fire(1650, 110, 100, 100);
            fire22 = new Fire(1400, 100, 100, 100);
            fire23 = new Fire(1250, 210, 100, 100);
            fire24 = new Fire(1090, 180, 100, 100);
            fire25 = new Fire(950, 80, 100, 100);
            fire26 = new Fire(830, 115, 100, 100);
            fire27 = new Fire(700, 120, 100, 100);
            fire28 = new Fire(550, 210, 100, 100);
            fire29 = new Fire(790, 210, 100, 100);
            fire30 = new Fire(240, 95, 100, 100);
            //third floor
            fire31 = new Fire(420, -125, 100, 100);
            fire32 = new Fire(750, -60, 100, 100);
            fire33 = new Fire(850, -60, 100, 100);
            fire34 = new Fire(2520, -60, 100, 100);
            fire35 = new Fire(2400, -320, 100, 100);
            //forth floor
            fire36 = new Fire(1130, -390, 100, 100);
            fire37 = new Fire(1020, -450, 100, 100);
            fire38 = new Fire(1120, -500, 100, 100);
            fire39 = new Fire(720, -390, 100, 100);
            fire40 = new Fire(460, -450, 100, 100);
            fire41 = new Fire(520, -500, 100, 100);

            //initalizes fire list
            flst = new List<Fire>();
            flst.Add(fire1);
            flst.Add(fire2);
            flst.Add(fire3);
            flst.Add(fire4);
            flst.Add(fire5);
            flst.Add(fire6);
            flst.Add(fire7);
            flst.Add(fire8);
            flst.Add(fire9);
            flst.Add(fire10);
            flst.Add(fire11);
            flst.Add(fire12);
            flst.Add(fire13);
            flst.Add(fire14);
            flst.Add(fire15);
            flst.Add(fire16);
            flst.Add(fire17);
            flst.Add(fire18);
            flst.Add(fire19);
            flst.Add(fire20);
            flst.Add(fire21);
            flst.Add(fire22);
            flst.Add(fire23);
            flst.Add(fire24);
            flst.Add(fire25);
            flst.Add(fire26);
            flst.Add(fire27);
            flst.Add(fire28);
            flst.Add(fire29);
            flst.Add(fire30);
            flst.Add(fire31);
            flst.Add(fire32);
            flst.Add(fire33);
            flst.Add(fire34);
            flst.Add(fire35);
            flst.Add(fire36);
            flst.Add(fire37);
            flst.Add(fire38);
            flst.Add(fire39);
            flst.Add(fire40);
            flst.Add(fire41);

            //sets camera vector
            camera = new Vector2(0, 0);

            menuRec = new Rectangle(0, 0, 1500, 900);

            //sets screen size
            graphics.PreferredBackBufferWidth = 1500;
            graphics.PreferredBackBufferHeight = 900;
            graphics.ApplyChanges();

            //using external tool to change the color of the fire
            StreamReader ss = new StreamReader("Color.txt");
            string line = ss.ReadLine();
            if (line == "green")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.Green;
                }
            }
            else if (line == "blue")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.Blue;
                }
            }
            else if (line == "pink")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.DeepPink;
                }
            }
            else if (line == "purple")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.BlueViolet;
                }
            }
            else if (line == "gray")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.SlateGray;
                }
            }
            else if (line == "red")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.IndianRed;
                }
            }
            ss.Close();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //sets the self explained textures
            playerTexture = Content.Load<Texture2D>("sprite");
            npcTexture = Content.Load<Texture2D>("person");
            groundTexture = Content.Load<Texture2D>("ground");
            fireTexture = Content.Load<Texture2D>("Enemy");
            waterTex = Content.Load<Texture2D>("Water_1");
            menuTexture = Content.Load<Texture2D>("menu");
            paused = Content.Load<Texture2D>("paused");
            gameover = Content.Load<Texture2D>("gameover");
            won = Content.Load<Texture2D>("victory");
            instructions = Content.Load<Texture2D>("instructions");
            chairTexture = Content.Load<Texture2D>("chair");
            tableTexture = Content.Load<Texture2D>("table");

            //inits the textures
            background = Content.Load<Texture2D>("house2x");
            house.texture = background;

            player.Tex = playerTexture;

            player.waterTex = waterTex;

            foreach (Ground g in glsth)
            {
                g.texture = groundTexture;

            }

            foreach (Ground g in glstv)
            {
                g.texture = groundTexture;
            }

            foreach (Fire f in flst)
            {
                f.FireTexture = fireTexture;
            }
        }

        //UnloadContent will be called once per game and is the place to unload game-specific content.
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            //new keyboard
            kbState = Keyboard.GetState();
            GameState prevState = GameState.menuScreen;

            switch (currentState)
            {
                //press enter on the game screen to play and space for controls
                case GameState.menuScreen:
                    {
                        //go to game
                        if ((SingleKeyPress(Keys.Enter)) == true)
                        {
                            currentState = GameState.gameScreen;
                            player.InGame(true);
                            Reset();
                        }
                        //go to controls screen
                        if ((SingleKeyPress(Keys.Space)) == true)
                        {
                            currentState = GameState.controlScreen;

                        }
                        //exit game
                        if ((SingleKeyPress(Keys.Q)) == true)
                        {
                            this.Exit();
                        }

                    }
                    prevState = GameState.menuScreen;
                    previousState = kbState;
                    break;
                
                //shows controls, hit space to return
                case GameState.controlScreen:                                                                               
                    {
                        if ((SingleKeyPress(Keys.Space)) == true)
                        {
                            currentState = GameState.menuScreen;
                        }
                    }
                    prevState = GameState.controlScreen;
                    previousState = kbState;
                    break;
           
                //will pause the game
                case GameState.pauseScreen:                                                                                              
                    {
                        if ((SingleKeyPress(Keys.Enter)) == true)                                                                              
                        {
                            currentState = GameState.gameScreen;
                        }
                        if ((SingleKeyPress(Keys.Q)) == true)
                        {
                            currentState = GameState.menuScreen;
                        }

                    }
                    prevState = GameState.pauseScreen;
                    previousState = kbState;
                    break;                                                                                                                          

                //the game screen
                case GameState.gameScreen:
                    {                        
                        //opens pause menu
                        if (Keyboard.GetState().IsKeyDown(Keys.P))                                                                                      
                        {
                            currentState = GameState.pauseScreen;                                                                                       
                        }

                        //open quit game screen
                        if (Keyboard.GetState().IsKeyDown(Keys.Q))                                                                                 
                        {
                            currentState = GameState.gameOverScreen;                                                                                       
                        }

                        //if the player isn't grounded, apply gravity                                                                                      
                        if (player.grounded == false)
                        {
                            player.Gravity(player, glsth);                                                          
                        }

                        //player falls when not on platforms
                        player.grounded = false;
                        foreach (Ground g in glsth)
                        {
                            if (player.playerRectangle.Intersects(g.groundRec))
                            {
                                player.grounded = true;
                                player.yVelocity = 0;
                                break;
                            }
                        }

                        //player takes damage from fire
                        foreach (Fire f in flst)
                        {
                            //player collision with fire results in death
                            if (player.playerRectangle.Intersects(f.location))
                            {
                                //player health minus fire damage
                                player.health -= f.damage;

                                if (player.health <= 0)
                                {
                                    //you lost
                                    currentState = GameState.gameOverScreen;
                                }
                            }
                        }

                        //shooting
                        foreach (Fire f in flst)
                        {
                            if (player.isShootingl)
                            {
                                player.Shootingl(f);
                            
                            }
                        }
                        foreach (Fire f in flst)
                        {
                            if (player.isShootingr)
                            {
                                player.Shootingr(f);

                            }
                        }

                        //camera movement
                        camera.Y = player.playerRectangle.Y - 550;
                        camera.X = player.playerRectangle.X - 400;

                        //if player grabs npc, make him go slower and dont draw the npc
                        if (player.playerRectangle.Intersects(damsel.location))
                        {
                            player.carry = true;
                            damsel.stranded = false;
                            //makes the fire respawn
                            ResetFire();
                        }

                        //if player exits the house, you win!
                        if (player.carry && player.playerRectangle.Intersects(wincon))
                        {
                            currentState = GameState.winscreen;
                        }

                        //collisions for the vertical walls
                        foreach (Ground g in glstv)
                        {
                            //if player comes from right
                            if (player.playerRectangle.X > g.groundRec.X)
                            {
                                if (player.playerRectangle.Intersects(g.groundRec))
                                {
                                    while (player.playerRectangle.Intersects(g.groundRec))
                                    {
                                        Rectangle rect = player.playerRectangle;
                                        rect.X += 1;
                                        player.playerRectangle = rect;
                                    }
                                    Rectangle rectt = player.playerRectangle;
                                    rectt.X -= 1;
                                    player.playerRectangle = rectt;
                                }

                                while (player.playerRectangle.Intersects(g.groundRec))
                                {
                                    Rectangle rect = player.playerRectangle;
                                    rect.X += 1;
                                    player.playerRectangle = rect;
                                }
                            }
                            //if player comes from left
                            else if (player.playerRectangle.X < g.groundRec.X)
                            {
                                if (player.playerRectangle.Intersects(g.groundRec))
                                {
                                    while (player.playerRectangle.Intersects(g.groundRec))
                                    {
                                        Rectangle rect = player.playerRectangle;
                                        rect.X -= 1;
                                        player.playerRectangle = rect;
                                    }
                                    Rectangle rectt = player.playerRectangle;
                                    rectt.X += 1;
                                    player.playerRectangle = rectt;
                                }

                                while (player.playerRectangle.Intersects(g.groundRec))
                                {
                                    Rectangle rect = player.playerRectangle;
                                    rect.X -= 1;
                                    player.playerRectangle = rect;
                                }
                            }

                        }
                    }
                    prevState = GameState.gameScreen;
                    previousState = kbState;
                    break;

                //if player wins
                case GameState.winscreen:
                    {
                        if ((SingleKeyPress(Keys.Enter)) == true)
                        {
                            currentState = GameState.menuScreen;
                        }
                        player.grounded = false;
                    }
                    prevState = GameState.winscreen;
                    previousState = kbState;
                    break;

                //display game over screen
                case GameState.gameOverScreen:
                    {
                        if ((SingleKeyPress(Keys.Enter)) == true)                                                                             
                        {
                            currentState = GameState.menuScreen;
                        }
                        if ((SingleKeyPress(Keys.Q)) == true)
                        {
                            currentState = GameState.menuScreen;
                        }
                        player.grounded = false;                                                                                                         
                    }
                    prevState = GameState.gameOverScreen;
                    previousState = kbState;
                    break;

            }//end of switch

            player.processInput();

            base.Update(gameTime);
        }//end of update


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            //draws menu background
            if (currentState == GameState.menuScreen)
            {             
                spriteBatch.Draw(menuTexture, menuRec, Color.White);
            }

            //draws control screen background
            if (currentState == GameState.controlScreen)
            {
                spriteBatch.Draw(instructions,menuRec,Color.White);               
            }                                                                                                                                       

            if (currentState == GameState.gameScreen)
            {
                //draws background
                house.Draw(spriteBatch, new Vector2(-400.0f, -1200.0f), camera, background);

                //draws table and chair (not used)
                //table1.Draw(spriteBatch, tableTexture, camera);
                //chair1.Draw(spriteBatch, chairTexture, camera);
                //chair2.Draw(spriteBatch, chairTexture, camera);

                //draws the ground
                foreach (Ground g in glsth)
                {
                    g.Draw(spriteBatch, g.texture, camera);
                }

                //draws table and chair platforms (unused)
                //foreach (Ground g in glsto)
                //{
                //    g.Draw(spriteBatch, g.texture, camera);
                //}

                //drawing the player, puts a red tint the player if he's touching fire
                player.PlayerColor = Color.White;
                foreach (Fire f in flst)
                {
                    if (player.playerRectangle.Intersects(f.location))
                    {
                        player.PlayerColor = Color.OrangeRed;
                    }
                }
                player.Draw(spriteBatch, camera);

                //draws fire
                foreach (Fire f in flst)
                {
                    f.Draw(spriteBatch, camera);
                }

                //draws water if shooting
                if (player.isShootingl || player.isShootingr)
                {
                    player.water.DrawWater(spriteBatch, waterTex, camera);
                }

                //draws he NCP
                if (damsel.stranded)
                {
                    damsel.Draw(spriteBatch, npcTexture, camera);
                }

            }

            //draws pause screen background
            if (currentState == GameState.pauseScreen)                                                                                  
            {
                spriteBatch.Draw(paused, menuRec, Color.White);
            }

            //draws gameOver screen background
            if (currentState == GameState.gameOverScreen)
            {                      
                spriteBatch.Draw(gameover,menuRec,Color.White);
            }

            //draws victory screen background
            if (currentState == GameState.winscreen)
            {
                spriteBatch.Draw(won, menuRec, Color.White);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }//end of draw

        //if the key is pressed and it goes up it returns true else return false
        bool SingleKeyPress(Keys key)
        {
            if (previousState.IsKeyUp(key) && kbState.IsKeyDown(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //used to reset the game after returning to game menu.  is a copy of init and load methods
        public void Reset()
        {
            IsMouseVisible = true;
            player = new Player(0, 300, 100, 200);
            damsel = new NPC(200, -390, 50, 100);
            wincon = new Rectangle(0, 350, 100, 200);

            //table1 = new Table(1900, 530, 200, 100);
            //chair1 = new Table(190, 140, 120, 175);
            //chair2 = new Table(850, -135, 120, 175);

            house = new House();

            font = Content.Load<SpriteFont>("mainFont");

            //inistialize the two keyboards
            kbState = new KeyboardState();
            previousState = new KeyboardState();

            //makes horizontal ground objects
            ground1 = new Ground(-400, 625, 3075, 20);
            ground2 = new Ground(120, 300, 1750, 20);
            ground3 = new Ground(2100, 300, 550, 20);
            ground4 = new Ground(390, 30, 2250, 20);
            ground5 = new Ground(105, -300, 675, 20);
            ground6 = new Ground(970, -300, 267, 20);
            ground7 = new Ground(105, -530, 1130, 20);
            //tables and chairs
            //ground13 = new Ground(1900, 525, 200, 20);
            //ground14 = new Ground(205, 230, 90, 20);
            //ground15 = new Ground(865, -45, 90, 20);
            //makes vertical ground objects
            ground8 = new Ground(-15, -500, 20, 1000);
            ground9 = new Ground(105, -530, 20, 830);
            ground10 = new Ground(2650, 300, 20, 330);
            ground11 = new Ground(2630, -450, 20, 750);
            ground12 = new Ground(1230, -530, 20, 250);

            //initalizes list of floors
            glsth = new List<Ground>();
            glsth.Add(ground1);
            glsth.Add(ground2);
            glsth.Add(ground3);
            glsth.Add(ground4);
            glsth.Add(ground5);
            glsth.Add(ground6);
            glsth.Add(ground7);

            //inits list of wall objects
            glstv = new List<Ground>();
            glstv.Add(ground8);
            glstv.Add(ground9);
            glstv.Add(ground10);
            glstv.Add(ground11);
            glstv.Add(ground12);

            //glsto = new List<Ground>();
            //glsto.Add(ground13);
            //glsto.Add(ground14);
            //glsto.Add(ground15);      

            //makes fire objects
            //first floor
            fire1 = new Fire(550, 530, 100, 100);
            fire2 = new Fire(570, 400, 100, 100);
            //fire3 = new Fire(150, 340, 100, 100);
            fire4 = new Fire(750, 320, 100, 100);
            fire5 = new Fire(1150, 400, 100, 100);
            fire6 = new Fire(900, 430, 100, 100);
            fire7 = new Fire(1280, 350, 100, 100);
            fire8 = new Fire(1620, 530, 100, 100);
            fire9 = new Fire(1710, 530, 100, 100);
            fire10 = new Fire(1670, 430, 100, 100);
            fire11 = new Fire(1800, 530, 100, 100);
            fire12 = new Fire(1700, 330, 100, 100);
            fire13 = new Fire(2200, 530, 100, 100);
            fire14 = new Fire(2100, 450, 100, 100);
            fire15 = new Fire(2180, 370, 100, 100);
            fire16 = new Fire(2580, 430, 100, 100);
            fire17 = new Fire(2520, 530, 100, 100);
            //second floor
            fire18 = new Fire(2520, 210, 100, 100);
            fire19 = new Fire(2420, 210, 100, 100);
            fire20 = new Fire(2180, 100, 100, 100);
            fire21 = new Fire(1650, 110, 100, 100);
            fire22 = new Fire(1400, 100, 100, 100);
            fire23 = new Fire(1250, 210, 100, 100);
            fire24 = new Fire(1090, 180, 100, 100);
            fire25 = new Fire(950, 80, 100, 100);
            fire26 = new Fire(830, 115, 100, 100);
            fire27 = new Fire(700, 120, 100, 100);
            fire28 = new Fire(550, 210, 100, 100);
            fire29 = new Fire(790, 210, 100, 100);
            fire30 = new Fire(240, 95, 100, 100);
            //third floor
            fire31 = new Fire(420, -125, 100, 100);
            fire32 = new Fire(750, -60, 100, 100);
            fire33 = new Fire(850, -60, 100, 100);
            fire34 = new Fire(2520, -60, 100, 100);
            fire35 = new Fire(2400, -320, 100, 100);
            //forth floor
            fire36 = new Fire(1130, -390, 100, 100);
            fire37 = new Fire(1020, -450, 100, 100);
            fire38 = new Fire(1120, -500, 100, 100);
            fire39 = new Fire(720, -390, 100, 100);
            fire40 = new Fire(460, -450, 100, 100);
            fire41 = new Fire(520, -500, 100, 100);

            //initalizes fire list
            flst = new List<Fire>();
            flst.Add(fire1);
            flst.Add(fire2);
            //flst.Add(fire3);
            flst.Add(fire4);
            flst.Add(fire5);
            flst.Add(fire6);
            flst.Add(fire7);
            flst.Add(fire8);
            flst.Add(fire9);
            flst.Add(fire10);
            flst.Add(fire11);
            flst.Add(fire12);
            flst.Add(fire13);
            flst.Add(fire14);
            flst.Add(fire15);
            flst.Add(fire16);
            flst.Add(fire17);
            flst.Add(fire18);
            flst.Add(fire19);
            flst.Add(fire20);
            flst.Add(fire21);
            flst.Add(fire22);
            flst.Add(fire23);
            flst.Add(fire24);
            flst.Add(fire25);
            flst.Add(fire26);
            flst.Add(fire27);
            flst.Add(fire28);
            flst.Add(fire29);
            flst.Add(fire30);
            flst.Add(fire31);
            flst.Add(fire32);
            flst.Add(fire33);
            flst.Add(fire34);
            flst.Add(fire35);
            flst.Add(fire36);
            flst.Add(fire37);
            flst.Add(fire38);
            flst.Add(fire39);
            flst.Add(fire40);
            flst.Add(fire41);

            //sets camera vector
            camera = new Vector2(0, 0);
            menuRec = new Rectangle(0, 0, 1500, 900);

            //using external tool to change the color of the fire
            StreamReader ss = new StreamReader("Color.txt");
            string line = ss.ReadLine();
            if (line == "green")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.Green;
                }
            }
            else if (line == "blue")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.Blue;
                }
            }
            else if (line == "pink")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.DeepPink;
                }
            }
            else if (line == "purple")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.BlueViolet;
                }
            }
            else if (line == "gray")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.SlateGray;
                }
            }
            else if (line == "red")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.IndianRed;
                }
            }
            ss.Close();

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //sets the self explained textures
            playerTexture = Content.Load<Texture2D>("sprite");
            npcTexture = Content.Load<Texture2D>("person");
            groundTexture = Content.Load<Texture2D>("ground");
            fireTexture = Content.Load<Texture2D>("Enemy");
            waterTex = Content.Load<Texture2D>("Water_1");
            menuTexture = Content.Load<Texture2D>("menu");
            paused = Content.Load<Texture2D>("paused");
            gameover = Content.Load<Texture2D>("gameover");
            won = Content.Load<Texture2D>("victory");
            instructions = Content.Load<Texture2D>("instructions");
            chairTexture = Content.Load<Texture2D>("chair");
            tableTexture = Content.Load<Texture2D>("table");

            //sets the textures
            background = Content.Load<Texture2D>("house2x");
            house.texture = background;

            player.Tex = playerTexture;

            player.waterTex = waterTex;

            foreach (Ground g in glsth)
            {
                g.texture = groundTexture;

            }

            foreach (Ground g in glstv)
            {
                g.texture = groundTexture;
            }

            //foreach (Ground g in glsto)
            //{
            //    g.texture = groundTexture;

            //}

            foreach (Fire f in flst)
            {
                f.FireTexture = fireTexture;
            }
        }

        //used to respawn the fires after reaching the npc
        //copy of init and load for fire objects
        public void ResetFire()
        {
            //makes fire objects
            //first floor
            fire1 = new Fire(550, 530, 100, 100);
            fire2 = new Fire(570, 400, 100, 100);
            fire3 = new Fire(150, 340, 100, 100);
            fire4 = new Fire(750, 320, 100, 100);
            fire5 = new Fire(1150, 400, 100, 100);
            fire6 = new Fire(900, 430, 100, 100);
            fire7 = new Fire(1280, 350, 100, 100);
            fire8 = new Fire(1620, 530, 100, 100);
            fire9 = new Fire(1710, 530, 100, 100);
            fire10 = new Fire(1670, 430, 100, 100);
            fire11 = new Fire(1800, 530, 100, 100);
            fire12 = new Fire(1700, 330, 100, 100);
            fire13 = new Fire(2200, 530, 100, 100);
            fire14 = new Fire(2100, 450, 100, 100);
            fire15 = new Fire(2180, 370, 100, 100);
            fire16 = new Fire(2580, 430, 100, 100);
            fire17 = new Fire(2520, 530, 100, 100);
            //second floor
            fire18 = new Fire(2520, 210, 100, 100);
            fire19 = new Fire(2420, 210, 100, 100);
            fire20 = new Fire(2180, 100, 100, 100);
            fire21 = new Fire(1650, 110, 100, 100);
            fire22 = new Fire(1400, 100, 100, 100);
            fire23 = new Fire(1250, 210, 100, 100);
            fire24 = new Fire(1090, 180, 100, 100);
            fire25 = new Fire(950, 80, 100, 100);
            fire26 = new Fire(830, 115, 100, 100);
            fire27 = new Fire(700, 120, 100, 100);
            fire28 = new Fire(550, 210, 100, 100);
            fire29 = new Fire(790, 210, 100, 100);
            //fire30 = new Fire(240, 95, 100, 100);
            //third floor
            fire31 = new Fire(420, -125, 100, 100);
            fire32 = new Fire(750, -60, 100, 100);
            fire33 = new Fire(850, -60, 100, 100);
            fire34 = new Fire(2520, -60, 100, 100);
            fire35 = new Fire(2400, -320, 100, 100);
            //forth floor
            fire36 = new Fire(1130, -390, 100, 100);
            fire37 = new Fire(1020, -450, 100, 100);
            fire38 = new Fire(1120, -500, 100, 100);
            fire39 = new Fire(720, -390, 100, 100);
            fire40 = new Fire(460, -450, 100, 100);
            fire41 = new Fire(520, -500, 100, 100);

            //initalizes fire list
            flst = new List<Fire>();
            flst.Add(fire1);
            flst.Add(fire2);
            flst.Add(fire3);
            flst.Add(fire4);
            flst.Add(fire5);
            flst.Add(fire6);
            flst.Add(fire7);
            flst.Add(fire8);
            flst.Add(fire9);
            flst.Add(fire10);
            flst.Add(fire11);
            flst.Add(fire12);
            flst.Add(fire13);
            flst.Add(fire14);
            flst.Add(fire15);
            flst.Add(fire16);
            flst.Add(fire17);
            flst.Add(fire18);
            flst.Add(fire19);
            flst.Add(fire20);
            flst.Add(fire21);
            flst.Add(fire22);
            flst.Add(fire23);
            flst.Add(fire24);
            flst.Add(fire25);
            flst.Add(fire26);
            flst.Add(fire27);
            flst.Add(fire28);
            flst.Add(fire29);
            flst.Add(fire30);
            flst.Add(fire31);
            flst.Add(fire32);
            flst.Add(fire33);
            flst.Add(fire34);
            flst.Add(fire35);
            flst.Add(fire36);
            flst.Add(fire37);
            flst.Add(fire38);
            flst.Add(fire39);
            flst.Add(fire40);
            flst.Add(fire41);

            fireTexture = Content.Load<Texture2D>("Enemy 2");

            foreach (Fire f in flst)
            {
                f.FireTexture = fireTexture;
            }

            StreamReader ss = new StreamReader("Color.txt");
            string line = ss.ReadLine();
            if (line == "green")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.Green;
                }
            }
            else if (line == "blue")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.Blue;
                }
            }
            else if (line == "pink")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.DeepPink;
                }
            }
            else if (line == "purple")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.BlueViolet;
                }
            }
            else if (line == "gray")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.SlateGray;
                }
            }
            else if (line == "red")
            {
                foreach (Fire f in flst)
                {
                    f.color = Color.IndianRed;
                }
            }
            ss.Close();
        }

        //game state to tell us which screen to load
        //title screen, the game, controls, gameover, pause, level select
        enum GameState
        {
            menuScreen, gameScreen, controlScreen, gameOverScreen, pauseScreen, winscreen
        }

        //player state to help with sprite drawing
        enum PlayerState
        {
            WalkRight, WalkLeft, FaceRight, FaceLeft, JumpRight, JumpLeft, SwingRight, SwingLeft, ShootRight, ShootLeft
        }


    }//end of class game
}//end of nameSpace