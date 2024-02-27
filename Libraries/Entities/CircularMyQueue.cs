namespace Libraries.Entities;

/// <summary>
/// Circular queue implementation with generic type, and has a fixed size.
/// Inherits from Queue class and overrides the Enqueue, Dequeue and Peek methods.
/// Also has private methods to check if the queue is full and check if it is empty.
/// </summary>
/// <typeparam name="T"></typeparam>
public class CircularMyQueue<T>: MyQueue<T> where T : class
{
    public CircularMyQueue(int size)
    {
        Capacity = size;
        MainQueue = new T[Capacity];
    }

    private bool IsFull() => Size == Capacity;

    private bool IsEmpty() => Size == 0;
    public override void Enqueue(T item)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Queue is full");
        }
        RearIndex = (RearIndex + 1) % Capacity;
        MainQueue[RearIndex] = item;
        Size++;
    }
    
    public override T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var item = MainQueue[FrontIndex];
        FrontIndex = (FrontIndex + 1) % Capacity;
        Size--;
        return item;
    }
    
    public override T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return MainQueue[FrontIndex];
    }
}