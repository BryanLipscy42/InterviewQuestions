using System;

namespace InterviewQuestions
{
    class Program
    {
        private const string PARAGRAPH = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
        private const string PARAGRAPHWITHSPACES = "  Lorem  ipsum dolor sit amet, consectetur  adipiscing elit.   Lorem ipsum  dolor sit amet, consectetur  adipiscing elit. Lorem ipsum dolor sit amet, consectetur  adipiscing elit.  ";
        private const string SENTANCE = "The quick brown fox jumped over the lazy old dog";
        static void Main(string[] args)
        {
            SudukoGame();
            Console.ReadKey();
        }

        static void SudukoGame()
        {
            // Create suduko game board
            int[,] board = new int[9, 9]
            {
                { 5, 1, 3, 6, 8, 7, 2, 4, 9 },
                { 8, 4, 9, 5, 2, 1, 6, 3, 7 },
                { 2, 6, 7, 3, 4, 9, 5, 8, 1},
                { 1, 5, 8, 4, 6, 3, 9, 7, 2},
                { 9, 7, 4, 2, 1, 8, 3, 6, 5},
                { 3, 2, 6, 7, 9, 5, 4, 1, 8},
                { 7, 8, 2, 9, 3, 4, 1, 5, 6},
                { 6, 3, 5, 1, 7, 2, 8, 9, 4},
                { 4, 9, 1, 8 , 5, 6, 7, 2, 3}
            };

            var suduko = new Sudoku(board);
            Console.WriteLine($"Is board a suduko: {suduko.IsRight()}");


        }

        static DoubleLinkedList CopyDoublyLinkedList()
        {
            var dlList = new DoubleLinkedList();
            dlList.Insert("First");
            dlList.Insert("Second");
            dlList.Insert("Third");
            dlList.Insert("Fourth");
            dlList.Insert("Fifth");
            dlList.Insert("Sixth");
            dlList.Insert("Seventh");
            dlList.Insert("Eighth");
            dlList.Insert("Nineth");
            dlList.Insert("Tenth");

            return dlList.DeepCopy();
        }

        // TODO: Finish this.
        static void CopyDoublyLinkedListWithLoopReference()
        {
            var dlList = new DoubleLinkedList();
            var item1 = dlList.Insert("First");
            var item2 = dlList.Insert("Second");
            var item3 = dlList.Insert("Third");
            var item4 = dlList.Insert("Fourth");
            var item5 = dlList.Insert("Fifth");

            item1.NextNode = item4;
            item4.PreviousNode = item2;

            var newcopy = dlList.DeepCopy();
        }

        
    }
}
