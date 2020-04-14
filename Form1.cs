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

        public Game()
        {
            InitializeComponent();
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(string.Format("X: {0} Y: {1}, square ({2}, {3})", e.X, e.Y, e.X/gridSize, e.Y/gridSize));
            var xNum = 1 + e.X / gridSize;
            var yNum = 1 + e.Y / gridSize;
            var cornerTopX = gridSize * (xNum - 1) + 1;
            var cornerTopY = gridSize * (yNum - 1) + 1;

            var color = Brushes.Red;
            cells[xNum, yNum] = 1 - cells[xNum, yNum];
            if (cells[xNum, yNum] == 0)
            {
                color = Brushes.White;
            }

            Image grid = pictureBox1.Image;

            Graphics gridGraphics = Graphics.FromImage(grid);
            gridGraphics.FillRectangle(color, cornerTopX, cornerTopY, gridSize - 1, gridSize - 1 );
            pictureBox1.Image = grid;
        }

        private void NextStep()
        {
            int[,] cellsNew = new int[92, 52];
            for (int i = 1; i < cells.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < cells.GetLength(1) - 1; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            NextStep();
        }
    }
}
