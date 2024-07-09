using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris
{
    public class Tetris
    {
        //Can be more unitManagers and they can contain the same field, controller or player. 
        //It means relation between field - player - controller can be many to many (at least it should)
        
        private List<UnitManager> _unitManagers = new List<UnitManager>();

        private ConsoleView _consoleView;

        private Stopwatch _stopwatch;

        public Tetris()
        {
            _unitManagers.Add(new UnitManager());
            _consoleView = new ConsoleView();
            _stopwatch = new Stopwatch();
        }

        public void Run()
        {
            _stopwatch.Start();
            while (true)
            {
                for (int i = 0; i < _unitManagers.Count; i++)
                {
                    if (_unitManagers[i].Process() == false)
                    {
                        _unitManagers[i] = new UnitManager();
                    }
                }

                if(_stopwatch.Elapsed.TotalMilliseconds > 1000/Settings.Fps)
                {
                    foreach (UnitManager unit in _unitManagers) _consoleView.Draw(unit.GetDataToDraw());
                    _stopwatch.Restart();
                }
            }
        }
    }
}
