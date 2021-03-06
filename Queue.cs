namespace ADTs
{
    using System;

    public class Queue
    {
        private int[] _array = new int[0];

        public void Enqueue(int i)
        {
            Array.Resize(ref this._array, this._array.Length + 1);
            this._array[this._array.Length - 1] = i;
        }

        public int? Dequeue()
        {
            if (this._array.Length != 0)
            {
                int i = this._array[0];

                var copy = new int[this._array.Length - 1];
                Array.Copy(this._array, 1, copy, 0, this._array.Length - 1);
                this._array = copy;

                return i;
            }

            return null;
        }
    }
}