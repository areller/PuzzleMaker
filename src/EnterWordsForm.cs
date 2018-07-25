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
    public partial class EnterWordsForm : Form
    {
        Puzzle puzzle;

        MainForm form;

        public EnterWordsForm(Puzzle puzzle, MainForm form)
        {
            InitializeComponent();

            this.puzzle = puzzle;
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wordString = wordsBox.Text.Replace(" ", "");
            string[] words = wordString.Split(',');

            puzzle.Generate(words);
            form.OnPuzzleChange();

            Hide();
        }
    }
}
