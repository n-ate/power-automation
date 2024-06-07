using System.Collections;

namespace PowerAutomation.Models
{
    public class WorkspaceCollection : IList<Workspace>
    {
        private readonly Comparison<Workspace> _comparison = new Comparison<Workspace>((w1, w2) => string.Compare(w1.Title, w2.Title));
        private readonly List<Workspace> _value = new List<Workspace>();
        public int Count => _value.Count;

        public bool IsReadOnly => false;

        public Workspace this[int index]
        {
            get { return _value[index]; }
            set { _value[index] = value; Sort(); }
        }

        public void Add(Workspace item)
        {
            _value.Add(item);
            Sort();
        }

        public void Clear() => _value.Clear();

        public bool Contains(Workspace item) => _value.Contains(item);

        public void CopyTo(Workspace[] array, int arrayIndex)
        {
            _value.CopyTo(array, arrayIndex);
            Sort();
        }

        public IEnumerator<Workspace> GetEnumerator() => _value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _value.GetEnumerator();

        public int IndexOf(Workspace item) => _value.IndexOf(item);

        public void Insert(int index, Workspace item)
        {
            _value.Insert(index, item);
            Sort();
        }

        public bool Remove(Workspace item) => _value.Remove(item);

        public void RemoveAt(int index) => _value.RemoveAt(index);

        private void Sort() => _value.Sort(_comparison);
    }
}