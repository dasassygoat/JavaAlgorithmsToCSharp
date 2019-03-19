using System;

namespace JavaAlgorithmsToCSharp
{
    class QuickFindUF
    {
        private int[] ids;

        

        public QuickFindUF(int n)
        {
            ids = new int[n];
            for(int x = 0; x < n; x++)
            {
                ids[x] = x;
            }
        }

        public bool Connected(int p, int q)
        {            
            return ids[p].Equals(ids[q]);
        }

        public void Union(int p, int q)
        {
            int pid = ids[p];
            int qid = ids[q];
            for(int i = 0; i<ids.Length; i++)
            {
                if (ids[i] == pid)
                {
                    ids[i] = qid;
                }
            }
        }


    }
}
