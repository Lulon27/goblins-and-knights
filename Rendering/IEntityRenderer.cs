﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Rendering
{
    internal interface IEntityRenderer
    {
        void DrawEntity(SpriteBatch spriteBatch, GameTime gameTime, Entity entity);
    }
}
