namespace LinkedListClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the link list.
            string[] words =
                { "the", "fox", "jumps", "over", "the", "dog" };
            MyLinkedList<string> sentence = new MyLinkedList<string>(words);
            Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
                sentence.Contains("jumps"));

            // Add the word 'today' to the beginning of the linked list.
            sentence.AddFirst("today");
            Console.WriteLine(sentence.ToString());

            // Move the first node to be the last node.
            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Console.WriteLine(sentence.ToString());

            // Change the last node to 'yesterday'.
            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Console.WriteLine(sentence.ToString());

            // Move the last node to be the first node.
            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Console.WriteLine(sentence.ToString());

            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            Console.WriteLine(current.next.value);

            // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            Console.WriteLine(sentence.ToString());

            // Indicate 'fox' node.
            current = sentence.Find("fox");
            Console.WriteLine(current.next.value);

            // Add 'quick' and 'brown' before 'fox':
            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "brown");
            Console.WriteLine(sentence.ToString());

        }
    }
}