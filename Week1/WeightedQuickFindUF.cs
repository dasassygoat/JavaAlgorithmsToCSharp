using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class WeightedQuickFindUF
    {
        private int[] ids;
        private int[] sz;

        /// <summary>
        /// Same as the quick union only with the addition of the extra sz[] for number of objects in the tree rooted at i
        /// </summary>
        /// <param name="n"></param>
        public WeightedQuickFindUF(int n)
        {
            ids = sz = new int[n];
            for(int x = 0; x<n; x++)
            {
                ids[n] = n;
            }
        }

        private int Root(int i)
        {
            while (i != ids[i])
            {
                ids[i] = ids[ids[i]];
                i = ids[i];
            }
            return i;
        }

        public bool Connected(int p, int q)
        {
            return (Root(p) == Root(q));
        }

        /// <summary>
        /// quick union is modified to link root of the smaller tree to root of larger & update the sz array
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            int i = Root(p); //no change
            int j = Root(q); //no change

            if (i == j) return;
            if(sz[i] < sz[j]) { ids[i] = j; sz[j] += sz[i];
            }
            else
            {
                ids[j] = i;
                sz[i] += sz[j]; 
            }

            ids[i] = j;
        }


    }
}
