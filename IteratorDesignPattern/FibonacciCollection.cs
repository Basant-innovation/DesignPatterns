using System.Collections;
using System.Collections.Generic;


namespace IteratorDesignPattern
{
    class FibonacciCollection : IteratorAggregate
    {
        List<int> _collection = new List<int>();
        
        public int Fibonacci(int n)
        {
            int result = 0;
            int previous = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = result;
                result = previous;
                previous = temp + previous;
            }
            return result;
        }
        public List<int> getItems()
        {
            return _collection;
        }

        public void AddItem(int num)
        {
            int number = Fibonacci(num);
            _collection.Add(number);
        }

        public override IEnumerator GetEnumerator()
        {
            return new FibonacciItereator(this);
        }
    }
}
