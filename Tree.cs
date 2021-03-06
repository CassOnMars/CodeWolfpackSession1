namespace ADTs
{
    using System;

    public class Tree
    {
        private Tree[] _leaves = new Tree[0];

        private int _value;

        public Tree(int i)
        {
            this._value = i;
        }

        public Tree(int i, Tree[] leaves) : this(i)
        {
            this._leaves = leaves;
        }

        public void Add(Tree leaf)
        {
            Array.Resize(ref this._leaves, this._leaves.Length + 1);
            this._leaves[this._leaves.Length - 1] = leaf;
        }

        public Tree[] Children()
        {
            var copy = new Tree[this._leaves.Length];
            Array.Copy(this._leaves, copy, this._leaves.Length);

            return copy;
        }

        public int Value() => this._value;
    }
}