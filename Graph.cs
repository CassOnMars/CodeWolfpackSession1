namespace ADTs
{
    using System;

    public class Graph
    {
        private Map<int, Set> _adjacencyList = new Map<int, Set>();

        public void AddVertex(int i)
        {
            this._adjacencyList.Set(i, new Set());
        }

        public void AddEdge(int i, int v)
        {
            var list1 = this._adjacencyList.Get(i);
            var list2 = this._adjacencyList.Get(v);
            
            if (list1 == null)
            {
                list1 = new Set();
                this._adjacencyList.Set(i, list1);
            }

            if (list2 == null)
            {
                list2 = new Set();
                this._adjacencyList.Set(v, list2);
            }

            list1.Add(v);

            if (i != v)
            {
                list2.Add(i);
            }
        }

        public void RemoveVertex(int i)
        {
            var list = this._adjacencyList.Get(i);

            if (list != null)
            {
                foreach (var v in list.Contents())
                {
                    if (v != i)
                    {
                        var otherList = this._adjacencyList.Get(v);

                        if (otherList != null)
                        {
                            otherList.Remove(i);
                        }
                    }
                }

                this._adjacencyList.Remove(i);
            }
        }

        public void RemoveEdge(int i, int v)
        {
            var list1 = this._adjacencyList.Get(i);
            var list2 = this._adjacencyList.Get(v);

            if (list1 != null && list2 != null)
            {
                list1.Remove(v);
                list2.Remove(i);
            }
        }

        public int[] Neighbors(int i)
        {
            return this._adjacencyList.Get(i)?.Contents() ?? new int[0];
        }

        public bool IsAdjacent(int i, int v)
        {
            var neighbors = this.Neighbors(i);
            
            foreach (var n in neighbors)
            {
                if (n == v) return true;
            }

            return false;
        }
    }
}