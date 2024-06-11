using PowerAutomation.Interfaces;
using System.Collections;

namespace PowerAutomation.Models
{
    public class ProcedureCollection : IList<IProcedure>
    {
        private readonly Comparison<IProcedure> _comparison = new Comparison<IProcedure>((w1, w2) => string.Compare(w1.Title, w2.Title));
        private readonly List<IProcedure> _value = new List<IProcedure>();
        public int Count => _value.Count;

        public bool IsReadOnly => false;

        public IProcedure this[int index]
        {
            get { return _value[index]; }
            set { _value[index] = value; Sort(); }
        }

        public void Add(IProcedure item)
        {
            _value.Add(item);
            Sort();
        }

        public void Clear() => _value.Clear();

        public bool Contains(IProcedure item) => _value.Contains(item);

        public void CopyTo(IProcedure[] array, int arrayIndex)
        {
            _value.CopyTo(array, arrayIndex);
            Sort();
        }

        public IEnumerator<IProcedure> GetEnumerator() => _value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _value.GetEnumerator();

        public int IndexOf(IProcedure item) => _value.IndexOf(item);

        public void Insert(int index, IProcedure item)
        {
            _value.Insert(index, item);
            Sort();
        }

        public bool Remove(IProcedure item) => _value.Remove(item);

        public void RemoveAt(int index) => _value.RemoveAt(index);

        private void Sort() => _value.Sort(_comparison);
    }
}