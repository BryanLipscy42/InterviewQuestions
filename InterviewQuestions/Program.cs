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
            var sq = new StringQuestions();
            Console.WriteLine($"ReverseCharactersAndWords01:{Environment.NewLine}\toriginal = {SENTANCE}{Environment.NewLine}\toutput == {sq.ReverseCharactersAndWords01(SENTANCE)}");
            Console.WriteLine($"ReverseCharactersAndWords02:{Environment.NewLine}\toriginal = {SENTANCE}{Environment.NewLine}\toutput == {sq.ReverseCharactersAndWords02(SENTANCE)}");
            
            Console.WriteLine($"Reverse words:{Environment.NewLine}\toriginal = {SENTANCE}{Environment.NewLine}\toutput == {sq.ReverseWords(SENTANCE)}");
            Console.WriteLine($"Reverse characters in each word:{Environment.NewLine}\toriginal = {SENTANCE}{Environment.NewLine}\toutput == {sq.ReverseCharactersInEachWord(SENTANCE)}");

            var wordCounts = sq.CountEachWordInstanceInAString(PARAGRAPH);
            Console.WriteLine("Counting occurances of words in a string");
            foreach(var word in wordCounts)
            {
                Console.WriteLine($"\t{word.Key}\t{word.Value}");
            }

            wordCounts = sq.CountEachWordInstanceInAString(PARAGRAPHWITHSPACES);
            Console.WriteLine("Counting occurances of words in a string with multiple spaces");
            foreach (var word in wordCounts)
            {
                Console.WriteLine($"\t{word.Key}\t{word.Value}");
            }

            Console.ReadKey();
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
