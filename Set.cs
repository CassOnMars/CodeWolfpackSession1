namespace ADTs
{
    using System;

    public class Set
    {
        public int[] _array = new int[0];

        public Set() {}

        public Set(int[] items)
        {
            foreach (int i in items)
            {
                this.Add(i);
            }
        }

        public void Add(int i)
        {
            for (var j = 0; j < this._array.Length; j++)
            {
                if (this._array[j] == i)
                {
                    return;
                }
            }

            Array.Resize(ref this._array, this._array.Length + 1);
            this._array[this._array.Length - 1] = i;
        }

        public void Remove(int i)
        {
            var index = -1;
            for (var j = 0; j < this._array.Length; j++)
            {
                if (this._array[j] == i)
                {
                    index = j;
                    break;
                }
            }

            if (index != -1)
            {
                for (var j = index; j < this._array.Length - 1; j++)
                {
                    this._array[j] = this._array[j + 1];
                }

                Array.Resize(ref this._array, this._array.Length - 1);
            }
        }

        public int[] Contents()
        {
            var copy = new int[this._array.Length];
            Array.Copy(this._array, copy, this._array.Length);
            return copy;
        }
    }
}