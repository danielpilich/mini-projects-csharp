LinkedList list = new LinkedList();
list.InsertAtTop(20);
list.InsertAtBottom(64);
list.InsertAtBottom(2);
list.InsertAtTop(53);
list.Print();

Console.WriteLine("\n\nPress any key to exit the program.");
Console.ReadKey();

class LinkedList
{
    class Element
    {
        public int value;
        public Element next;
        public Element(int value)
        {
            this.value = value;
        }
    }
    private Element first = null;

    public void InsertAtTop(int value)
    {
        Element tmp = new Element(value);
        tmp.next = first;
        first = tmp;
    }

    public void InsertAtBottom(int value)
    {
        if (first == null)
        {
            first = new Element(value);
        }
        else
        {
            Element tmp = first;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.next = new Element(value);
        }
    }

    public void Print()
    {
        if (first == null)
        {
            Console.WriteLine("List is empty :(");
        }
        int count = 1;
        Element tmp = first;
        while (tmp != null)
        {
            Console.WriteLine($"{count++}. {tmp.value}");
            tmp = tmp.next;
        }
    }
}