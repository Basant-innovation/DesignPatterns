using System;
using System.Collections;


namespace IteratorDesignPattern
{
    abstract class IteratorAggregate: IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
