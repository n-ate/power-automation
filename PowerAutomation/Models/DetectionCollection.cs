using PowerAutomation.Interfaces;
using System.Collections;

namespace PowerAutomation.Models
{
    public class DetectionCollection : IList<IDetection>
    {
        private readonly Comparison<IDetection> _comparison = new Comparison<IDetection>((w1, w2) => string.Compare(w1.Title, w2.Title));
        private readonly List<IDetection> _value = new List<IDetection>();
        public int Count => _value.Count;

        public bool IsReadOnly => false;

        public IDetection this[int index]
        {
            get { return _value[index]; }
            set { _value[index] = value; Sort(); }
        }

        public void Add(IDetection item)
        {
            _value.Add(item);
            Sort();
        }

        public void Clear() => _value.Clear();

        public bool Contains(IDetection item) => _value.Contains(item);

        public void CopyTo(IDetection[] array, int arrayIndex)
        {
            _value.CopyTo(array, arrayIndex);
            Sort();
        }

        public IEnumerator<IDetection> GetEnumerator() => _value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _value.GetEnumerator();

        public int IndexOf(IDetection item) => _value.IndexOf(item);

        public void Insert(int index, IDetection item)
        {
            _value.Insert(index, item);
            Sort();
        }

        public bool Remove(IDetection item) => _value.Remove(item);

        public void RemoveAt(int index) => _value.RemoveAt(index);

        private void Sort() => _value.Sort(_comparison);
    }
}