using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Rendering;

namespace TestGame
{
    internal class Level
    {

        private List<Entity> _entities = new List<Entity>();
        public Level() { }

        public void Update(GameTime gameTime)
        {
            foreach (Entity entity in _entities)
            {
                entity.OnUpdate(gameTime);
            }
        }

        public void Draw(Viewport viewport, SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (Entity entity in _entities)
            {
                if(entity.Renderer == null)
                {
                    continue;
                }
                entity.Renderer.DrawEntity(viewport, spriteBatch, gameTime, entity);
            }
        }

        public void AddEntity(Entity entity)
        {
            entity.Renderer = new BasicEntityRenderer();
            entity.OnInit();
            _entities.Add(entity);
        }
    }
}
