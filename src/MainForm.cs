using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleMaker
{
    public partial class MainForm : Form
    {
        Puzzle puzzle;

        EnterWordsForm wordsForm = null;

        public MainForm(int size)
        {
            InitializeComponent();

            puzzle = new Puzzle(size);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            puzzlePanel.SetPuzzle(puzzle);
            OnPuzzleChange();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void OnPuzzleChange()
        {
            puzzlePanel.Draw();
        }

        private void wordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordsForm == null)
                wordsForm = new EnterWordsForm(puzzle, this);

            wordsForm.Show();
        }

        private void showHideSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            puzzlePanel.Switch();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap bitmap = new Bitmap(puzzlePanel.Width, puzzlePanel.Height);

            Graphics g = Graphics.FromImage(bitmap);
            puzzlePanel.DrawInto(g);

            bitmap.Save(saveFileDialog.FileName);
        }
    }
}
