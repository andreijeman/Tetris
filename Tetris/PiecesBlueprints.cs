using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public static partial class PiecesBlueprints
    {
        public const int BlueprintWidth = 4;
        public const int BlueprintHeight = 4;

        public static readonly Dictionary<PieceType, List<Point[]>> PieceTypeToBlueprints = new Dictionary<PieceType, List<Point[]>>
        {
            {
                PieceType.O,
                new List<Point[]>
                {
                    new Point[]{ new Point(1, 1), new Point(2, 1), new Point(1, 2), new Point(2, 2) },
                    new Point[]{ new Point(1, 1), new Point(2, 1), new Point(1, 2), new Point(2, 2) },
                    new Point[]{ new Point(1, 1), new Point(2, 1), new Point(1, 2), new Point(2, 2) },
                    new Point[]{ new Point(1, 1), new Point(2, 1), new Point(1, 2), new Point(2, 2) }
                }
            },

            {
                PieceType.I,
                new List<Point[]>
                {
                    new Point[] { new Point(0, 2), new Point(1, 2), new Point(2, 2), new Point(3, 2) },
                    new Point[] { new Point(2, 0), new Point(2, 1), new Point(2, 2), new Point(2, 3) },
                    new Point[] { new Point(0, 1), new Point(1, 1), new Point(2, 1), new Point(3, 1) },
                    new Point[] { new Point(1, 0), new Point(1, 1), new Point(1, 2), new Point(1, 3) }
                }
            },

            {
                PieceType.T,
                new List<Point[]>
                {
                    new Point[] { new Point(0, 2), new Point(1, 2), new Point(2, 2), new Point(1, 3) },
                    new Point[] { new Point(1, 1), new Point(1, 2), new Point(2, 2), new Point(1, 3) },
                    new Point[] { new Point(1, 1), new Point(0, 2), new Point(1, 2), new Point(2, 2) },
                    new Point[] { new Point(1, 1), new Point(0, 2), new Point(1, 2), new Point(1, 3) }
                }
            },

            {
                PieceType.S,
                new List<Point[]>
                {
                    new Point[] { new Point(0, 2), new Point(1, 2), new Point(1, 3), new Point(2, 3) },
                    new Point[] { new Point(2, 1), new Point(1, 2), new Point(2, 2), new Point(1, 3) },
                    new Point[] { new Point(0, 1), new Point(1, 1), new Point(1, 2), new Point(2, 2) },
                    new Point[] { new Point(1, 1), new Point(0, 2), new Point(1, 2), new Point(0, 3) }
                }
            },

            {
                PieceType.Z,
                new List<Point[]>
                {
                    new Point[] { new Point(1, 2), new Point(2, 2), new Point(0, 3), new Point(1, 3) },
                    new Point[] { new Point(1, 1), new Point(1, 2), new Point(2, 2), new Point(2, 3) },
                    new Point[] { new Point(1, 1), new Point(2, 1), new Point(0, 2), new Point(1, 2) },
                    new Point[] { new Point(0, 1), new Point(0, 2), new Point(1, 2), new Point(1, 3) }
                }
            },

            {
                PieceType.L,
                new List<Point[]>
                {
                    new Point[] { new Point(0, 2), new Point(1, 2), new Point(2, 2), new Point(2, 3) },
                    new Point[] { new Point(1, 1), new Point(2, 1), new Point(1, 2), new Point(1, 3) },
                    new Point[] { new Point(0, 1), new Point(0, 2), new Point(1, 2), new Point(2, 2) },
                    new Point[] { new Point(1, 1), new Point(1, 2), new Point(0, 3), new Point(1, 3) }
                }
            },

            {
                PieceType.J,
                new List<Point[]>
                {
                    new Point[] { new Point(0, 2), new Point(1, 2), new Point(2, 2), new Point(0, 3) },
                    new Point[] { new Point(1, 1), new Point(1, 2), new Point(1, 3), new Point(2, 3) },
                    new Point[] { new Point(2, 1), new Point(0, 2), new Point(1, 2), new Point(2, 2) },
                    new Point[] { new Point(0, 1), new Point(1, 1), new Point(1, 2), new Point(1, 3) }
                }
            }
        };
    }
}
