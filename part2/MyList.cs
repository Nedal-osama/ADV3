using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV3.part2
{
    public class MyList<T>
    {
        private List<T> _items;

        public MyList()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public int Count => _items.Count;

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        // Exists
        public bool Exists(Predicate<T> match)
        {
            foreach (T item in _items)
            {
                if (match(item))
                {
                    return true;
                }
            }
            return false;
        }

        // Find
        public T Find(Predicate<T> match)
        {
            foreach (T item in _items)
            {
                if (match(item))
                {
                    return item;
                }
            }
            return default;
        }

        // FindAll
        public MyList<T> FindAll(Predicate<T> match)
        {
            MyList<T> result = new MyList<T>();
            foreach (T item in _items)
            {
                if (match(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        // FindIndex
        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindIndex(int startIndex, Predicate<T> match)
        {
            for (int i = startIndex; i < _items.Count; i++)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            for (int i = startIndex; i < startIndex + count && i < _items.Count; i++)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        // FindLast
        public T FindLast(Predicate<T> match)
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return _items[i];
                }
            }
            return default;
        }

        // FindLastIndex
        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
            for (int i = startIndex; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
            for (int i = startIndex; i > startIndex - count && i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        // ForEach
        public void ForEach(Action<T> action)
        {
            foreach (T item in _items)
            {
                action(item);
            }
        }

        // TrueForAll
        public bool TrueForAll(Predicate<T> match)
        {
            foreach (T item in _items)
            {
                if (!match(item))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
