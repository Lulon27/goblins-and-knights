using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Animation
{
    public class SpriteSheet
    {
        public enum AnimationDirection
        {
            // The numbers are important
            Vertical = 0,
            Horizontal = 1
        }

        public readonly string TexturePath;
        public Texture2D Texture { get; private set; }

        public SpriteSheet(string texturePath)
        {
            TexturePath = texturePath;
        }

        public void Load(ContentManager contentManager)
        {
            Texture = contentManager.Load<Texture2D>(TexturePath);
        }

        public Animation Animation(int x, int y, int width, int height, int numFrames, AnimationDirection direction = AnimationDirection.Horizontal)
        {
            return new Animation(this, new Rectangle(x, y, width, height), numFrames, direction);
        }
    }
}
