namespace Libraries.Entities;

/// <summary>
/// Array based implementation of a Stack data structure with generic type
/// </summary>
/// <typeparam name="T"></typeparam>
public class MyStack<T> where T : class
{
    private T[] _stack;
    private int _top;
    private int _size;
    private int _capacity = 4;
    
    public MyStack()
    {
        _stack = new T[_capacity];
        _top = -1;
        _size = 0;
    }
    
    /// <summary>
    /// Push an item to the stack.
    /// </summary>
    /// <param name="item"></param>
    public void Push(T item)
    {
        if (_size == _capacity)
        {
            IncreaseCapacity();
        }
        _top++;
        _stack[_top] = item;
        _size++;
    }
    
    /// <summary>
    /// Pop an item from the stack. Removes the item from the stack and returns it.
    /// Throws an InvalidOperationException if the stack is empty.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Pop()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        var item = _stack[_top];
        _top--;
        _size--;
        return item;
    }
    
    /// <summary>
    /// Peek at the item at the top of the stack. Does not remove the item from the stack.
    /// Throws an InvalidOperationException if the stack is empty.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Peek()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _stack[_top];
    }
    
    /// <summary>
    /// Private method to increase the capacity of the stack when it is full.
    /// </summary>
    private void IncreaseCapacity()
    {
        _capacity *= 2;
        var newStack = new T[_capacity];
        Array.Copy(_stack, newStack, _size);
        _stack = newStack;
    }
}