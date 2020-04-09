

namespace IteratorDesignPattern
{
    class FibonacciItereator : Iterator
    {
        private FibonacciCollection _collection;
        private int _position = -1;
        
        
        public FibonacciItereator(FibonacciCollection collection)
        {
            _collection = collection;
        }

        public override object Current()
        {
            return _collection.getItems()[_position];
        }

        public override bool MoveNext()
        {
            int updatedPosition = ++_position;

            if (updatedPosition >= 0 && updatedPosition < _collection.getItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            return false;
        }

        public override void Reset()
        {
            _position = -1;
        }
    }
}
