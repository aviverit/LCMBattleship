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
            int k, l;

            for (int i = 0; i < board.GetLength(0); i++)
            { //Traverse rows
                for (int j = 0; j < board.GetLength(1); j++)
                { //Traverse columns
                    if (board[i, j] == 'X')
                    {
                        k = 1;
                        l = 1;
                        while (i >= k && board[i - k, j] != '.')
                        {
                            k++;
                        }
                        while (j >= l && board[i, j - l] != '.')
                        {
                            l++;
                        }
                        if (k == 1 && l == 1)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
