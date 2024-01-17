using Microsoft.Xna.Framework;
using static TestGame.Animation.SpriteSheet;

namespace TestGame.Animation
{
    public class Animation
    {
        public readonly SpriteSheet SpriteSheet;

        public readonly Rectangle FirstFrameBounds;

        public readonly int NumFrames;

        public readonly AnimationDirection Direction;

        public Animation(SpriteSheet spriteSheet, Rectangle firstFrameBounds, int numFrames, AnimationDirection direction = AnimationDirection.Horizontal)
        {
            SpriteSheet = spriteSheet;
            FirstFrameBounds = firstFrameBounds;
            NumFrames = numFrames;
            Direction = direction;
        }

        public Rectangle getFrameBounds(int frameNumber)
        {
            int x = FirstFrameBounds.X + frameNumber * FirstFrameBounds.Width * (int)Direction;
            int y = FirstFrameBounds.Y + frameNumber * FirstFrameBounds.Height * (int)Direction;
            return new Rectangle(x, y, FirstFrameBounds.Width, FirstFrameBounds.Height);
        }
    }
}
