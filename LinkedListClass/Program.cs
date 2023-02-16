namespace LinkedListClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };
            MyLinkedList<string> list = new MyLinkedList<string> (words);
            Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
                list.Contains("jumps"));

            list.AddFirst("Why");
            Console.WriteLine(list.ToString());

            LinkedListNode<string> mark1 = list.First;
            list.RemoveFirst();
            list.AddLast(mark1);
        }
    }
}