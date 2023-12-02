using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W.Games
{
    public class WTicTacToe
    { 
        public bool yourMove { get; private set; }
        private bool gamePlaying;
        private int winner = 0;
        public readonly int[,] checkSquere =
        {
            { 2,7,6},
            { 9,5,1},
            { 4,3,8} //15
        };
        private char[,] moved =
        {
            {' ',' ',' '},
            {' ',' ',' '},
            {' ',' ',' '}
        };
        private char pcChar = 'O';
        private char usrChar = 'X';

        public WTicTacToe(bool urMove = true)
        {
            //┼ ─ │
            yourMove = urMove;
        }
        public void StartGame()
        {
            gamePlaying = true;

            UpdateBoard();
            while (gamePlaying)
            {
                switch (yourMove)
                {
                    case true:
                        UserMove();
                        break;
                    case false:
                        PCMove();
                        break;
                }
                UpdateBoard();
                yourMove = !yourMove;
                if(winner != 0)
                {
                    gamePlaying = false;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
                var winText = winner == 1 ? "You won the game!" : "Computer won the game!";
            Console.WriteLine(winText);
            Console.ResetColor();
        }
        private void UserMove()
        {
        tryMakeMove:
            try
            {
                int y = int.Parse(WConsole.ReadLine("Podaj wiersz (1-3): "));
                int x = int.Parse(WConsole.ReadLine("Podaj kolumne (1-3): "));
                if (x < 1 || x > 3 ||
                y > 3 || y < 1 ||
                moved[y - 1, x - 1] != ' ')
                    goto tryMakeMove;

                moved[y - 1, x - 1] = usrChar;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(e.Message);
                Console.ResetColor();
                goto tryMakeMove;
            }
            WinCheck();
        }
        private void PCMove()
        {
            Thread.Sleep(250);
            Random rnd = new Random();
        tryMakeMove:
            int y = rnd.Next(0, 3);
            int x = rnd.Next(0, 3);

            if (moved[y, x] != ' ')
                goto tryMakeMove;
            moved[y, x] = pcChar;
            WinCheck();
        }
        private void WinCheck()
        {
            int[,] tempPc = new int[3, 3];
            int[,] tempUsr = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (moved[i, j] == 'X')
                        tempUsr[i, j] = checkSquere[i, j];
                    else if (moved[i, j] == 'O')
                        tempPc[i, j] = checkSquere[i, j];
                }
            if (tempPc[0, 0] + tempPc[0, 1] + tempPc[0, 2] == 15 ||
                tempPc[1, 0] + tempPc[1, 1] + tempPc[1, 2] == 15 ||
                tempPc[2, 0] + tempPc[2, 1] + tempPc[2, 2] == 15 ||
                tempPc[0, 0] + tempPc[1, 0] + tempPc[2, 0] == 15 ||
                tempPc[0, 1] + tempPc[1, 1] + tempPc[2, 1] == 15 ||
                tempPc[0, 2] + tempPc[1, 2] + tempPc[2, 2] == 15 ||
                tempPc[0, 0] + tempPc[1, 1] + tempPc[2, 2] == 15 ||
                tempPc[2, 0] + tempPc[1, 1] + tempPc[0, 2] == 15)
                winner = 2;
            else if (tempUsr[0, 0] + tempUsr[0, 1] + tempUsr[0, 2] == 15 ||
                tempUsr[1, 0] + tempUsr[1, 1] + tempUsr[1, 2] == 15 ||
                tempUsr[2, 0] + tempUsr[2, 1] + tempUsr[2, 2] == 15 ||
                tempUsr[0, 0] + tempUsr[1, 0] + tempUsr[2, 0] == 15 ||
                tempUsr[0, 1] + tempUsr[1, 1] + tempUsr[2, 1] == 15 ||
                tempUsr[0, 2] + tempUsr[1, 2] + tempUsr[2, 2] == 15 ||
                tempUsr[0, 0] + tempUsr[1, 1] + tempUsr[2, 2] == 15 ||
                tempUsr[2, 0] + tempUsr[1, 1] + tempUsr[0, 2] == 15)
                winner = 1;
        }
        private void UpdateBoard()
        {
            Console.Clear();
            Console.WriteLine($"{moved[0,0]}│{moved[0,1]}│{moved[0,2]}");
            Console.WriteLine($"─┼─┼─");
            Console.WriteLine($"{moved[1, 0]}│{moved[1, 1]}│{moved[1, 2]}");
            Console.WriteLine($"─┼─┼─");
            Console.WriteLine($"{moved[2, 0]}│{moved[2, 1]}│{moved[2, 2]}");
        }
    }
}
