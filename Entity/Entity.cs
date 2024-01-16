using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using TestGame.Animation;
using TestGame.Rendering;

namespace TestGame
{
    internal class Entity
    {
        //Renderer
        public IEntityRenderer Renderer { get; set; }

        public SpriteSheet SpriteSheet { get; set; }

        public Vector2 Position { get; set; }
        public Vector2 BBSize { get; set; }
        public float Scale { get; set; } = 1;


        public virtual void OnUpdate(GameTime gameTime)
        {
            Console.WriteLine(gameTime.ElapsedGameTime.TotalSeconds);
        }

        public virtual void OnInit()
        {

        }

        public virtual void OnDelete()
        {

        }
    }

    internal class Buildings : Entity
    {

    }

    internal class MovingObject : Entity
    {

    }

    internal class Character : MovingObject
    {

    }

    internal class Player : MovingObject
    {

    }
}