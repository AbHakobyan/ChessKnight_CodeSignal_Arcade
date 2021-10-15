using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessKnight_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "g8";
            int x = chessKnight(st);
            Console.WriteLine(x);
        }

        static int chessKnight(string cell)
        {
            int[] arr = new int[8];
            string[] arr2 = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            string s = "";
            int countw = 0;
            int countd = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                countw++;
                for (int j = 1; j <= arr.Length; j++)
                {
                    countd++;
                    s = arr2[i] + j.ToString();
                    if (cell == s)
                    {
                        if ((countw == 1 && (countd == 1 || countd == 8)) || (countw == 8 && (countd == 1 || countd == 8)))
                        {
                            return 2;
                        }
                        else if ((countw == 1 && (countd == 2 || countd == 7)) || (countw == 2 && (countd == 1 || countd == 8)) ||
                                (countw == 7 && (countd == 1 || countd == 8)) || (countw == 8 && (countd == 2 || countd == 7)))
                        {
                            return 3;
                        }
                        else if ((countw == 1 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)) || (countw == 8 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)) || (countw == 3 && (countd == 1)) || (countw == 4 && (countd == 1)) || (countw == 5 && (countd == 1)) ||
                        (countw == 6 && (countd == 1)) || (countw == 3 && (countd == 8)) || (countw == 4 && (countd == 8)) || (countw == 5 && (countd == 8)) || (countw == 6 && (countd == 8)) || (countw == 2 && (countd == 2 || countd == 7)) || (countw == 7 && (countd == 2 || countd == 7)))
                        {
                            return 4;
                        }
                        else if ((countw == 2 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)) || (countw == 7 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)) || (countw == 5 && (countd == 2 || countd == 7)) || (countw == 6 && (countd == 2 || countd == 7)) ||
                        (countw == 3 && (countd == 2 || countd == 7)) || (countw == 4 && (countd == 2 || countd == 7)))
                        {
                            return 6;
                        }
                        else if ((countw == 3 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)) || (countw == 4 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)) ||
                        (countw == 5 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)) || (countw == 6 && (countd == 3 || countd == 4 || countd == 5 || countd == 6)))
                        {
                            return 8;
                        }
                    }
                    s = "";
                }
                countd = 0;
            }
            return 0;
        }
    }
}
