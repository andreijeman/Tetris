using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Piece
    {
        private Point _position;

        private List<Point[]> _blueprints;
        private int _currentBlueprintIndex;
        public PieceType Type { get; private set; }

        private (Point, int) _lastState;

        public Point Position
        {
            get { return _position; }
            set { _lastState.Item1 = _position; _position = value; }
        }


        public Piece(PieceType type = PieceType.T)
        {
            Type = type;
            _blueprints = PiecesBlueprints.PieceTypeToBlueprints[Type];
        }

        public Point[] GetTransformedBlueprint()
        {
            Point[] result = (Point[])_blueprints[_currentBlueprintIndex].Clone();
            for(int i = 0; i < result.Length; i++)
            {
                result[i].X += _position.X;
                result[i].Y += _position.Y;
            }

            return result;
        }

        public void Move(Movement movement)
        {
            _lastState = (_position, _currentBlueprintIndex);
            switch (movement)
            {
                case Movement.Left:
                    _position.X--;
                    break;

                case Movement.Right:
                    _position.X++;
                    break;

                case Movement.Down:
                    _position.Y--;
                    break;

                case Movement.Up:
                    _position.Y++;
                    break;

                case Movement.TurnRight:
                    _currentBlueprintIndex++;
                    if (_currentBlueprintIndex >= _blueprints.Count)
                    {
                        _currentBlueprintIndex = 0;
                    }
                    break;

                case Movement.TurnLeft:
                    _currentBlueprintIndex--;
                    if (_currentBlueprintIndex < 0)
                    {
                        _currentBlueprintIndex = _blueprints.Count - 1;
                    }
                    break;

                default:
                    break;
            }
        }
        public void SetRandomPieceType()
        {
            var rand = new Random();
            Type = (PieceType)rand.Next(1, 8);
            _blueprints =  PiecesBlueprints.PieceTypeToBlueprints[Type];
        }

        public void ResetLastState()
        {
            _position = _lastState.Item1;
            _currentBlueprintIndex = _lastState.Item2;
        }
    }
}

         