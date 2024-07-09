using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public struct PieceInfo
    {
        public PieceType type;
        public PieceState state;

        public PieceInfo(PieceType type, PieceState state)
        {
            this.type = type;
            this.state = state;
        }
    }

    public struct DataToDraw
    {
        public PieceInfo[,] fieldData;
        public Point fieldSize;
        public string playerName;
        public int playerScore;
    }
}
