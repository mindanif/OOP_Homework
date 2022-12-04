using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_other
{

    
    internal class matr<T>: IEnumerable
    {
        public int n = 0;
        public int m = 0;
        public Dictionary<int[], T> matrix = new Dictionary<int[], T>(new MyEqualityComparer());
        public IEnumerator GetEnumerator() => matrix.Values.GetEnumerator();
        public matr(int n, int m)
        {
            this.matrix = new Dictionary<int[], T>(new MyEqualityComparer());
            this.n = n;
            this.m = m;
        }
        public T? this[int ind1, int ind2]
        {
            get
            {
                if (this.matrix.ContainsKey(new int[] { ind1, ind2 }))
                {
                    return this.matrix[new int[]{ ind1, ind2 }];
                }
                else
                {
                    return default(T);
                }
            }
            set
            {
                if (value != null && !value.Equals(default(T)) && (ind1 < n && ind2 < m))
                {
                    this.matrix[new int[] { ind1, ind2 }] = value;
                }
            }
        }
        public void show()
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    Console.Write("{0} ", this[i ,j] );
                }
                Console.WriteLine();
            }
        }
        public matr<T> sq(int x, int y)
        {
            matr<T> M = new matr<T>(3, 3);
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int h = (i + x)%this.n;
                    int w = (j + y)%this.m;
                    if (h < 0) { h += this.n; }
                    if (w < 0) { w += this.m; }
                    M[i + 1, j + 1] = this[h, w];
                }
            }
            return M;
        }
        
    }
    public class MyEqualityComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[] x, int[] y)
        {
            if (x.Length != y.Length)
            {
                return false;
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int GetHashCode(int[] obj)
        {
            int result = 17;
            for (int i = 0; i < obj.Length; i++)
            {
                unchecked
                {
                    result = result * 23 + obj[i];
                }
            }
            return result;
        }
    }
}
