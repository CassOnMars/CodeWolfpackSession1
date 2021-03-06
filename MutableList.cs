namespace ADTs
{
    using System;

    public class MutableList
    {
        private int[] _array;

        public MutableList()
        {
            this._array = new int[0];
        }

        public MutableList(int[] array)
        {
            this._array = array;
        }

        public void Add(int i)
        {
            Array.Resize(ref this._array, this._array.Length + 1);
            this._array[this._array.Length - 1] = i;
        }

        public void Remove(int index)
        {
            for (var i = index; i < this._array.Length - 1; i++)
            {
                this._array[i] = this._array[i + 1];
            }

            Array.Resize(ref this._array, this._array.Length - 1);
        }

        public int Get(int index)
        {
            return this._array[index];
        }

        public int[] Contents()
        {
            var copy = new int[this._array.Length];
            Array.Copy(this._array, copy, this._array.Length);
            return copy;
        }
    }
}