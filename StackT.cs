namespace ADTs
{
    using System;

    public class Stack<T>
    {
        private T[] _array = new T[0];

        public void Push(T i)
        {
            Array.Resize(ref this._array, this._array.Length + 1);
            this._array[this._array.Length - 1] = i;
        }

        public T? Pop()
        {
            if (this._array.Length != 0)
            {
                var i = this._array[this._array.Length - 1];
                Array.Resize(ref this._array, this._array.Length - 1);
                return i;
            }

            return default(T);
        }

        public T? Peek()
        {
            if (this._array.Length != 0)
                return this._array[this._array.Length - 1];
                
            return default(T);
        }
    }
}