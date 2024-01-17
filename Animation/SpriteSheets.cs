using Microsoft.Xna.Framework.Content;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Animation
{
    public static class SpriteSheets
    {
        // Sprite sheets and animations list

        public static class Knight
        {
            public static readonly SpriteSheet SpriteSheet = AddSpriteSheet("Factions/Knights/Troops/Warrior/Blue/Warrior_Blue");
            public static readonly Animation Idle = SpriteSheet.Animation(0, 0, 192, 192, 2);
        }

        // Internal

        private static readonly List<SpriteSheet> _allSpriteSheets = new List<SpriteSheet>();

        private static SpriteSheet AddSpriteSheet(string texturePath)
        {
            var s = new SpriteSheet(texturePath);
            _allSpriteSheets.Add(s);
            return s;
        }

        public static void Init()
        {
            Type[] types = typeof(SpriteSheets).GetNestedTypes();
            foreach (var type in types)
            {
                System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(type.TypeHandle);
            }
        }

        public static void Load(ContentManager content)
        {
            foreach (var s in _allSpriteSheets)
            {
                s.Load(content);
            }
        }
    }
}
