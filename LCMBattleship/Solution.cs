using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMBattleship
{
    class Solution
    {
        public int CountBattleships(char[,] board)
        {
            int count = 0;
            int[,] tile = new int[1, board.GetLength(0) * board.GetLength(1) / 2];
            tile[0, 0] = -1;
            int tileX = 0;
            int k, l;

            for (int i = 0; i < board.GetLength(0); i++) { //Traverse rows
                for (int j = 0; j < board.GetLength(1); j++) { //Traverse columns
                    if (board[i, j] == 'X') {
                        k = 1;
                        l = 1;
                        while (board[i - k, j] != '.') {
                            k++;
                        }
                        while (board[i, j - l] != '.') {
                            l++;
                        }
                        if (k == 1 && l == 1) {
                            count++;
                        }
                    }
                }
            }

        return count;
        }
    }
}
