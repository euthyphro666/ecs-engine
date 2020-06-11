using Aphelion.Graphics;
using Aphelion.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aphelion.Domain
{
    public class Level
    {

        public ContentManager Assets;

        public Player Player;
        public Entity[] Nobs;
        
        public int Width;
        public int Height;

        public Level(ContentManager assets)
        {
            Assets = assets;
            Width = 1024;
            Height = 1024;
            Player = new Player(assets);
            Nobs = new Entity[10];
            GenerateLevel();
        }

        public void GenerateLevel()
        {
            var rand = new Random();
            var asteroid = Assets.Load<Texture2D>("Asteroid");
            var star = Assets.Load<Texture2D>("Star");
            var blackHole = Assets.Load<Texture2D>("BlackHole");
            for (int i = 0; i < Nobs.Length; i++)
            {
                var tex = rand.Next(3) switch
                {
                    0 => asteroid,
                    1 => star,
                    _ => blackHole
                };
                var x = (float) rand.NextDouble() * Width;
                var y = (float) rand.NextDouble() * Height;
                Nobs[i] = new Nob(tex, x, y, 32, 32);
            }
        }


        public void Update(GameTime delta, InputManager input)
        {
            Player.Update(delta, input);
        }
        public void Render(GameTime delta, ScreenManager screen)
        {
            for(int i = 0; i < Nobs.Length; i++)
            {
                Nobs[i].Render(screen);
            }
            Player.Render(delta, screen);
        }

        public void Dispose()
        {
        }
    }
}
