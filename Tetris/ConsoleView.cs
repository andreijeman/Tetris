using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class ConsoleView
    {
        public void Draw(DataToDraw data)
        {
            Console.Clear();

            //Border UP
            Console.ForegroundColor = Textures.FieldBorderColor;
            for(int i = 0; i < (data.fieldSize.X + 2) * 2; i++)
            {
                Console.Write(Textures.FieldBorderTexture);
            }

            Console.WriteLine();

            for (int i = data.fieldSize.Y - 1; i >= 0; i--)
            {
                //Border left
                Console.ForegroundColor = Textures.FieldBorderColor;
                Console.Write(Textures.FieldBorderTexture);
                Console.Write(Textures.FieldBorderTexture);

                //Field
                for(int j = 0; j < data.fieldSize.X; j++)
                {
                    Console.ForegroundColor = Textures.PieceColors[data.fieldData[j, i]];
                    Console.Write(Textures.PieceTextures[data.fieldData[j, i]]);
                    Console.Write(Textures.PieceTextures[data.fieldData[j, i]]);
                }

                //Border right
                Console.ForegroundColor = Textures.FieldBorderColor;
                Console.Write(Textures.FieldBorderTexture);
                Console.Write(Textures.FieldBorderTexture);

                Console.WriteLine();
            }

            // Border Down
            Console.ForegroundColor = Textures.FieldBorderColor;
            for (int i = 0; i < (data.fieldSize.X + 2) * 2; i++)
            {
                Console.Write(Textures.FieldBorderTexture);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Score: " + data.playerScore);
        }

    }
}
