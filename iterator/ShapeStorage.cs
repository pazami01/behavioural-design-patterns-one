using System;

namespace iterator
{
    public class ShapeStorage<T> where T : Shape, new()
    {
        private const int NumberOfShapes = 5;
        private readonly T[] _shapes = new T[NumberOfShapes];
        private int _index = 0;

        public void AddShape(string name) =>
            _shapes[_index++] = new T {Id = _index, Name = name};

        public T[] GetShapes()
        {
            T[] copy = new T[NumberOfShapes];

            for (int i = 0; i < NumberOfShapes; i++)
            {
                if (_shapes[i] != null)
                {
                    copy[i] = _shapes[i];
                }
            }

            //Array.Copy(_shapes, copy, NumberOfShapes);

            return copy;
        }
        // Additional methods?

        public T this[int i]
        {
            get => _shapes[i];
            set => _shapes[i] = value;
        }
        // Indexer?
    }
}