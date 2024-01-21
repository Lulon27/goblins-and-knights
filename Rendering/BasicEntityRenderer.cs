using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Animation;

namespace TestGame.Rendering
{
    internal class BasicEntityRenderer : IEntityRenderer
    {
        const int TileSize = 128;
        const int camX = 0;
        const int camY = 0;
        public void DrawEntity(SpriteBatch spriteBatch, GameTime gameTime, Entity entity)
        {
            if(entity.SpriteSheet.Texture == null)
            {
                return;
            }

            // Center of screen in pixel coords
            float centerX = spriteBatch.GraphicsDevice.Viewport.Width * 0.5f;
            float centerY = spriteBatch.GraphicsDevice.Viewport.Height * 0.5f;

            // Offset from center in world coords
            // Position the entity at the center with the center
            float renderOffsetX = -entity.Scale * 0.5f;
            float renderOffsetY = entity.Scale * 0.5f;

            // Move entity according to entity and camera position
            renderOffsetX += -camX + entity.Position.X;
            renderOffsetY += -camY + entity.Position.Y;

            // Actual render position in pixel coords
            float x = centerX + renderOffsetX * TileSize;
            float y = centerY - renderOffsetY * TileSize;
            float size = entity.Scale * TileSize;

            Animation.Animation currentAnimation = SpriteSheets.Knight.Idle;

            Rectangle frameBounds = currentAnimation.getFrameBounds(0);

            spriteBatch.Draw(entity.SpriteSheet.Texture, new Rectangle((int)x, (int)y, (int)size, (int)size), frameBounds, Color.White);
        }
    }
}
