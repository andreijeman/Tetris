using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public static class Settings
    {
        public const int FieldWidth = 10;
        public const int FieldHeight = 20;

        public const ConsoleKey MoveLeftKey = ConsoleKey.LeftArrow;
        public const ConsoleKey MoveRightKey = ConsoleKey.RightArrow;
        public const ConsoleKey MoveDownKey = ConsoleKey.DownArrow;
        public const ConsoleKey RotateKey = ConsoleKey.UpArrow;
        public const ConsoleKey FallKey = ConsoleKey.Spacebar;

        public const int PieceInitialOriginX = (FieldWidth / 2) - PiecesBlueprints.BlueprintWidth / 2;
        public const int PieceInitialOriginY = (FieldHeight - 1) - PiecesBlueprints.BlueprintHeight;

        public const string PlayerName = "Player";

        public const int InitDefaultMotionTimeExecution = 400;

        public const int Fps = 20;

    }
}
