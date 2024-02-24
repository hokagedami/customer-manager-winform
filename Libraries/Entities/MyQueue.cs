namespace Libraries.Entities;
/// <summary>
/// Array based implementation of a Queue data structure with generic type
/// </summary>
/// <typeparam name="T"></typeparam>
public class MyQueue<T> where T : class
{
    private protected T[] MainQueue;
    private protected int Front;
    private protected int Rear;
    private protected int Size;
    private protected int Capacity = 4;
    
    /// <summary>
    /// Constructor that initializes the queue with a default capacity of 4
    /// </summary>
    public MyQueue()
    {
        MainQueue = new T[Capacity];
        Front = 0;
        Rear = -1;
        Size = 0;
    }
    
    /// <summary>
    /// Enqueue an item to the queue
    /// </summary>
    /// <param name="item"></param>
    public virtual void Enqueue(T item)
    {
        if (Size == Capacity)
        {
            IncreaseCapacity();
        }
        Rear = (Rear + 1) % Capacity; // move the rear to the next item
        MainQueue[Rear] = item; // add the item to the rear
        Size++; // increase the size
    }
    
    /// <summary>
    /// Dequeue an item from the queue
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public virtual T Dequeue()
    {
        if (Size == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var item = MainQueue[Front]; // get the item at the front
        Front = (Front + 1) % Capacity; // move the front to the next item
        Size--; // reduce the size
        return item;
    }
    
    /// <summary>
    /// Peek at the item at the front of the queue
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public virtual T Peek()
    {
        if (Size == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return MainQueue[Front];
    }
    
    /// <summary>
    ///  Count of items in the queue
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return Size;
    }
    
    public T[] ToArray()
    {
        var result = new T[Size];
        var index = 0;
        for (var i = Front; i <= Rear; i++)
        {
            result[index] = MainQueue[i];
            index++;
        }
        return result;
    }
    
    /// <summary>
    /// Private method to increase the capacity of the queue
    /// </summary>
    private void IncreaseCapacity()
    {
        Capacity *= 2;
        var temp = new T[Capacity];
        for (var i = 0; i < Size; i++)
        {
            temp[i] = MainQueue[i];
        }
        MainQueue = temp;
    }
}