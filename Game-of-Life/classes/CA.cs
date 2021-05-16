using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life.classes
{
    public class CA
    {
        public static int CheckInnerBoardCellsMoore(int[,] pomBoard, int i, int j)
        {
            int cellCount = pomBoard[i - 1, j - 1] + pomBoard[i - 1, j] + pomBoard[i - 1, j + 1] + pomBoard[i, j + 1] + pomBoard[i + 1, j + 1] + pomBoard[i + 1, j] + pomBoard[i + 1, j - 1] + pomBoard[i, j - 1];
            return cellCount;
        }

        public static int CheckBorderBoardCellsMoore(int[,] pomBoard, int i, int j)
        {
            int ak = pomBoard.GetLength(1)-1;
            int cellCount = 0;
            //krawedzie
            //gorna krawedz
            if (i == 0 && j > 0 && j < ak)
            {
                cellCount = pomBoard[i, j - 1] + pomBoard[i + 1, j - 1] + pomBoard[i + 1, j] + pomBoard[i + 1, j + 1] 
                    + pomBoard[i, j + 1] + pomBoard[ak, j - 1] + pomBoard[ak, j] + pomBoard[ak, j + 1];
            }
            // dolna krawedz
            else if (i == ak && j > 0 && j < ak)
            {
                cellCount = pomBoard[i, j-1] + pomBoard[i-1, j-1] + pomBoard[i-1, j] + pomBoard[i-1, j+1] + pomBoard[i, j+1] 
                    + pomBoard[0, j-1] + pomBoard[0, j] + pomBoard[0, j + 1];
            }
            //lewa krawedz
            else if (j == 0 && i > 0 && i < ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i - 1, j + 1] + pomBoard[i, j + 1] + pomBoard[i + 1, j + 1]
                    + pomBoard[i + 1, j] + pomBoard[i - 1, ak] + pomBoard[i, ak] + pomBoard[i + 1, ak];
            }
            //prawa krawedz
            else if (j == ak && i > 0 && i < ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i - 1, j - 1] + pomBoard[i, j - 1] + pomBoard[i + 1, j - 1] 
                    + pomBoard[i + 1, j] + pomBoard[i - 1, 0] + pomBoard[i, 0] + pomBoard[i + 1, 0];
            }
            //rogi
            //prawy dolny rog
            else if (j == ak && i == ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i - 1, j - 1] + pomBoard[i, j - 1] + pomBoard[i, 0]
                    + pomBoard[i - 1, 0] + pomBoard[0, 0] + pomBoard[0, j - 1] + pomBoard[0, j];
            }
            //lewy dolny rog
            else if(j == 0 && i == ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i - 1, j + 1] + pomBoard[i, j + 1] + pomBoard[i - 1, ak] 
                    + pomBoard[i, ak] + pomBoard[0, j] + pomBoard[0, j + 1] + pomBoard[0, ak]; 
            }
            //lewy gorny rog
            else if(j == 0 && i == 0)
            {
                cellCount = pomBoard[i, j + 1] + pomBoard[i + 1, j] + pomBoard[i + 1, j + 1] + pomBoard[i, ak] 
                    + pomBoard[i + 1, ak] + pomBoard[ak, ak] + pomBoard[ak, j] + pomBoard[ak, j + 1];
            }
            //prawy gorny rog
            else if(j == ak  && i == 0)
            {
                cellCount = pomBoard[i, j - 1] + pomBoard[i + 1, j - 1] + pomBoard[i + 1, j] + pomBoard[i, 0] 
                    + pomBoard[i + 1, 0] + pomBoard[ak, 0] + pomBoard[ak, j] + pomBoard[ak, j - 1];
            }
            
            return cellCount;
        }

        public static int CheckInnerBoardCellsNeumann(int[,] pomBoard, int i, int j)
        {
            int cellCount = pomBoard[i + 1, j] + pomBoard[i, j - 1] + pomBoard[i, j + 1] + pomBoard[i - 1, j];
            return cellCount;
        }

        public static int CheckBorderBoardCellsNeumann(int[,] pomBoard, int i, int j)
        {
            int ak = pomBoard.GetLength(1) - 1;
            int cellCount = 0;
            //krawedzie
            //gorna krawedz
            if (i == 0 && j > 0 && j < ak)
            {
                cellCount = pomBoard[i, j - 1] + pomBoard[i, j + 1] + pomBoard[i + 1, j] + pomBoard[ak, j];
            }
            // dolna krawedz
            else if (i == ak && j > 0 && j < ak)
            {
                cellCount = pomBoard[i, j - 1] + pomBoard[i, j + 1] + pomBoard[i - 1, j] + pomBoard[0, j];
            }
            //lewa krawedz
            else if (j == 0 && i > 0 && i < ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i + 1, j] + pomBoard[i, j + 1] + pomBoard[i, ak];
            }
            //prawa krawedz
            else if (j == ak && i > 0 && i < ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i + 1, j] + pomBoard[i, j - 1] + pomBoard[i, 0];
            }
            //rogi
            //prawy dolny rog
            else if (j == ak && i == ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i, j - 1] + pomBoard[i, 0] + pomBoard[0, j];
            }
            //lewy dolny rog
            else if (j == 0 && i == ak)
            {
                cellCount = pomBoard[i - 1, j] + pomBoard[i, j + 1] + pomBoard[i, ak] + pomBoard[0, 0];
            }
            //lewy gorny rog
            else if (j == 0 && i == 0)
            {
                cellCount = pomBoard[i, j + 1] + pomBoard[i + 1, j] + pomBoard[i, ak] + pomBoard[ak, j];
            }
            //prawy gorny rog
            else if (j == ak  && i == 0)
            {
                cellCount = pomBoard[i, j - 1] + pomBoard[i + 1, j] + pomBoard[0, 0] + pomBoard[ak, ak];
            }

            return cellCount;
        }
    }
}
