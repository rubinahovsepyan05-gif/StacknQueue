namespace StacknQueue;

class Program
{
    static void Main(string[] args)
    {
        IntQueue queue = new IntQueue();
        queue.Enqueue(11);
        queue.Enqueue(25);
        queue.Enqueue(73);
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        
        IntStack stack = new IntStack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine(stack.Pop());
        stack.Peek();
    }
}