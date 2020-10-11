using System;
using System.Collections.Generic;
using System.Text;

using MonopolyPreUnity.Classes;

namespace MonopolyPreUnity.Managers
{
    class MapManager
    {
        private LinkedList<Tile> map { get;  }

        public MapManager()
        {
            BuildMap();
        }

        public void BuildMap()
        {
            throw new NotImplementedException();
        }

        public void MoveToTile(Tile tile, int steps)
        {
            throw new NotImplementedException();
        }

        public void MoveToTile(Tile tileStart, Tile tileEnd)
        {
            throw new NotImplementedException();
        }

    
    }
}
