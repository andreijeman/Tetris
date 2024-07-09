using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class UnitManager
    {
        private Player _player;
        private Controller _controller;
        private Field _field;

        private int _defaultMotionTimeExecution;

        private Piece _piece;
        private Point _pieceInitPos;

        private Stopwatch _stopwatch;

        public UnitManager(Player player = null, Controller controller = null, Field field = null, Point? pieceInitPos = null)
        {
            _player = player ?? new Player();
            _controller = controller ?? new Controller();
            _field = field ?? new Field();

            _defaultMotionTimeExecution = Settings.InitDefaultMotionTimeExecution;
            _stopwatch = new Stopwatch();

            _pieceInitPos = pieceInitPos ?? new Point(Settings.PieceInitialOriginX, Settings.PieceInitialOriginY);

            _piece = new Piece();
            _piece.SetRandomPieceType();
            _piece.Position = _pieceInitPos;
        }

        public bool Process()
        {
            _stopwatch.Start();

            _field.EraseData(_piece.GetTransformedBlueprint());

            if (ProcessAction() && ProcessDefaultMotion())
            {
                _field.SetData(_piece.Type, PieceState.InMotion, _piece.GetTransformedBlueprint());
            }
            else
            {
                _field.SetData(_piece.Type, PieceState.Blocked, _piece.GetTransformedBlueprint());
                _player.Score += _field.EraseCompletedLines(_piece.Position.Y, _piece.Position.Y + PiecesBlueprints.BlueprintHeight);
                _piece.SetRandomPieceType();
                _piece.Position = _pieceInitPos;

                if (!_field.IsEmpty(_piece.GetTransformedBlueprint())) return false;
            }



            _stopwatch.Stop();

            return true;
        }

        

        private bool ProcessAction()
        {
            bool isBlocked = false;
            switch (_controller.GetAction())
            {
                case Action.MoveLeft: _piece.Move(Movement.Left); break;
                case Action.MoveRight: _piece.Move(Movement.Right); break;
                case Action.MoveDown: _piece.Move(Movement.Down); break;
                case Action.TurnRight: _piece.Move(Movement.TurnRight); break;
                case Action.Fall:
                    isBlocked = true;
                    while (_field.IsEmpty(_piece.GetTransformedBlueprint()))
                        _piece.Move(Movement.Down);
                    break;
            }

            if(!_field.IsEmpty(_piece.GetTransformedBlueprint()))
            {
                _piece.ResetLastState();
            }

            return !isBlocked;
        }

        private bool ProcessDefaultMotion()
        {
            bool isBlocked = false;
            int elapsed = (int)_stopwatch.Elapsed.TotalMilliseconds;
            if (elapsed >= _defaultMotionTimeExecution) _stopwatch.Reset();

            while (elapsed >= _defaultMotionTimeExecution)
            {
                elapsed -= _defaultMotionTimeExecution;
                _piece.Move(Movement.Down);
                if(!_field.IsEmpty(_piece.GetTransformedBlueprint()))
                {
                    _piece.ResetLastState();
                    isBlocked = true;
                }
            }

            return !isBlocked;
        }

        public DataToDraw GetDataToDraw()
        {
            return new DataToDraw()
            {
                fieldData = _field.Data,
                fieldSize = _field.Size,
                playerName = _player.Name,
                playerScore = _player.Score
            };
        }
    }
}
