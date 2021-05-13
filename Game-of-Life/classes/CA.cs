using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life.classes
{
    public class CA
    {
        public static int CheckNeighborsCells(int[,] pomBoard, int i, int j)
        {
            int cellCount = 0;
            if (pomBoard[i - 1, j - 1] == 1)
            {
                cellCount++;
            }
            if (pomBoard[i, j - 1] == 1)
            {
                cellCount++;
            }
            if (pomBoard[i + 1, j - 1] == 1)
            {
                cellCount++;
            }
            if (pomBoard[i + 1, j] == 1)
            {
                cellCount++;
            }
            if (pomBoard[i + 1, j + 1] == 1)
            {
                cellCount++;
            }
            if (pomBoard[i, j + 1] == 1)
            {
                cellCount++;
            }
            if (pomBoard[i - 1, j + 1] == 1)
            {
                cellCount++;
            }
            if (pomBoard[i - 1, j] == 1)
            {
                cellCount++;
            }

            return cellCount;
        }
    }
}
