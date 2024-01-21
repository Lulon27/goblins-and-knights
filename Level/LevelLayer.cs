using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    internal class LevelLayer
    {
        private Tile[] _tiles;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public LevelLayer(int width, int height)
        {
            _tiles = new Tile[width * height];
        }

        public Tile getTile(int x, int y)
        {
            return _tiles[y * Width + x];
        }

        public void setTile(Tile tile, int x, int y)
        {
            _tiles[y * Width + x] = tile;
        }
    }
}
