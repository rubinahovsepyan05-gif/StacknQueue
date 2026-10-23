namespace StacknQueue;

public class IntQueue
{
    private int[] array;
    public int Count { get; private set; }
    public IntQueue(int capacity = 4)
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
    public void Enqueue(int value)
    {
        if (Count == array.Length)
        {
            Resize();
        }
        array[Count] = value;
        Count++;
    }
 
    public int Dequeue()
    {
        if (Count == 0)
        {
            return -1;
        }
        int value = array[0];
        for (int i = 0; i < Count - 1; i++)
        {
            array[i] = array[i + 1];
        }
        Count--;
        return value;
    }
}