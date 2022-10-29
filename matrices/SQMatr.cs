using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Matrices
{


    internal class SQMatr : Matr
    {
        public SQMatr(Matr m) :base(m)
        {
            if (m.N == m.M)
            {
                this.N = m.N;
                this.M = m.M;
                this.Matrix = m.Matrix;
            }
        }
        public SQMatr(int n = 0, bool Zero = false) : base(n, n)
        {
            this.N = n;
            this.M = n;
            double[,] matr = new double[n, n];
            Random r = new Random();
            Random d = new Random();
            if (Zero)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matr[i, j] = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matr[i, j] = r.Next(10);
                    }
                }
            }
            this.Matrix = matr;
        }
        
        public SQMatr Minor(int i, int j)
        {
            SQMatr B = new SQMatr(this.N-1, true);
            for (int k = 0; k < this.N-1; k++)
            {
                for (int l = 0; l < this.M-1; l++)
                {
                    if (k < i)
                    {
                        if (l < j)
                        {
                            B.Matrix[k, l] = this.Matrix[k, l];
                        }
                        else
                        {
                            B.Matrix[k, l] = this.Matrix[k, l+1];
                        }
                    }
                    else
                    {
                        if (l < j)
                        {
                            B.Matrix[k, l] = this.Matrix[k+1, l];
                        }
                        else
                        {
                            B.Matrix[k,l] = this.Matrix[k+1, l+1];
                        }
                    }
                }
            }
            return B;
            
        }

        public double Det()
        {
            if (this.N == 1)
            {
                return this.Matrix[0, 0];
            }
            if (this.M == 2)
            {
                return (this.Matrix[0,0] * this.Matrix[1,1]) - (this.Matrix[0,1] * this.Matrix[1,0]);
            }
            double det = 0;
            for (int c = 0; c < this.M; c++)
            {
                det += (Math.Pow(-1, c)) * this.Matrix[0, c] * this.Minor(0, c).Det();
            }
            return det;
        }

    }
}
