namespace ADTs
{
    using System;

    public class Map<K, V> where K : IEquatable<K>
    {
        private (K key, V value)[] _array = new (K, V)[0];
        
        public void Set(K key, V value)
        {
            var found = false; 

            for (int i = 0; i < this._array.Length; i++)
            {
                var item = this._array[i];

                if (item.key.Equals(key))
                {
                    this._array[i] = (key, value);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Array.Resize(ref this._array, this._array.Length + 1);
                this._array[this._array.Length - 1] = (key, value);
            }
        }

        public V? Get(K key)
        {
            for (int i = 0; i < this._array.Length; i++)
            {
                var item = this._array[i];

                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }

            return default(V);
        }

        public void Remove(K key)
        {
            var index = -1; 

            for (int i = 0; i < this._array.Length; i++)
            {
                var item = this._array[i];

                if (item.key.Equals(key))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < this._array.Length - 1; i++)
                {
                    this._array[i] = this._array[i + 1];
                }

                Array.Resize(ref this._array, this._array.Length - 1);
            }
        }
    }
}