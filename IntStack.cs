namespace StacknQueue;

public class IntStack
{
    private int[] array;
    public int Count { get; private set; }

    public IntStack(int capacity = 4)
    {
        if (capacity <= 0)
        {
            capacity = 4;
        }
        array = new int[capacity];
    }
    public void Resize()
    {
        int[] newArray = new int[array.Length * 2];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }
    public void Push(int value)
    {
        if (Count == array.Length)
        {
            Resize();
        }
        array[Count] = value;
        Count++;
    }
 
    public int Pop()
    {
        if (Count == 0)
        {
            return -1;
        }
        Count--;
        return array[Count];
    }
     
    public void Peek()
    {
        if (Count == 0)
        {
            return;
        }
        Count--;
        Console.WriteLine("Peek:" + array[Count]);
    }
}