using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestr_Project
{
    public partial class Game : Form
    {
        private const int gridSize = 10;
        private int[, ] cells = new int[92, 52];

        /*
         * Here will be variables for rules
         */
        public int lonelinessThreshold = 2;
        public int overPopulationThreshold = 3;
        public int birthCondition = 3;

        public Game()
        {
            InitializeComponent();
            ResetGrid();
        }

        private void ResetGrid()
        {
            Bitmap grid = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Pen blackPen = new Pen(Color.Black, 1);

            Graphics gridGraphics = Graphics.FromImage(grid);

            gridGraphics.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            //Draw vertical lines
            for (int i = 0; i <= pictureBox1.Width; i += gridSize)
            {
                gridGraphics.DrawLine(blackPen, i, 0, i, pictureBox1.Height);
            }
            
           //Draw horisontal lines
           for (int i = 0; i <= pictureBox1.Height; i += gridSize)
           {
                gridGraphics.DrawLine(blackPen, 0, i, pictureBox1.Width, i);
           }
           pictureBox1.Image = grid;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();

            form.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Visible = true;
        }

        private void FillCell(int x, int y)
        {
            var cornerTopX = gridSize * (x - 1) + 1;
            var cornerTopY = gridSize * (y - 1) + 1;
            var color = Brushes.Red;

            if (cells[x, y] == 0)
            {
                color = Brushes.White;
            }

            Image grid = pictureBox1.Image;

            Graphics gridGraphics = Graphics.FromImage(grid);
            gridGraphics.FillRectangle(color, cornerTopX, cornerTopY, gridSize - 1, gridSize - 1 );
            pictureBox1.Image = grid;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(string.Format("X: {0} Y: {1}, square ({2}, {3})", e.X, e.Y, e.X/gridSize, e.Y/gridSize));
            var xNum = 1 + e.X / gridSize;
            var yNum = 1 + e.Y / gridSize;
            cells[xNum, yNum] = 1 - cells[xNum, yNum];
            FillCell(xNum, yNum);
        }

        private int CalculateAliveNeighbours(int x, int y)
        {
            int aliveNeighbours = 0;

            for (int a = x - 1; a <= x + 1; a++)
            {
                for (int b = y - 1; b <= y + 1; b++)
                {
                    aliveNeighbours += cells[a, b];
                }
            }
            aliveNeighbours -= cells[x, y];
            return aliveNeighbours;
        }

        private void NextStep()
        {
            int[,] cellsNew = new int[92, 52];
            for (int i = 1; i < cells.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < cells.GetLength(1) - 1; j++)
                {
                    int neighbours = CalculateAliveNeighbours(i, j);
                    if (cells[i, j] == 0)
                    {
                        if (neighbours == birthCondition)
                        {
                            cellsNew[i, j] = 1;
                        }
                    }
                    else
                    {
                        if (neighbours <= overPopulationThreshold && neighbours >= lonelinessThreshold)
                        {
                            cellsNew[i, j] = 1;
                        }
                    }
                }
            }
            cells = cellsNew;
            ResetGrid();
            for (int i = 1; i < cells.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < cells.GetLength(1) - 1; j++)
                {
                    if (cells[i, j] == 1)
                    {
                        FillCell(i, j);
                    }
                }
            }
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            NextStep();
        }
    }
}
