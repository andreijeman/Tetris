using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Controller
    {
        private ConsoleKey _moveLeft;
        private ConsoleKey _moveRight;
        private ConsoleKey _moveDown;
        private ConsoleKey _fall;
        private ConsoleKey _rotate;

        public Controller(
            ConsoleKey moveLeft = Settings.MoveLeftKey, 
            ConsoleKey moveRight = Settings.MoveRightKey,
            ConsoleKey moveDown = Settings.MoveDownKey,
            ConsoleKey fall = Settings.FallKey,
            ConsoleKey rotate = Settings.RotateKey)
        {
            _moveLeft = moveLeft;
            _moveRight = moveRight;
            _moveDown = moveDown;
            _fall = fall;
            _rotate = rotate;
        }

        public Action GetAction()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == _moveLeft) return Action.MoveLeft;
                if (key == _moveRight) return Action.MoveRight;
                if (key == _moveDown) return Action.MoveDown;
                if (key == _fall) return Action.Fall;
                if (key == _rotate) return Action.TurnRight;
            }
            return Action.None;
        }
    }
}
