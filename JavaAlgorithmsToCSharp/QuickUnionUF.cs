using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaAlgorithmsToCSharp
{
    public class QuickUnionUF
    {
        private int[] ids;
        public QuickUnionUF(int n)
        {
            ids = new int[n];
            for(int x= 0; x < n; x++)
            {
                ids[x]= x;
            }
        }
        
        /// <summary>
        /// Finds the root for a particular value
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int Root(int i)
        {
            while(i != ids[i])
            {
                i = ids[i];
            }
            return i;
        }

        public bool Connected(int p, int q)
        {
            return (Root(p) == Root(q));
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);

            ids[i] = j;
        }
    }
}
