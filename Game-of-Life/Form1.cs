using Game_of_Life.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        int[,] gameBoard;
        int[,] pomBoard;
        bool toEvent = true;
        List<int> alivePercent;
        List<int> deadPercent;
        int t;
        int ak;
        public Form1()
        {
            InitializeComponent();
            akBox.SelectedIndex = 0;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            t = Convert.ToInt32(tBox.Text);

            for (int k = 0; k < t; k++)
            {
                for (int i = 0; i < gameBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < gameBoard.GetLength(1); j++)
                    {
                        int cellCount;
                        if (MooreRadioBtn.Checked == true)
                        {
                            if (i != 0 && j != 0 && i != gameBoard.GetLength(0) - 1 && j != gameBoard.GetLength(1) - 1)
                            {
                                cellCount = CA.CheckInnerBoardCellsMoore(pomBoard, i, j);
                            }
                            else
                            {
                                cellCount = CA.CheckBorderBoardCellsMoore(pomBoard, i, j);
                            }
                        }
                        else
                        {
                            if (i != 0 && j != 0 && i != gameBoard.GetLength(0) - 1 && j != gameBoard.GetLength(1) - 1)
                            {
                                cellCount = CA.CheckInnerBoardCellsNeumann(pomBoard, i, j);
                            }
                            else
                            {
                                cellCount = CA.CheckBorderBoardCellsNeumann(pomBoard, i, j);
                            }
                        }

                        if (cellCount == 3)
                        {
                            gameBoard[i, j] = 1;
                        }
                        else if (cellCount == 2 && gameBoard[i, j] == 1)
                        {
                            gameBoard[i, j] = 1;
                        }
                        else if (cellCount < 2 || cellCount > 3)
                        {
                            gameBoard[i, j] = 0;
                        }
                    }
                }
                gameBox.Refresh();
                MakeChart();
                chartCells.Update();
            }
            deadPercent.Clear();
            alivePercent.Clear();
        }
        private void randomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ak = Convert.ToInt32(akBox.Text);
                int aliveC = Convert.ToInt32(aliveBox.Text);
                if (aliveC > ak * ak)
                {
                    throw new Exception("maksymalna liczba żywych komórek to " + ak * ak);
                }
                gameBoard = new int[ak, ak];
                pomBoard = new int[ak, ak];
                alivePercent = new List<int>();
                deadPercent = new List<int>();

                Random random = new Random();
                int a, b;

                int pom = aliveC;

                if (boardMode.Checked)
                {
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
                }

                if (toEvent)
                {
                    gameBox.Paint += new PaintEventHandler(drawBoard);
                    toEvent = false;
                }

                gameBox.Refresh();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void drawBoard(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int ak = gameBoard.GetLength(1);
            int w = gameBox.Width - 1;
            int h = gameBox.Height - 1;
            int xlines = w / ak;
            int ylines = h / ak;

            List<RectangleF> aliveCells = new List<RectangleF>();
            List<RectangleF> deadCells = new List<RectangleF>();
            List<RectangleF> cameAliveCells = new List<RectangleF>();
            List<RectangleF> dyingCells = new List<RectangleF>();

            if (colorRect.Checked)
            {
                for (int i = 0; i < ak; i++)
                {
                    for (int j = 0; j < ak; j++)
                    {

                        if (pomBoard[i, j] == 0 && gameBoard[i, j] == 1)
                        {
                            cameAliveCells.Add(new RectangleF(new Point(xlines * j + 2, ylines * i + 2), new Size(xlines - 4, ylines - 4)));
                        }
                        else if (pomBoard[i, j] == 1 && gameBoard[i, j] == 0)
                        {
                            dyingCells.Add(new RectangleF(new Point(xlines * j + 2, ylines * i + 2), new Size(xlines - 4, ylines - 4)));
                        }
                        else if (pomBoard[i, j] == 0 && gameBoard[i, j] == 0)
                        {
                            deadCells.Add(new RectangleF(new Point(xlines * j + 2, ylines * i + 2), new Size(xlines - 4, ylines - 4)));
                        }
                        else if (pomBoard[i, j] == 1 && gameBoard[i, j] == 1)
                        {
                            aliveCells.Add(new RectangleF(new Point(xlines * j + 2, ylines * i + 2), new Size(xlines - 4, ylines - 4)));
                        }

                    }
                }
            }
            else
            {
                for (int i = 0; i < ak; i++)
                {
                    for (int j = 0; j < ak; j++)
                    {
                        if (gameBoard[i, j] == 1)
                        {
                            aliveCells.Add(new RectangleF(new Point(xlines * j + 2, ylines * i + 2), new Size(xlines - 4, ylines - 4)));
                        }
                        else
                        {
                            deadCells.Add(new RectangleF(new Point(xlines * j + 2, ylines * i + 2), new Size(xlines - 4, ylines - 4)));
                        }
                    }
                }
            }


            if (aliveCells.Count != 0)
            {
                g.DrawRectangles(Pens.Green, aliveCells.ToArray());
                g.FillRectangles(Brushes.Green, aliveCells.ToArray());
            }
            if (deadCells.Count != 0)
            {
                g.DrawRectangles(Pens.WhiteSmoke, deadCells.ToArray());
                g.FillRectangles(Brushes.WhiteSmoke, deadCells.ToArray());
            }
            if (colorRect.Checked)
            {
                if (cameAliveCells.Count != 0)
                {
                    g.DrawRectangles(Pens.BlueViolet, cameAliveCells.ToArray());
                    g.FillRectangles(Brushes.Blue, cameAliveCells.ToArray());
                }
                if (dyingCells.Count != 0)
                {
                    g.DrawRectangles(Pens.PaleVioletRed, dyingCells.ToArray());
                    g.FillRectangles(Brushes.Red, dyingCells.ToArray());
                }
            }

            if (colorRect.Checked)
            {
                alivePercent.Add(aliveCells.Count + cameAliveCells.Count);
                deadPercent.Add(deadCells.Count + dyingCells.Count);
            }
            else
            {
                alivePercent.Add(aliveCells.Count);
                deadPercent.Add(deadCells.Count);
            }


            for (int i = 0; i < xlines * ak + 1; i += xlines)
            {
                g.DrawLine(Pens.Black, new Point(i, 0), new Point(i, xlines * ak));
            }
            for (int j = 0; j < ylines * ak + 1; j += ylines)
            {
                g.DrawLine(Pens.Black, new Point(0, j), new Point(ylines * ak, j));
            }
            pomBoard = (int[,])gameBoard.Clone();
        }

        private void MakeChart()
        {

            double total = ak * ak;
            chartCells.Series.Clear();
            var chartMaker = chartCells.ChartAreas[0];
            ChartArea CA = chartCells.ChartAreas[0];
            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = t-1;
            chartMaker.AxisY.Interval = 10;
            chartMaker.AxisY.Minimum = 0;
            chartMaker.AxisY.Maximum = 100;

            if (t > 1)
            {
                chartMaker.AxisX.Interval = 1;
            }
            if (t > 40)
            {
                chartMaker.AxisX.Interval = 2;
            }
            if (t > 99)
            {
                chartMaker.AxisX.Interval = 10;
            }
            if (t > 100)
            {
                chartMaker.AxisX.Interval = 10;
            }
            if (t > 500)
            {
                chartMaker.AxisX.Interval = 50;
            }
            if (t > 999)
            {
                chartMaker.AxisX.Interval = 100;
            }
            if (t > 1999)
            {
                chartMaker.AxisX.Interval = 200;
            }

            if (chartCells.Series.Count == 0)
            {
                chartCells.Series.Add("AliveCells");
                chartCells.Series.Add("DeadCells");
            }
            else
            {
                chartCells.Series["AliveCells"].Points.Clear();
                chartCells.Series["DeadCells"].Points.Clear();
            }

            chartCells.Series["AliveCells"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            chartCells.Series["AliveCells"].Color = Color.Green;
            chartCells.Series["AliveCells"].BorderWidth = 2;

            chartCells.Series["DeadCells"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            chartCells.Series["DeadCells"].Color = Color.FromArgb(64, Color.Red); ;
            chartCells.Series["DeadCells"].BorderWidth = 2;


            for (int i = 1; i < alivePercent.Count; i++)
            {
                chartCells.Series["DeadCells"].Points.AddXY(i - 1, (deadPercent[i] / total) * 100);
                chartCells.Series["AliveCells"].Points.AddXY(i - 1, (alivePercent[i - 1] / total) * 100);

            }

        }


        private void MooreRadioBtn_Click(object sender, EventArgs e)
        {
            NeumannRadioBtn.Checked = false;
        }

        private void NeumannRadioBtn_Click(object sender, EventArgs e)
        {
            MooreRadioBtn.Checked = false;
        }

        private void gameBox_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;
            int ak = gameBoard.GetLength(1);
            int w = gameBox.Width - 1;
            int h = gameBox.Height - 1;
            int xlines = w / ak;
            int ylines = h / ak;

            if (mouseEventArgs.X < w / 2 && mouseEventArgs.Y < h / 2)
            {
                for (int i = 0; i < (ak + 1) / 2; i++)
                {
                    for (int j = 0; j < (ak + 1) / 2; j++)
                    {
                        if (mouseEventArgs.X > xlines * j && mouseEventArgs.X < xlines * (j + 1) && mouseEventArgs.Y > ylines * i && mouseEventArgs.Y < ylines * (i + 1))
                        {
                            pomBoard[i, j] = gameBoard[i, j] = gameBoard[i, j] == 0 ? 1 : 0;
                        }
                    }
                }
            }
            else if (mouseEventArgs.X > w / 2 && mouseEventArgs.Y < h / 2)
            {
                for (int i = 0; i < (ak + 1) / 2; i++)
                {
                    for (int j = (ak + 1) / 2; j < ak; j++)
                    {
                        if (mouseEventArgs.X > xlines * j && mouseEventArgs.X < xlines * (j + 1) && mouseEventArgs.Y > ylines * i && mouseEventArgs.Y < ylines * (i + 1))
                        {
                            pomBoard[i, j] = gameBoard[i, j] = gameBoard[i, j] == 0 ? 1 : 0;
                        }
                    }
                }
            }
            else if (mouseEventArgs.X < w / 2 && mouseEventArgs.Y > h / 2)
            {
                for (int i = (ak + 1) / 2; i < ak; i++)
                {
                    for (int j = 0; j < (ak + 1); j++)
                    {
                        if (mouseEventArgs.X > xlines * j && mouseEventArgs.X < xlines * (j + 1) && mouseEventArgs.Y > ylines * i && mouseEventArgs.Y < ylines * (i + 1))
                        {
                            pomBoard[i, j] = gameBoard[i, j] = gameBoard[i, j] == 0 ? 1 : 0;
                        }
                    }
                }
            }
            else if (mouseEventArgs.X > w / 2 && mouseEventArgs.Y > h / 2)
            {
                for (int i = (ak + 1) / 2; i < ak; i++)
                {
                    for (int j = (ak + 1) / 2; j < ak; j++)
                    {
                        if (mouseEventArgs.X > xlines * j && mouseEventArgs.X < xlines * (j + 1) && mouseEventArgs.Y > ylines * i && mouseEventArgs.Y < ylines * (i + 1))
                        {
                            pomBoard[i, j] = gameBoard[i, j] = gameBoard[i, j] == 0 ? 1 : 0;
                        }
                    }
                }
            }
            gameBox.Refresh();
        }
    }
}
