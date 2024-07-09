using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{

    public enum PieceType
    {
        None, 
        O, I, T, S, Z, L, J
    }

    public enum PieceState
    {
        None,
        Blocked, RecentlyBlocked, InMotion, Projected
    }

    public enum Movement
    {
        None,
        Left,
        Right,
        Down,
        Up,
        TurnRight,
        TurnLeft
    }
    public enum Action
    {
        None,
        MoveLeft,
        MoveRight,
        MoveDown,
        Fall,
        TurnRight
    }

}
