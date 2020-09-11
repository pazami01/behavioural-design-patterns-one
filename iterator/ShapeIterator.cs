using System.Collections;
using System.Collections.Generic;

namespace iterator
{
    public class ShapeIterator<TShape> : IEnumerator<TShape>
    {
        private TShape _collection;
        private int pos = -1;

        public ShapeIterator(TShape collection)
        {
            Current = collection;
            _collection = collection;
        }

        public bool MoveNext()
        {
            pos++;
            return false; // todo
        }

        public void Reset()
        {
            pos = -1;
        }

        public TShape Current { get; }

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}