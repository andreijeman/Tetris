using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tetris
{
    public class Field
    {
        public Point Size { get; }

        public PieceInfo[,] Data { get; private set; }

        public Field(Point? size = null)
        {
            Size = size ?? new Point(Settings.FieldWidth, Settings.FieldHeight);
            Data = new PieceInfo[Size.X, Size.Y];
            
        }

        public void SetData(PieceType pieceType, PieceState pieceState, params Point[] points)
        {
            foreach (var point in points)
            {
                if (IsInField(point))
                {
                    Data[point.X, point.Y].type = pieceType;
                    Data[point.X, point.Y].state = pieceState;
                }
            }
        }

        public void EraseData(params Point[] points)
        {
            foreach (var point in points)
            {
                if (IsInField(point))
                {
                    Data[point.X, point.Y].type = PieceType.None;
                    Data[point.X, point.Y].state = PieceState.None;
                }
            }
        }

        public bool IsEmpty(params Point[] points)
        {
            foreach(var point in points)
            {
                if (!IsInField(point)) return false;
                else if (Data[point.X, point.Y].type != PieceType.None) return false;
            }
            return true;
        }

        public void MoveLinesDown(int line, int moveDownWith)
        {

            for(int x  = 0; x < Size.X; x++)
            {
                for (int y = line; y < Size.Y - 1; y++)
                {
                    Data[x, y - moveDownWith] = Data[x, y];
                }
            }
            
        }

        public int EraseCompletedLines(int fromLine, int toLine)
        {
            fromLine = fromLine < 0 ? 0 : fromLine >= Size.Y ? Size.Y - 1 : fromLine;
            toLine = toLine < 0 ? 0 : toLine >= Size.Y ? Size.Y - 1 : toLine;

            int erasedLinesNum = 0;

            int moveDownWith = 0;
            while (fromLine <= toLine)
            {
                if (IsLineCompleted(fromLine))
                {
                    moveDownWith++;
                    fromLine++;
                }
                else if (moveDownWith > 0)
                {
                    MoveLinesDown(fromLine, moveDownWith);
                    toLine -= moveDownWith;
                    erasedLinesNum += moveDownWith;
                    moveDownWith = 0;
                }
                else fromLine++;
            }

            return erasedLinesNum;
        }

        public bool IsLineCompleted(int line)
        {
            for (int i = 0; i < Size.X; i++)
            {
                if (Data[i, line].type == PieceType.None) return false;
            }

            return true;
        }

        private bool IsInField(Point point) => point.X >= 0 && point.X < Size.X && point.Y >= 0 && point.Y < Size.Y;
    }
}
