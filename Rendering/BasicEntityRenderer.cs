using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Rendering
{
    internal class BasicEntityRenderer : IEntityRenderer
    {

        const int TileSize = 256;
        const int camX = 100;
        const int camY = 100;
        public void DrawEntity(Viewport viewport, SpriteBatch spriteBatch, GameTime gameTime, Entity entity)
        {
            spriteBatch.Draw(entity.SpriteSheet.Texture, new Rectangle((int)(-camX + entity.Position.X),(int)(-camY + entity.Position.Y), (int)(entity.Scale * TileSize), (int)(entity.Scale * TileSize)), Color.White);
            Console.WriteLine("aa");
        }
    }
}
