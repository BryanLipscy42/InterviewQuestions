using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            var sq = new StringQuestions();
            var input = "The quick brown fox jumped over the lazy old dog";
            Console.WriteLine($"ReverseCharactersAndWords01:{Environment.NewLine}\toriginal = {input}{Environment.NewLine}\toutput == {sq.ReverseCharactersAndWords01(input)}");
            Console.WriteLine($"ReverseCharactersAndWords02:{Environment.NewLine}\toriginal = {input}{Environment.NewLine}\toutput == {sq.ReverseCharactersAndWords02(input)}");
            
            Console.WriteLine($"Reverse words:{Environment.NewLine}\toriginal = {input}{Environment.NewLine}\toutput == {sq.ReverseWords(input)}");
            Console.WriteLine($"Reverse characters in each word:{Environment.NewLine}\toriginal = {input}{Environment.NewLine}\toutput == {sq.ReverseCharactersInEachWord(input)}");
            
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
