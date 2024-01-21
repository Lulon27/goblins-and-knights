using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Threading;
using TestGame.Animation;
using TestGame.Rendering;

namespace TestGame
{
    public enum BoundingShape
    {
        Rectangle,
        Circle
    }

    internal class BoundingBox
    {
        private BoundingShape shape;

        private Rectangle rectangle;

        private Vector2 center;
        private float radius;

        public BoundingBox(BoundingShape shape, Rectangle rectangle)
        {
            this.shape = shape;
            this.rectangle = rectangle;
        }

        public BoundingBox(BoundingShape shape, Vector2 center, float radius)
        {
            if (shape != BoundingShape.Circle)
            {
                throw new ArgumentException("Invalid shape for circle-specific constructor");
            }

            this.shape = shape;
            this.center = center;
            this.radius = radius;
        }

        public bool Intersects(BoundingBox other)
        {
            switch (shape)
            {
                case BoundingShape.Rectangle:
                    return RectangleIntersects(other.rectangle);
                case BoundingShape.Circle:
                    return CircleIntersects(other.center, other.radius);
                default:
                    throw new InvalidOperationException("Invalid bounding shape");
            }
        }

        private bool RectangleIntersects(Rectangle otherRectangle)
        {
            return rectangle.Intersects(otherRectangle);
        }

        private bool CircleIntersects(Vector2 otherCenter, float otherRadius)
        {
            float distance = Vector2.Distance(center, otherCenter);
            return distance < radius + otherRadius;
        }
    }

    internal class Entity
    {

        public int ID { get; }

        //Renderer
        public IEntityRenderer Renderer { get; set; }

        public SpriteSheet SpriteSheet { get; set; }

        public Vector2 Position { get; set; }
        public Vector2 BBSize { get; set; }
        public float Scale { get; set; } = 1;

        private static int lastId = 0;

        public Entity() {
            this.ID = generateID();
        }

        private static int generateID()
        {
            return Interlocked.Increment(ref lastId);
        }

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