namespace LinkedList_zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.Append(1);
            list1.Append(3);
            list1.Append(2);
            list1.Append(7);

            LinkedList list2 = new LinkedList();
            list2.Append(5);
            list2.Append(9);
            list2.Append(4);
            

            Node result = LinkedList.ZipLists(list1, list2);

            LinkedList linkedList = new LinkedList();
            linkedList.PrintList(result);
        }
    }
}