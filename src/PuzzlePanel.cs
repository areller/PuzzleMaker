using System.Drawing;
using System.Windows.Forms;

namespace PuzzleMaker
{
    public class PuzzlePanel : Panel
    {
        private Puzzle puzzle;

        private Font font;

        private bool showSolution;

        public void SetPuzzle(Puzzle puzzle)
        {
            this.puzzle = puzzle;
        }

        public PuzzlePanel()
        {
            InitializeComponent();

            showSolution = false;
            font = new Font("Arial", 10);
        }

        public void Solution()
        {
            showSolution = true;
            Draw();
        }

        public void Normal()
        {
            showSolution = false;
            Draw();
        }

        public void Switch()
        {
            showSolution = !showSolution;
            Draw();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PuzzlePanel
            // 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PuzzlePanel_Paint);
            this.ResumeLayout(false);

        }

        public void DrawInto(Graphics g)
        {
            int cellWidth = Width / puzzle.Size;
            int cellHeight = Height / puzzle.Size;

            g.Clear(Color.White);

            for (int x = 1; x <= puzzle.Size - 1; x++)
            {
                g.DrawLine(Pens.Black, new Point(cellWidth * x, 0), new Point(cellWidth * x, Height));
                g.DrawLine(Pens.Black, new Point(0, cellHeight * x), new Point(Width, cellHeight * x));
            }

            for (int i = 0; i < puzzle.Size; i++)
            {
                for (int j = 0; j < puzzle.Size; j++)
                {
                    float y = cellHeight * i + cellHeight / 2 - font.Height / 2;
                    float x = cellWidth * j + cellWidth / 2 - font.Size / 2;

                    if (showSolution && puzzle.IsSolution(j, i))
                        g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Yellow)), new Rectangle(new Point(cellWidth * j, cellHeight * i), new Size(cellWidth, cellHeight)));

                    g.DrawString(puzzle[i, j].ToString(), font, Brushes.Black, new PointF(x, y));
                }
            }
        }

        private void PuzzlePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawInto(g);
        }

        public void Draw()
        {
            Refresh();
            Update();
            Invalidate();
        }
    }
}