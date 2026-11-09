internal class Program
{
    private static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.Peek()); // Output: 2
        Console.WriteLine(stack.Pop());  // Output: 2
        Console.WriteLine(stack.Peek());  // Output: 1
    }

    class MyStack<T>
    {
        private List<T> _elements = new List<T>();
        public void Push(T item)
        {
            _elements.Add(item);
        }
        public T Pop()
        {
            if (_elements.Count > 0)
            {
                T item = _elements[_elements.Count - 1];
                _elements.RemoveAt(_elements.Count - 1);
                return item;
            }
            throw new InvalidOperationException("Stack is empty");
        }
        
        public T Peek()
        {
            if (_elements.Count > 0)
            {
                return _elements[_elements.Count - 1];
            }
            throw new InvalidOperationException("Stack is empty");
        }
    }
}