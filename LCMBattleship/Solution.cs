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

            for (int i = 0; i < board.GetLength(0); i++) { //Traverse rows
                for (int j = 0; j < board.GetLength(1); j++) { //Traverse columns
                    if (board[i, j] == 'X') {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
