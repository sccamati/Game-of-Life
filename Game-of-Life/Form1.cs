using Game_of_Life.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        int[,] gameBoard;
        int[,] pomBoard;

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void randomBtn_Click(object sender, EventArgs e)
        {
            int ak = Convert.ToInt32(akBox.Text);
            int aliveC = Convert.ToInt32(aliveBox.Text);

            gameBoard = new int[ak, ak];
            pomBoard = new int[ak, ak];

            Random random = new Random();
            int a, b;

            int pom = aliveC;

            while (pom > 0)
            {
                a = random.Next(0, ak);
                b = random.Next(0, ak);

                if (gameBoard[a, b] != 1)
                {
                    pomBoard[a, b] = gameBoard[a, b] = 1;
                    pom--;
                }
            }

            drawBoard(gameBoard);

        }
        private void drawBoard(int[,] points)
        {
            var chartMaker = board.ChartAreas[0];
            ChartArea CA = board.ChartAreas[0];
            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = 9;
            chartMaker.AxisY.Minimum = 0;
            chartMaker.AxisY.Maximum = 9;
            chartMaker.AxisY.Interval = 1;
            chartMaker.AxisX.Interval = 1;
            board.Series[0].IsVisibleInLegend = false;

            if (board.Series.Count == 1)
            {
                board.Series.Add("Points");
            }
            else
            {
                board.Series["Points"].Points.Clear();
            }


            board.Series["Points"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            board.Series["Points"].Color = Color.Green;
            board.Series["Points"].MarkerSize = 45;


            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    if (points[i, j] == 1)
                    {
                        board.Series["Points"].Points.AddXY(i, j);
                    }

                }
            }
        }


    }
}
