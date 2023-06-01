LinkedList list = new LinkedList();
list.Insertion(20);
list.Insertion(64);
list.Insertion(2);
list.Insertion(53);
list.Print();

Console.WriteLine("Press any key to exit the program.");
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
    public void Insertion(int value)
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