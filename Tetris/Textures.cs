using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public static class Textures
    {
        public static readonly Dictionary<PieceInfo, Char> PieceTextures = new Dictionary<PieceInfo, Char>
        {
            { new PieceInfo(PieceType.None, PieceState.None), ' ' },
            { new PieceInfo(PieceType.O, PieceState.Blocked), '█' },
            { new PieceInfo(PieceType.I, PieceState.Blocked), '█' },
            { new PieceInfo(PieceType.T, PieceState.Blocked), '█' },
            { new PieceInfo(PieceType.S, PieceState.Blocked), '█' },
            { new PieceInfo(PieceType.Z, PieceState.Blocked), '█' },
            { new PieceInfo(PieceType.L, PieceState.Blocked), '█' },
            { new PieceInfo(PieceType.J, PieceState.Blocked), '█' },
            
            { new PieceInfo(PieceType.O, PieceState.InMotion), '█' },
            { new PieceInfo(PieceType.I, PieceState.InMotion), '█' },
            { new PieceInfo(PieceType.T, PieceState.InMotion), '█' },
            { new PieceInfo(PieceType.S, PieceState.InMotion), '█' },
            { new PieceInfo(PieceType.Z, PieceState.InMotion), '█' },
            { new PieceInfo(PieceType.L, PieceState.InMotion), '█' },
            { new PieceInfo(PieceType.J, PieceState.InMotion), '█' },
        };

        public static readonly Dictionary<PieceInfo, ConsoleColor> PieceColors = new Dictionary<PieceInfo, ConsoleColor>
        {
            { new PieceInfo(PieceType.None, PieceState.None), ConsoleColor.Black },
            { new PieceInfo(PieceType.O, PieceState.Blocked), ConsoleColor.Yellow },
            { new PieceInfo(PieceType.I, PieceState.Blocked), ConsoleColor.Cyan },
            { new PieceInfo(PieceType.T, PieceState.Blocked), ConsoleColor.Magenta },
            { new PieceInfo(PieceType.S, PieceState.Blocked), ConsoleColor.Green },
            { new PieceInfo(PieceType.Z, PieceState.Blocked), ConsoleColor.Red },
            { new PieceInfo(PieceType.L, PieceState.Blocked), ConsoleColor.DarkYellow },
            { new PieceInfo(PieceType.J, PieceState.Blocked), ConsoleColor.Blue },

            { new PieceInfo(PieceType.O, PieceState.InMotion), ConsoleColor.Yellow },
            { new PieceInfo(PieceType.I, PieceState.InMotion), ConsoleColor.Cyan },
            { new PieceInfo(PieceType.T, PieceState.InMotion), ConsoleColor.Magenta },
            { new PieceInfo(PieceType.S, PieceState.InMotion), ConsoleColor.Green },
            { new PieceInfo(PieceType.Z, PieceState.InMotion), ConsoleColor.Red },
            { new PieceInfo(PieceType.L, PieceState.InMotion), ConsoleColor.DarkYellow },
            { new PieceInfo(PieceType.J, PieceState.InMotion), ConsoleColor.Blue },
        };


        public const char FieldBorderTexture = '█';
        public const ConsoleColor FieldBorderColor = ConsoleColor.White;
        
    }
}
