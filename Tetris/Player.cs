using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Player
    {
        public int Score { get; set; }
        public string Name { get; set; }
      
        public Player(string name = Settings.PlayerName)
        {
            Name = name;
        }

    }
}
