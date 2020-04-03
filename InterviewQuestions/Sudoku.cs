using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class Sudoku
    {
        public int[,] Board { get; set; }

        public Sudoku() { }

        public Sudoku(int[,] board)
        {
            if(board.GetLength(0) != board.GetLength(1))
            {
                throw new ArgumentException("Invalid board configuration");
            }

            this.Board = board;
        }

        public bool IsRight()
        {
            if (this.Board.GetLength(0) != this.Board.GetLength(1))
                return false;

            List<int> numbersUsed = new List<int>();

            // Check each row
            for (int row = 0; row < this.Board.GetLength(0) - 1; row++)
            {
                for (int column = 0; column < this.Board.GetLength(1) - 1; column++)
                {
                    if (numbersUsed.Contains(this.Board[row, column]))
                    {
                        return false;
                    }

                    numbersUsed.Add(this.Board[row, column]);
                }
                numbersUsed.Clear();
            }
            numbersUsed.Clear();

            // Check each column
            for (int column = 0; column < this.Board.GetLength(0) - 1; column++)
            {
                for (int row = 0; row < this.Board.GetLength(1) - 1; row++)
                {
                    if (numbersUsed.Contains(this.Board[row, column]))
                    {
                        return false;
                    }
                    numbersUsed.Add(this.Board[row, column]);
                }
                numbersUsed.Clear();
            }

            return true;
        }
    }
}
