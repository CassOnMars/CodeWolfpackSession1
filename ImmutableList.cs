namespace ADTs
{
    public class ImmutableList
    {
        private ImmutableList? _rest = null;

        private int? _value;

        public ImmutableList() {}

        public ImmutableList(int i, ImmutableList l)
        {
            this._value = i;
            this._rest = l;
        }

        public int? First() => this._value;

        public ImmutableList? Rest() => this._rest;
    }
}