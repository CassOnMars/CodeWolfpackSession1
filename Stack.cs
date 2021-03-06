namespace ADTs
{
    using System;

    public class Stack
    {
        private int[] _array = new int[0];

        public void Push(int i)
        {
            Array.Resize(ref this._array, this._array.Length + 1);
            this._array[this._array.Length - 1] = i;
        }

        public int? Pop()
        {
            if (this._array.Length != 0)
            {
                var i = this._array[this._array.Length - 1];
                Array.Resize(ref this._array, this._array.Length - 1);
                return i;
            }

            return null;
        }

        public int? Peek()
        {
            if (this._array.Length != 0)
                return this._array[this._array.Length - 1];

            return null;
        }
    }
}