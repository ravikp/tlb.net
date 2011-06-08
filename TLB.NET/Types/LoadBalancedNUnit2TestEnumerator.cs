using System.Collections;

namespace NAnt.NUnit2.Types
{
    public class LoadBalancedNUnit2TestEnumerator : IEnumerator
    {
        private IEnumerator _baseEnumerator;

        internal LoadBalancedNUnit2TestEnumerator(LoadBalancedNUnit2TestCollection arguments)
        {
            var temp = (IEnumerable)(arguments);
            _baseEnumerator = temp.GetEnumerator();
        }

        public LoadBalancedNUnit2Test Current
        {
            get { return (LoadBalancedNUnit2Test)_baseEnumerator.Current; }
        }

        object IEnumerator.Current
        {
            get { return _baseEnumerator.Current; }
        }

        public bool MoveNext()
        {
            return _baseEnumerator.MoveNext();
        }

        bool IEnumerator.MoveNext()
        {
            return _baseEnumerator.MoveNext();
        }

        public void Reset()
        {
            _baseEnumerator.Reset();
        }

        void IEnumerator.Reset()
        {
            _baseEnumerator.Reset();
        }
    }
}
