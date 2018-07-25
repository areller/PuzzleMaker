using System;
using System.Collections.Generic;
using System.Drawing;

namespace PuzzleMaker
{
    public class Puzzle
    {
        private char[,] board;

        private IList<Point> positions;

        private Random rndGen = null;

        public Puzzle(int size)
        {
            board = new char[size, size];
            positions = new List<Point>();

            Clear();
        }

        public char this[int x, int y]
        {
            get { return board[x, y]; }
            set { board[x, y] = value; }
        }

        public int Size
        {
            get { return board.GetLength(0); }
        }

        public void Clear()
        {
            positions.Clear();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                    board[i, j] = '-';
            }
        }

        public void Generate(string[] words)
        {
            Clear();
            int count = words.Length;

            int hCount = randNum((int)(count / 3), 2 * (int)count / 3);
            int vCount = count - hCount;

            for (int i = 0; i < hCount; i++)
            {
                string word = words[i];

                int row = randNum(0, Size);
                int startColumn = randNum(0, Size - word.Length);

                if (row >= Size || startColumn > Size - word.Length)
                {
                    i--;
                    continue;
                }

                bool fit = true;

                for (int x = startColumn; x < startColumn + word.Length; x++)
                {
                    if (board[row, x] != '-')
                    {
                        fit = false;
                        break;
                    }
                }

                if (fit == false)
                {
                    i--;
                    continue;
                }

                for (int x = startColumn; x < startColumn + word.Length; x++)
                {
                    positions.Add(new Point(x, row));
                    board[row, x] = upper(word[x - startColumn]);
                }
            }

            for (int i = 0; i < vCount; i++)
            {
                string word = words[hCount + i];

                int column = randNum(0, Size);
                int startRow = randNum(0, Size - word.Length);

                if (column >= Size || startRow > Size - word.Length)
                {
                    i--;
                    continue;
                }

                bool fit = true;

                for (int x = startRow; x < startRow + word.Length; x++)
                {
                    if (board[x, column] != '-' && board[x, column] != upper(word[x - startRow]))
                    {
                        fit = false;
                        break;
                    }
                }

                if (fit == false)
                {
                    i--;
                    continue;
                }

                for (int x = startRow; x < startRow + word.Length; x++)
                {
                    positions.Add(new Point(column, x));
                    board[x, column] = upper(word[x - startRow]);
                }
            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size;j++)
                {
                    if (board[i, j] == '-')
                        board[i, j] = randChar();
                }
            }
        }

        private char upper(char ch)
        {
            byte chByte = (byte)ch;

            if (chByte >= 97 && chByte <= 122)
                return (char)(chByte - 32);

            return ch;
        }

        private char randChar()
        {
            int rand = randNum(65, 91);
            return (char)rand;
        }

        private int randNum(int a, int b)
        {
            if (rndGen == null)
                rndGen = new Random();

            return rndGen.Next(a, b);
        }

        public bool IsSolution(int x, int y)
        {
            foreach (Point p in positions)
            {
                if (p.X == x && p.Y == y)
                    return true;
            }

            return false;
        }
    }
}